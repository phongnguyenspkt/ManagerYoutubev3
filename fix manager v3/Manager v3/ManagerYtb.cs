using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
// google apis
using System.Net;
//
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Manager_v3
{
    public partial class ManagerYtb : Form
    {
        public ManagerYtb()
        {
            InitializeComponent();
        }
        #region
        SqlConnection con;
        DataSet dataset;
        SqlDataAdapter dataapter;
        public static string id = string.Empty;
       public static string name = string.Empty;
       public static string idchannel = string.Empty;
       public static string mail = string.Empty;
       public static string ga = string.Empty;
       public static string note = string.Empty;
        List<string> day=new List<string>();
        // biến trong listview
        string vchannel;
        string vtitile;
        string description;
        string like;
        string dislike;
        string view;
        string vday;
        string link;
        string money;
        string comment;
        string times;
        #endregion

        private void ManagerYtb_Load(object sender, EventArgs e)
        {
            loaddata();
            creat_insert();
           // string[] mn = {"Có","Không" };
          //  cbmoney.Items.AddRange(mn);
        }
        //load dữ liệu lên griw
 
        public void loaddata()
        {
            string ketnoi = @"Data Source=(local);Initial Catalog=data_trial_view;Integrated Security=True";
            con = new SqlConnection(ketnoi);
            string selects = @"Select * From channel";
            dataapter = new SqlDataAdapter(selects,con);
            dataset = new DataSet("table");
            dataapter.Fill(dataset, "data_trial");
            data_mail.DataSource = dataset.Tables["data_trial"];
            data_mail.Columns["id"].Width = 40;
            data_mail.Columns["Name"].Width =200;
            data_mail.Columns["idchannel"].Width =80;
            data_mail.Columns["mail"].Width = 200;
            data_mail.Columns["ga"].Width = 200;
            data_mail.Columns["note"].Width =400;   
            //
            creat_insert();
            creat_edit();
            creat_Delete();
        }
        //lấy mã
        public int layso()
        {
            int vitri=0;
            string sChuoiKetNoi = @"Data Source=(local);Initial Catalog=data_trial_view;Integrated Security=True";
            //Chuỗi truy vấn
            string getma = @"Select id From channel";
            SqlDataAdapter dataget= new SqlDataAdapter(getma, sChuoiKetNoi);
            DataTable dt = new DataTable();
            dataget.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                // Lấy chỉ số phần tử dòng cuối cùng 
                int iDongCuoi = dt.Rows.Count - 1;
                vitri = int.Parse(dt.Rows[iDongCuoi][0].ToString());
            }
            return vitri;
        }
      public void test_channel()
        {
            string sChuoiKetNoi = @"Data Source=(local);Initial Catalog=data_trial_view;Integrated Security=True";
            //Chuỗi truy vấn
            string getma = @"Select * From channel";
            SqlDataAdapter dataget = new SqlDataAdapter(getma, sChuoiKetNoi);
            DataTable dt = new DataTable();
          //data table dùng lấy dữ liệu--> table ảo
            dataget.Fill(dt);
          //  if (dt.Rows.Count > 0)
           // {
                // Lấy chỉ số phần tử dòng cuối cùng 
            //    int iDongCuoi = dt.Rows.Count - 1;
               // vitri = int.Parse(dt.Rows[iDongCuoi][0].ToString());
           // }
            List<kenhtest> listchanneldie = new List<kenhtest>();
            List<kenhtest> listno = new List<kenhtest>();
            List<kenhtest> listnovideo = new List<kenhtest>();
            
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                string idtest=json_testchannel(dt.Rows[i][2].ToString());
               if(idtest=="0")
               {
                   listchanneldie.Add(new kenhtest(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString()));
               }
               else
               {
                   try
                   {


                       string id_videom = "https://www.googleapis.com/youtube/v3/playlistItems?part=contentDetails&maxResults=1&playlistId=" + idtest + "&key=AIzaSyAyL0tx2-Rqtw2DIYbaahvcV3b1-1Uk-I4";
                       WebClient wC_idm = new WebClient { Encoding = Encoding.UTF8 };
                       string jsonString_idvideom = wC_idm.DownloadString(id_videom);
                       JObject jObj_id_videom = (JObject)JsonConvert.DeserializeObject(jsonString_idvideom);
                       string lid = jObj_id_videom["items"][0]["contentDetails"]["videoId"].ToString();



                       // kiểm tra kiếm tiền
                       string input = "https://www.googleapis.com/youtube/v3/videos?id=" + lid + "&key=AIzaSyAyL0tx2-Rqtw2DIYbaahvcV3b1-1Uk-I4&part=contentDetails";
                       WebClient wC = new WebClient { Encoding = Encoding.UTF8 };
                       string jsonString = wC.DownloadString(input);
                       JObject jObj = (JObject)JsonConvert.DeserializeObject(jsonString);
                       string lmoney = jObj["items"][0]["contentDetails"]["licensedContent"].ToString();
                       if (lmoney == "False")
                       {
                           listno.Add(new kenhtest(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString()));
                       }
                   }
                   catch
                   {
                       listnovideo.Add(new kenhtest(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString()));
                   }
                  
               }
            }

            show_test jtest = new show_test(listchanneldie,listno,listnovideo);
            jtest.Show();
        }
        // xử lí json của test_channel
        string  json_testchannel(String id)
        {
            string idupload = "https://www.googleapis.com/youtube/v3/channels?part=contentDetails&id=" + id + "&key=AIzaSyAyL0tx2-Rqtw2DIYbaahvcV3b1-1Uk-I4";
            WebClient wCupload = new WebClient { Encoding = Encoding.UTF8 };
            string jsonString_id = wCupload.DownloadString(idupload);
            JObject jObj_id = (JObject)JsonConvert.DeserializeObject(jsonString_id);
            string song = jObj_id["pageInfo"]["totalResults"].ToString();
            if (song == "1") return jObj_id["items"][0]["contentDetails"]["relatedPlaylists"]["uploads"].ToString();
            return "0";
        }
        public void creat_Delete()
        {
            string sXoac = @"Delete From channel where id=@id";
            SqlCommand cmXoac = new SqlCommand(sXoac, con);
            cmXoac.Parameters.Add("@id", SqlDbType.Int, 5, "id");
            dataapter.DeleteCommand = cmXoac;
        }
        public void creat_edit()
        {
            string sSuac = @"Update channel set id=@id,Name=@Name,idchannel=@idchannel,ga=@ga,mail=@mail,note=@note where id=@id";
            SqlCommand cmSuac = new SqlCommand(sSuac, con);
            cmSuac.Parameters.Add("@id", SqlDbType.Int, 3, "id");
            cmSuac.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            cmSuac.Parameters.Add("@idchannel", SqlDbType.NVarChar, 50, "idchannel");
            cmSuac.Parameters.Add("@ga", SqlDbType.NText, 1000, "ga");
            cmSuac.Parameters.Add("@mail", SqlDbType.NText, 1000, "mail");
            cmSuac.Parameters.Add("@note", SqlDbType.NText, 1000, "note");


            dataapter.UpdateCommand = cmSuac;
        }
        public void creat_insert()
        {
            string sThemc = @"Insert into channel(id,Name,idchannel,mail,ga,note) values(@id,@Name,@idchannel,@mail,@ga,@note)";
            SqlCommand cmThemc = new SqlCommand(sThemc, con);
            cmThemc.Parameters.Add("@id", SqlDbType.Int, 3, "id");
            cmThemc.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            cmThemc.Parameters.Add("@idchannel", SqlDbType.NVarChar, 50, "idchannel");
            cmThemc.Parameters.Add("@ga", SqlDbType.NText, 1000, "ga");
            cmThemc.Parameters.Add("@mail", SqlDbType.NText, 1000, "mail");
            cmThemc.Parameters.Add("@note", SqlDbType.NText, 1000, "note");
            dataapter.InsertCommand = cmThemc;
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                dataapter.Update(dataset, "data_trial");
                MessageBox.Show("Save complete!", "Massage",MessageBoxButtons.OK,MessageBoxIcon.Information);
                data_mail.ReadOnly = true;
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a = MessageBox.Show("Are you sure????","Warning???",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (a != DialogResult.Yes) return;
                int i = data_mail.CurrentRow.Index;
                DataGridViewRow dr = data_mail.Rows[i];
               data_mail.Rows.Remove(dr);
              
               
            }
            catch (Exception ex)
            {
                
               
            }
        }

        private void data_mail_Click(object sender, EventArgs e)
        {
            int vtri=data_mail.CurrentRow.Index;
            DataGridViewRow selectd=data_mail.Rows[vtri];
            txtidchannel.Text = selectd.Cells["idchannel"].Value.ToString();
            
        }

        private void ManagerYtb_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        int nen = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            if(nen==0)
            {
                nen = 1;
                btnbat.Text = "Tắt nền";
                this.BackgroundImage = global::Manager_v3.Properties.Resources.nen2;
            }
            else
            {
                btnbat.Text = "Bật nền";
                nen = 0;
                this.BackgroundImage = null;

            }
            

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int c = layso();
            c++;
            Addnew a = new Addnew(c,1);
            a.ShowDialog();
            if(!string.IsNullOrEmpty(id))
            {
               
                DataRow r = dataset.Tables["data_trial"].NewRow();
                r["id"] = id;
                r["Name"] = name;
                r["idchannel"] = idchannel;
                r["mail"] = mail;
                r["ga"] = ga;
                r["note"] = note;
                dataset.Tables["data_trial"].Rows.Add(r);
                MessageBox.Show("ok");
            }
            // khởi tạo về ban đầu
            id = string.Empty;
            name = string.Empty;
            idchannel = string.Empty;
            ga = string.Empty;
            note = string.Empty;
            mail = string.Empty;
         
        }

        private void data_mail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtidchannel_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (btnOn.Text == "Off") return;
               // string chon = listchannel.SelectedItems[0].Text;
              //  ListViewItem chona = listchannel.SelectedItems[0];
                day = new List<string>();
                int dem = 0;
               // MessageBox.Show(chona.SubItems[0].Text);
                string chon = txtidchannel.Text;
                //xu li id
                //--> lấy id upload 

                string idupload = "https://www.googleapis.com/youtube/v3/channels?part=contentDetails,snippet,statistics&id=" + chon + "&key=AIzaSyAyL0tx2-Rqtw2DIYbaahvcV3b1-1Uk-I4";
                WebClient wCupload = new WebClient { Encoding = Encoding.UTF8 };
                string jsonString_id = wCupload.DownloadString(idupload);
                JObject jObj_id = (JObject)JsonConvert.DeserializeObject(jsonString_id);
                string id_upload = jObj_id["items"][0]["contentDetails"]["relatedPlaylists"]["uploads"].ToString();
                picchannel.ImageLocation = jObj_id["items"][0]["snippet"]["thumbnails"]["default"]["url"].ToString();
                txtnamechannel.Text = jObj_id["items"][0]["snippet"]["localized"]["title"].ToString();
                txtsubchannel.Text = jObj_id["items"][0]["statistics"]["subscriberCount"].ToString();
                //chuyển số sub thành số chấm
               txtsubchannel.Text = string.Format("{0:0,0}", float.Parse(txtsubchannel.Text)); 
                txtvideochannel.Text = jObj_id["items"][0]["statistics"]["videoCount"].ToString();
                //chuyển số video thành số chấm
               txtvideochannel.Text = string.Format("{0:0,0}", float.Parse(txtvideochannel.Text)); 
               //--> lấy id video theo id upload
               // 
                string id_video="https://www.googleapis.com/youtube/v3/playlistItems?part=contentDetails&maxResults=50&playlistId="+id_upload+"&key=AIzaSyAyL0tx2-Rqtw2DIYbaahvcV3b1-1Uk-I4";
                WebClient wC_id = new WebClient { Encoding = Encoding.UTF8 };
                string jsonString_idvideo = wC_id.DownloadString(id_video);
                JObject jObj_id_video = (JObject)JsonConvert.DeserializeObject(jsonString_idvideo);

                int sovideo = int.Parse(jObj_id_video["pageInfo"]["totalResults"].ToString());
                if(string.IsNullOrEmpty(this.txtadvance.Text))
                txtadvance.Text = sovideo.ToString();
                //--> tiến hành lấy id video
                if (sovideo > 50) sovideo = 50;
                if (btnadvance.Text == "On") sovideo= int.Parse(this.txtadvance.Text);
                for(int soid=0;soid<sovideo;soid++)
                {
                    if (!string.IsNullOrEmpty(jObj_id_video["items"][soid]["contentDetails"]["videoId"].ToString()))
                    {
                        day.Add(jObj_id_video["items"][soid]["contentDetails"]["videoId"].ToString());
                        dem++;
                    }
                    
                }
                //đo thời gian
               
                int xso;
                xso = 0;

               
                for (int j = 0; j < dem;j++ )
                {

                    string input = "https://www.googleapis.com/youtube/v3/videos?id=" + day[j].ToString() + "&key=AIzaSyAyL0tx2-Rqtw2DIYbaahvcV3b1-1Uk-I4&part=snippet,contentDetails,statistics,status";
                    WebClient wC = new WebClient { Encoding = Encoding.UTF8 };
                    string jsonString = wC.DownloadString(input);
                    JObject jObj = (JObject)JsonConvert.DeserializeObject(jsonString);
                  
                    link = jObj["items"][0]["id"].ToString();
                  
                    vchannel = jObj["items"][0]["snippet"]["channelTitle"].ToString();
                    
                    vtitile = jObj["items"][0]["snippet"]["title"].ToString();
                    description = jObj["items"][0]["snippet"]["description"].ToString();
                    view = jObj["items"][0]["statistics"]["viewCount"].ToString();
                    float soview = float.Parse(view);
                   // soview.ToString("N");
                    
                   view =string.Format("{0:0,0}",soview); 
                    like = jObj["items"][0]["statistics"]["likeCount"].ToString();
                    dislike = jObj["items"][0]["statistics"]["dislikeCount"].ToString();
                    comment=jObj["items"][0]["statistics"]["commentCount"].ToString();
                    vday = jObj["items"][0]["snippet"]["publishedAt"].ToString();
                    money = jObj["items"][0]["contentDetails"]["licensedContent"].ToString();
                    times = jObj["items"][0]["contentDetails"]["duration"].ToString();
                  times = times.Replace("PT","");
                   times = times.Replace("H", ":");
                   times = times.Replace("M", ":");
                  times = times.Replace("S", "");
                    //how to get data from json object ? check this link json.org for more details 
                    ListViewItem item = new ListViewItem();
                    
                    xso++;

                    item.Text = xso.ToString();
                    listvideo.Items.Add(item);
                    item.SubItems.Add(vchannel);
                    item.SubItems.Add(vtitile);
                    item.SubItems.Add(description);
                    item.SubItems.Add(view);
                    item.SubItems.Add(like);
                    item.SubItems.Add(dislike);
                    item.SubItems.Add(money);
                   
                    item.SubItems.Add(link);
                    item.SubItems.Add(comment);
                    item.SubItems.Add(vday);
                    item.SubItems.Add(times);
                   // MessageBox.Show(channel);
                }
            }
            catch(Exception c)
            {
              
            }

            }
        int k = 0;
        private void btnOn_Click(object sender, EventArgs e)
        {
            if(k==0)
            {
                k = 1;
                btnOn.Text = "Off";
            }
            else
            {
                k = 0;
                btnOn.Text = "On";
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {

                int i = data_mail.CurrentRow.Index;
                DataGridViewRow a = data_mail.Rows[i];
                string sid;
                string sname;
                string sidchannel;
                string smail;
                string sga;
                string snote;

                // gán giá ntri5
                sid = a.Cells["id"].Value.ToString();

                sname = a.Cells["Name"].Value.ToString();
                sidchannel = a.Cells["idchannel"].Value.ToString();
                smail = a.Cells["mail"].Value.ToString();
                sga = a.Cells["ga"].Value.ToString();
                snote = a.Cells["note"].Value.ToString();

                Addnew show = new Addnew(sid, sname, sidchannel, smail, sga, snote, 2);

                show.ShowDialog();
            }
            catch
            {

            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            data_mail.ReadOnly = false;
        }

        private void listvideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbmoney.ResetText();
                ListViewItem item = listvideo.SelectedItems[0];
                txttitile.Text=item.SubItems[2].Text;
                txtdescription.Text=item.SubItems[3].Text;
                txtlink.Text="https://www.youtube.com/watch?v="+item.SubItems[8].Text;
                txtview.Text=item.SubItems[4].Text;
                txtstt.Text = item.Text;
                if (item.SubItems[7].Text == "True") cbmoney.SelectedText = "Có";
                else
                    cbmoney.SelectedText = "Không";
                txtcomment.Text=item.SubItems[9].Text;
                picthumbnail.ImageLocation = "https://i.ytimg.com/vi/" + item.SubItems[8].Text + "/mqdefault.jpg";
                txttimes.Text = item.SubItems[11].Text;
            }
            catch(Exception ex)
            {
                
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listvideo.Items.Clear();
        }

        private void cptitile_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txttitile.Text);
        }

        private void cpdes_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtdescription.Text);
        }

        private void cplink_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtlink.Text);
        }
        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
        }
        int badvance = 0;
        private void btnadvance_Click(object sender, EventArgs e)
        {
            if(badvance==0)
            {
                btnadvance.Text = "On";
                badvance = 1;
                txtadvance.ReadOnly = false;
                txtidchannel.ResetText();
            }
            else
            {
                btnadvance.Text = "Off";
                badvance = 0;
                txtadvance.ReadOnly = true;
                txtadvance.ResetText();
              
            }
        }

        private void btnget_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://www.youtube.com/channel/"+txtidchannel.Text);
        }
        int offanh = 0;
        private void btnOffanh_Click(object sender, EventArgs e)
        {
            
        }

        private void picthumbnail_Click(object sender, EventArgs e)
        {
            if (offanh == 1)
            {
                offanh = 0;
                btnOffanh.Text = "Off";
                picchannel.Visible = false;
            }
            else
            {
                offanh = 1;
                btnOffanh.Text = "On";
                picchannel.Visible = true;
            }
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            test_channel();
        }
        }
    #region
    // tạo bảng dữ liệu load kênh chết
    public class kenhtest
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        string Name;

        public string Name1
        {
            get { return Name; }
            set { Name = value; }
        }
        string idchannel;

        public string Idchannel
        {
            get { return idchannel; }
            set { idchannel = value; }
        }
        string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        string ga;

        public string Ga
        {
            get { return ga; }
            set { ga = value; }
        }
        string note;

        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        public kenhtest(string id, string Name, string idchannel, string mail, string ga, string note)
        {
            this.id = id;
            this.Name = Name;
            this.idchannel = idchannel;
            this.mail = mail;
            this.ga = ga;
            this.note = note;
        }
        public kenhtest(kenhtest a)
        {
            id = a.id;
            Name = a.Name;
            idchannel = a.idchannel;
            mail = a.mail;
            ga = a.ga;
            note = a.note;
        }
    }
    #endregion
    }

