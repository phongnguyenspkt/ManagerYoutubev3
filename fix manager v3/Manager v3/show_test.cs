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
    public partial class show_test : Form
    {
        public show_test()
        {
            InitializeComponent();
        }
        List<kenhtest> kenhchets;
        List<kenhtest> kenhno;
        List<kenhtest> kenhnovideo;
        public show_test(List<kenhtest> _kenhchet,List<kenhtest> _kenhno,List<kenhtest> _kenhnovideo)
        {
            kenhchets = _kenhchet;
            kenhno = _kenhno;
            kenhnovideo = _kenhnovideo;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void show_test_Load(object sender, EventArgs e)
        {
           foreach(kenhtest a in kenhchets)
           {
               ListViewItem item = new ListViewItem();
               item.Text = a.Id;
               listchannel.Items.Add(item);
               item.SubItems.Add(a.Name1);
               item.SubItems.Add(a.Mail);
               item.SubItems.Add(a.Ga);
               item.SubItems.Add(a.Note);
           }
           foreach (kenhtest i in kenhno)
           {
               ListViewItem item = new ListViewItem();
               item.Text = i.Id;
               listtest.Items.Add(item);
               item.SubItems.Add(i.Name1);
               item.SubItems.Add(i.Mail);
               item.SubItems.Add(i.Ga);
               item.SubItems.Add(i.Note);
           }
           foreach (kenhtest i in kenhnovideo)
           {
               ListViewItem item = new ListViewItem();
               item.Text = i.Id;
               listnovideo.Items.Add(item);
               item.SubItems.Add(i.Name1);
               item.SubItems.Add(i.Mail);
               item.SubItems.Add(i.Ga);
               item.SubItems.Add(i.Note);
           }
        }

        private void btngetnote_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtnote.Text);
        }

        private void listchannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listchannel.SelectedItems[0];
                txtnote.Text = item.SubItems[4].Text;
            }
            catch
            {
                
            }
        }

        private void listtest_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listtest.SelectedItems[0];
                txtnote.Text = item.SubItems[4].Text;
            }
            catch
            {

            }
        }

        private void listnovideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listnovideo.SelectedItems[0];
                txtnote.Text = item.SubItems[4].Text;
            }
            catch
            {

            }
        }
    }
}
