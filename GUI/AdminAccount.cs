using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AdminAccount : Form
    {
        Dictionary<string, string> typeInsuranceDictionary = new Dictionary<string, string>();
        Dictionary<string, string> roleDictionary = new Dictionary<string, string>();
        private string actionType = "";
        public AdminAccount()
        {
            InitializeComponent();
        }


        private void addbtn_Click(object sender, EventArgs e)
        {
            actionType = "Add";
            nametxt.Enabled = true;
            emailtxt.Enabled = true;
            passwordtxt.Enabled = true;
            rolecbx.Enabled = true;
            typeInscbx.Enabled = true;
        }

        private void cancelAction()
        {
            actionType = "";
            //Unable
            nametxt.Enabled = false;
            emailtxt.Enabled = false;
            passwordtxt.Enabled = false;
            rolecbx.Enabled = false;
            typeInscbx.Enabled = false;
            //Clear data
            nametxt.Clear();
            emailtxt.Clear();
            passwordtxt.Clear();
            rolecbx.SelectedItem = null;
            typeInscbx.SelectedItem = null;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            actionType = "Edit";
            nametxt.Enabled = true;
            passwordtxt.Enabled = true;
            rolecbx.Enabled = true;
            typeInscbx.Enabled = true;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            actionType = "Delete";
        }

        private void canclebtn_Click(object sender, EventArgs e)
        {
            cancelAction();
        }

        private void LoadUserDataGridView()
        {
            List<AccountInfo> accountInfoList = AccountAccess.GetAllAccountInfo();

            // Gán danh sách người dùng cho DataSource của DataGridView
            datalistUser.DataSource = accountInfoList;

            // Tùy chỉnh hiển thị tên cột trên DataGridView
            datalistUser.Columns["UserId"].HeaderText = "ID";
            datalistUser.Columns["UserName"].HeaderText = "Tên";
            datalistUser.Columns["Role"].HeaderText = "Vai trò";
            datalistUser.Columns["InsuranceType"].HeaderText = "Loại bảo hiểm";
            datalistUser.Refresh();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (actionType == "Add")
            {
                string name = nametxt.Text;
                string email = emailtxt.Text;
                string password = passwordtxt.Text;
                string typeName = typeInscbx.SelectedItem.ToString();
                string typeId = typeInsuranceDictionary[typeName];
                string roleName = rolecbx.SelectedItem.ToString();
                string roleId = roleDictionary[roleName];
                byte[] hashPass = Encoding.UTF8.GetBytes(AccountAccess.HashSHA1(password));

                if (roleId == "CUSTOMER")
                {
                    Customer newCustomer = null;
                    newCustomer = AccountAccess.CreateCustomer(name, email, hashPass,roleId);
                    LoadUserDataGridView();
                    cancelAction();
                }
                else
                {
                    Employee newEmployee = null;
                    newEmployee = AccountAccess.CreateEmployee(name, email, hashPass,roleId,typeId);
                    LoadUserDataGridView();
                    cancelAction();
                }
            }
            else if(actionType == "Edit")
            {
                
                if(datalistUser.SelectedRows.Count > 0)
                {
                    string id = datalistUser.SelectedRows[0].Cells["UserId"].Value.ToString();
                    string name = nametxt.Text;
                    string password = passwordtxt.Text;
                    string typeName = typeInscbx.SelectedItem.ToString();
                    string typeId = typeInsuranceDictionary[typeName];
                    string roleName = rolecbx.SelectedItem.ToString();
                    string roleId = roleDictionary[roleName];
                    byte[] hashPass = Encoding.UTF8.GetBytes(AccountAccess.HashSHA1(password));

                    if (roleId == "CUSTOMER")
                    {
                        rolecbx.Enabled = false;
                        if (AccountAccess.EditCustomer(id, name, hashPass))
                        {
                            LoadUserDataGridView();
                            cancelAction();
                            MessageBox.Show("Chỉnh sửa thông tin khách hàng thành công!");
                        }
                    }
                    else
                    {
                        rolecbx.Enabled = false;
                        if (AccountAccess.EditEmployee(id,name,hashPass,roleId,typeId))
                        {
                            LoadUserDataGridView();
                            cancelAction();
                            MessageBox.Show("Chỉnh sửa thông tin nhân viên thành công!");
                        }    
                    }
                }
                else if(actionType == "Delete")
                {
                    if(datalistUser.SelectedRows.Count > 0)
                    {
                        string id = datalistUser.SelectedRows[0].Cells["UserId"].Value.ToString();
                        string roleName = rolecbx.SelectedItem.ToString();
                        string roleId = roleDictionary[roleName];
                        if (AccountAccess.DeleteUser(id, roleId))
                        {
                            LoadUserDataGridView();
                            cancelAction();
                            MessageBox.Show("Xóa tài khoản thành công!");
                        }
                    }
                }
            }

        }

        private void AdminAccount_Load(object sender, EventArgs e)
        {
            TypeInsuranceAccess.LoadDataTypeInsurance(typeInscbx,typeInsuranceDictionary);
            AccountAccess.LoadDataRole(rolecbx,roleDictionary);
            LoadUserDataGridView();
        }

        private void datalistUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(actionType == "Edit" || actionType == "Delete")
            {

            }
        }
    }
}
