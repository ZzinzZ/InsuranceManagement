using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class TypeInsuranceAccess
    {
        public static void LoadDataTypeInsurance(ComboBox comboBox, Dictionary<string, string> typeInsuranceDictionary)
        {
            SqlConnection connection = SqlConnectionData.Connection();
            try
            {
                connection.Open();
                string query = "SELECT InsuranceTypeId, NameType FROM TypeInsurance";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string typeId = reader["InsuranceTypeId"].ToString();
                    string nameType = reader["NameType"].ToString();
                    comboBox.Items.Add(nameType);
                    typeInsuranceDictionary.Add(nameType, typeId);
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
    }
}
