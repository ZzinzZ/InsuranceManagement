using DAL;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registerNavbtn_Click(object sender, EventArgs e)
        {
            picture.Location = new Point(0,0);
        }

        private void loginNavbtn_Click(object sender, EventArgs e)
        {
            picture.Location = new Point(240, 0);
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string email = loginEmailtxt.Text;
            string password = loginPasswordtxt.Text;

            byte[] hashPass = Encoding.UTF8.GetBytes(AccountAccess.HashSHA1(password));

            // Gọi hàm LoginDAL để kiểm tra đăng nhập
            (int result, string roleId) = AccountAccess.LoginDAL(email, hashPass);

            if (result == 1)
            {
                if(roleId == "CUSTOMER")
                {
                    string customerId = AccountAccess.getCustomerId(email);
                    MessageBox.Show("Khách hàng " + customerId + " đăng nhập thành công");
                }
                else
                {
                    string userId = AccountAccess.getEmployId(email);
                    MainForm mainForm = new MainForm(userId,roleId);
                    mainForm.Show();
                    this.Hide();
                }
            }
            else
            {
                // Đăng nhập không thành công
                MessageBox.Show("Sai email hoặc mật khẩu.");
            }
        }
    }
}
