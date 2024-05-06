using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace DAL
{
    public class AccountAccess
    {
        public static (int, string) LoginDAL(string email, byte[] password)
        {
            string roleId = "";
            int result = 0;

            // Kết nối và thực thi procedure
            using (SqlConnection connection = SqlConnectionData.Connection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_LOGIN";
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.Add("@Role", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;

                connection.Open();
                cmd.ExecuteNonQuery();

                result = (int)cmd.Parameters["@Result"].Value;
                roleId = cmd.Parameters["@Role"].Value != DBNull.Value ? (string)cmd.Parameters["@Role"].Value : "";
            }

            return (result, roleId);
        }

        public static string getCustomerId(string email)
        {
            string query = "SELECT CustomerId FROM Customer WHERE Email = @Email";
            SqlConnection connection = SqlConnectionData.Connection();
            SqlCommand customerIdCmd = new SqlCommand(query, connection);
            customerIdCmd.Parameters.AddWithValue("@Email", email);
            connection.Open();
            object customerIdResult = customerIdCmd.ExecuteScalar();
            string customerId = customerIdResult != null ? customerIdResult.ToString() : "";
            connection.Close();
            return customerId;
        }

        public static string getEmployId(string email)
        {
            string query = "SELECT UserId FROM Employee WHERE Email = @Email";
            SqlConnection connection = SqlConnectionData.Connection();
            SqlCommand userIdCmd = new SqlCommand(query, connection);
            userIdCmd.Parameters.AddWithValue("@Email", email);
            connection.Open();
            object userIdResult = userIdCmd.ExecuteScalar();
            string userId = userIdResult != null ? userIdResult.ToString() : "";
            connection.Close();
            return userId;
        }

        public static string HashSHA1(string input)
            {
                using (SHA1Managed sha1 = new SHA1Managed())
                {
                    byte[] hashBytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (byte b in hashBytes)
                    {
                        stringBuilder.Append(b.ToString("x2"));
                    }
                    return stringBuilder.ToString();
                }
            }

        public static void LoadDataRole(ComboBox comboBox, Dictionary<string, string> roleDictionary)
        {
            SqlConnection connection = SqlConnectionData.Connection();
            try
            {
                connection.Open();
                string query = "SELECT RoleId, RoleName FROM Role";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string roleId = reader["RoleId"].ToString();
                    string roleName = reader["RoleName"].ToString();
                    comboBox.Items.Add(roleName);
                    roleDictionary.Add(roleName, roleId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public static Employee CreateEmployee(string name, string email, byte[] password, string roleId, string insuranceTypeId)
        {
            Employee newEmployee = null;

            using (SqlConnection connection = SqlConnectionData.Connection())
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SP_INS_EMPLOYEE";
                command.Connection = connection;

                string employeeId = Guid.NewGuid().ToString();

                command.Parameters.AddWithValue("@EmployId", employeeId);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@RoleId", roleId);
                command.Parameters.AddWithValue("@InsuranceTypeId", insuranceTypeId);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        newEmployee = new Employee
                        {
                            UserId = employeeId,
                            Email = email,
                            EmployName = name,
                            Password = password, 
                            RoleId = roleId,
                            InsuranceTypeId = insuranceTypeId
                        };
                        MessageBox.Show("Tạo tài khoản nhân viên thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tạo tài khoản thất bại");
                }
            }

            return newEmployee;
        }

        public static List<AccountInfo> GetAllAccountInfo()
        {
            List<AccountInfo> accountInfoList = new List<AccountInfo>();

            using (SqlConnection connection = SqlConnectionData.Connection())
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = @"SELECT UserId,Email AS Email, EmployName AS UserName, RoleId AS Role, InsuranceTypeId FROM Employee
                                    UNION
                                    SELECT CustomerId AS UserId,Email AS Email, Name AS UserName, RoleId AS Role, 'ALL' AS InsuranceTypeId FROM Customer";
                command.Connection = connection;

                try
                {
                    connection.Open(); 
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        AccountInfo accountInfo = new AccountInfo();
                        accountInfo.UserId = reader["UserId"].ToString();
                        accountInfo.Email = reader["Email"].ToString();
                        accountInfo.UserName = reader["UserName"].ToString();
                        accountInfo.Role = reader["Role"].ToString();
                        accountInfo.InsuranceType = reader["InsuranceTypeId"].ToString();

                        accountInfoList.Add(accountInfo);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching account info: " + ex.Message);
                }
            }

            return accountInfoList;
        }

        public static Customer CreateCustomer(string name, string email, byte[] password, string role)
        {
            SqlConnection connection = SqlConnectionData.Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_ADD_CUSTOMER";
            command.Connection = connection;

            command.Parameters.AddWithValue("@CustomerId", Guid.NewGuid().ToString());
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Role", role);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Customer newCustomer = null;
            if (reader.Read())
            {
                newCustomer = new Customer
                {
                    CustomerId = reader["CustomerId"].ToString(),
                    Name = reader["Name"].ToString(),
                    Email = reader["Email"].ToString(),
                    RoleId = reader["RoleId"].ToString(),
                };
                MessageBox.Show("Tạo tài khoản nhân viên thành công");
            }

            reader.Close();
            connection.Close();

            return newCustomer;
        }

        public static bool EditCustomer(string customerId, string name, byte[] password)
        {
            bool success = false;

            using (SqlConnection connection = SqlConnectionData.Connection())
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SP_EDIT_CUSTOMER";
                command.Connection = connection;

                command.Parameters.AddWithValue("@CustomerId", customerId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    success = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return success;
        }

        public static bool EditEmployee(string userId, string name, byte[] password, string role, string typeId)
        {
            bool success = false;

            using (SqlConnection connection = SqlConnectionData.Connection())
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SP_EDIT_EMPLOYEE";
                command.Connection = connection;

                command.Parameters.AddWithValue("@EmployId", userId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@RoleId", role);
                command.Parameters.AddWithValue("@InsuranceTypeId", typeId);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    success = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return success;
        }

        public static bool DeleteUser(string userId, string roleId)
        {
            bool success = false;

            using (SqlConnection connection = SqlConnectionData.Connection())
            {
                SqlCommand command = new SqlCommand();
                if(roleId != "CUSTOMER")
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_DEL_EMPLOYEE";
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@UserId", userId);
                }
                else
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_DEL_CUSTOMER";
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@CustomerId", userId);
                }
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    success = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return success;
        }

    }
}
