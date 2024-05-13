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
    public partial class AdminMain : Form
    {
        private string loginId;
        private Form currentFormChild;
        public AdminMain(string loginId)
        {
            InitializeComponent();
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
            AdminMainBody.Controls.Add(ChildForm);
            AdminMainBody.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        private void AdminMain_Load(object sender, EventArgs e)
        {
            OpenChildForm(new AdminAccount());
        }

        private void userNav_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminAccount());
        }

        private void typeInsNav_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminInsuranceType());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
