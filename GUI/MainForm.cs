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
    public partial class MainForm : Form
    {
        private string loginRole;
        private string loginId;

        private Form currentFormChild;
        public MainForm(string loginId, string role)
        {
            InitializeComponent();
            this.loginRole = role;
            this.loginId = loginId;
        }



        private void OpenChildForm(Form ChildForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(ChildForm);
            mainPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            switch (loginRole)
            {
                case "ADMIN":
                    OpenChildForm(new AdminMain(loginId));
                    break;
                case "CREATOR":
                    OpenChildForm(new CreatorMain(loginId));
                    break;
                case "CUSTOMER":
                    OpenChildForm(new CustomerMain(loginId));
                    break;
                case "SUPERVISOR":
                    OpenChildForm(new SupervisorMain(loginId));
                    break;
                default:
                    MessageBox.Show("Err");
                    break;
            }
        }

        private void mainBodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
