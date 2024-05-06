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
    public partial class CreatorMain : Form
    {
        private string loginId;
        public CreatorMain(string loginId)
        {
            InitializeComponent();
            this.loginId = loginId;
        }

        private void CreatorMain_Load(object sender, EventArgs e)
        {

        }
    }
}
