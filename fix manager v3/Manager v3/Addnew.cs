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
    public partial class Addnew : Form
    {
        int so = 0;
        int trangthai = 0;
        // trạng thái 
        //1 insert
        //2 show
        //3 edit
        public Addnew(int _so,int _trangthai)
        {
            so = _so;
            trangthai = _trangthai;
            InitializeComponent();
        }
#region
        string id="";
        string name="";
        string idchannel="";
        string mail="";
        string ga="";
        string note="";
#endregion
        public Addnew(string _id,string _name,string _idchannel,string _mail,string _ga,string _note,int _trangthai)
        {
            id = _id;
            name = _name;
            idchannel = _idchannel;
            mail = _mail;
            ga = _ga;
            note = _note;
            trangthai = _trangthai;
            InitializeComponent();
        }
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.ResetText();
            txtname.ResetText();
            txtidchannel.ResetText();
            txtmail.ResetText();
            txtga.ResetText();
            txtnote.ResetText();
            txtid.Focus();
        }

        private void Addnew_Load(object sender, EventArgs e)
        {
           if(trangthai==1)
           {
               txtid.Text = so.ToString();
               this.ActiveControl = txtidchannel;
           }
            if(trangthai==2)
            {
                btnOk.Visible = false;
                txtid.Text = id;
                txtname.Text = name;
                txtidchannel.Text = idchannel;
                txtga.Text = ga;
               txtmail.Text=mail;
               txtnote.Text = note;
               btnexit.Text = "Ok";
            }
            if(trangthai==3)
            {
                
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ManagerYtb.id = txtid.Text;
            ManagerYtb.name = txtname.Text;
            ManagerYtb.idchannel = txtidchannel.Text;
            ManagerYtb.mail = txtmail.Text;
            ManagerYtb.ga = txtga.Text;
            ManagerYtb.note = txtnote.Text;
            this.Close();
        }
    }
}
