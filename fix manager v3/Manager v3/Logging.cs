using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_v3
{
    public partial class Logging : Form
    {
        public Logging()
        {
            InitializeComponent();

        }
        private void Logging_Load(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            string name = this.txtname.Text;
            if(name=="hacker")
            {
                txtname.Visible = false;
                txtpass.Visible = true;
                txtpass.Focus();
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            string pass = this.txtpass.Text;
            if(pass=="pc")
            {
                this.Hide();
                ManagerYtb a = new ManagerYtb();
                a.Show();
            }
        }
    }
}
