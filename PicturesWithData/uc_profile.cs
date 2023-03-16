using PicturesWithData.SocialMediaDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Microsoft.VisualBasic;

namespace PicturesWithData
{
    public partial class uc_profile : UserControl
    {
        public uc_profile()
        {
            InitializeComponent();
        }

        FileDialog file;
        PictureBox box;
        int count = 0;
        int i = 3;
        int j = 0;
        int x = 230;
        int y = 180;
        int xi = 170;
        int yi = 240;
        String picturepath;
        bool Slidebar;


        public SqlConnection conn = new SqlConnection(MethodClass.connection);
        public Button btnClose;
        public Button btnClose2;
        public Button btn;
        public Button btn2;

        public void WhoLogedIn()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from AccountsTable", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[1].ToString() == Properties.Settings.Default.uName)
                {
                    lblUsername.Text = dr[1].ToString();                   
                    pbProfile.ImageLocation = dr[11].ToString();
                    pbProfile.BackgroundImageLayout = ImageLayout.Stretch;
                    pbProfile.SizeMode = PictureBoxSizeMode.StretchImage;

                    lblBio.Text = dr["Bio"].ToString();
                    

                }
            }

            conn.Close();
            
        }


        private void uc_profile_Load(object sender, EventArgs e)
        {
            WhoLogedIn();           
            ShowPics();
            LoadInfo();

            

        }

        public void AddPics()
        {
            file = new OpenFileDialog();
            file.Filter = "Jpeg Dosyaları (*.jpeg)|*.jpg|Bitmap Dosyaları (*.bmp)|*.bmp|Gif Dosyaları (*.gif)|*.gif|Tüm dosyalar (*)|*";

            DateTime myDateTime = DateTime.Now;
           // DateTime myDateTime = DateTime.UtcNow;
            if (file.ShowDialog() == DialogResult.OK)
            {
                box = new PictureBox();                
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into PostTable(Username,FilePath,postDate) values('" + Properties.Settings.Default.uName.ToString() + "','" + file.FileName + "', '"+myDateTime.ToString("yyyy/MM/dd HH:mm:ss")+"' ) ", conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                SqlDataReader dr = cmd.ExecuteReader();
                conn.Close();                
                flowPanelPosts.Controls.Clear();
                ShowPics();
            }
        }

        public void ShowPics()
        {           
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from PostTable where Username= @username ", conn);
            cmd.Parameters.AddWithValue("@username", Properties.Settings.Default.uName.ToString());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                picturepath = dr["FilePath"].ToString();
                box = new PictureBox();
                box.ImageLocation = picturepath;
                box.Image=Image.FromFile(picturepath);
                box.Name = ("pictureBox" + i).ToString();
                box.Visible = true;
                box.BringToFront();
                box.Size = new System.Drawing.Size(130,130) ; //220,220 3lü çıkarıyor ama orantısız büyük
                box.BorderStyle = BorderStyle.FixedSingle;
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                i++;
                this.Controls.Add(box);
                flowPanelPosts.Controls.Add(box);
                box.Click += new EventHandler(this.box_click);

            }
            dr.Close();
            conn.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            AddPics();
            LoadInfo();
        }

        public void LoadInfo()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Count(*) WhoFollowesThem from FollowersTable where Username= '" + Properties.Settings.Default.uName+"' ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                lblFollowersCount.Text = dr[0].ToString();

            }
            dr.Close();

            SqlCommand cmd2 = new SqlCommand("SELECT Count(*) WhoTheyFolowed from FollowedTable where Username= '" + Properties.Settings.Default.uName + "' ", conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                
                lblFollowedCount.Text = dr2[0].ToString();

            }
            dr2.Close();
           
            
            SqlCommand cmd3 = new SqlCommand("SELECT Count(*) FilePath from PostTable where Username= '" + Properties.Settings.Default.uName + "' ", conn);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                lblPostCount.Text = dr3[0].ToString();

            }
            dr3.Close();



            conn.Close();
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure?", "Change Profile Photo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                file = new OpenFileDialog();
                file.Filter = "Jpeg Dosyaları (*.jpeg)|*.jpg|Bitmap Dosyaları (*.bmp)|*.bmp|Gif Dosyaları (*.gif)|*.gif|Tüm dosyalar (*)|*";


                if (file.ShowDialog() == DialogResult.OK)
                {


                    String filepath = file.FileName;
                    //save file
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update AccountsTable set imgFileName=@filePath where Username= '"+Properties.Settings.Default.uName+"' ", conn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("@filePath",filepath);
                    cmd.ExecuteNonQuery();
                    conn.Close();


                    pbProfile.ImageLocation = filepath;

                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        public void box_click(object sender,EventArgs e)
        {

            //click edileni değil son eklenen picturepathi siliyor


            PictureBox box = sender as PictureBox;
            picturepath = box.ImageLocation;
            

            DialogResult dialogResult = MessageBox.Show("Are You Sure?", "Delete Profile Photo", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {                                          
                conn.Open();
                
                
                SqlCommand cmd = new SqlCommand("delete from PostTable where (Username = '"+Properties.Settings.Default.uName+"') AND (FilePath='"+picturepath+"') ", conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                conn.Close();
                flowPanelPosts.Controls.Clear();
                ShowPics();
                LoadInfo();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }

        private void panelFollowers_Click(object sender, EventArgs e)
        {
            btnClose = new Button();
            flowPanelFollowers.Visible = true;
            flowPanelFollowers.Enabled = true;
            btnClose.Name = "btn" + i;
            btnClose.Text = "X";
            btnClose.Size = new Size(30, 30);
            btnClose.Margin = new Padding(flowPanelFollowers.Width - btnClose.Width-20, 0, 0, 10);
            btnClose.BackColor = Color.Thistle;
            btnClose.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            btnClose.Click += new EventHandler(this.btnClose_click);

            panelFollowed.Enabled = false;
            panelFollowers.Enabled = false;

            flowPanelFollowers.Controls.Add(btnClose);
            FollowersTableVisible();

            i++;
        }        

        public void FollowersTableVisible()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from FollowersTable ", conn);
            SqlDataAdapter apd=new SqlDataAdapter(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                if (dr["Username"].ToString() == Properties.Settings.Default.uName)
                {

                    btn = new Button();
                    btn.Name = "button" + i;
                    btn.Text = dr["WhoFollowesThem"].ToString();
                    btn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    btn.AutoSize = true;
                    btn.Margin = new Padding(0, 0, 20, 10);
                    btn.BackColor = Color.Thistle;
                    btn.Click += new EventHandler(this.btnFollowers_click);


                    flowPanelFollowers.Controls.Add(btn);
                    i++;
                }
            }
            dr.Close();
            conn.Close();
            
        }

        public void btnClose_click(object sendder,EventArgs e)
        {
                       
            flowPanelFollowers.Enabled = false;
            flowPanelFollowers.Visible = false;
            flowPanelFollowers.Controls.Clear();
            panelFollowers.Enabled = true;
            panelFollowed.Enabled = true;
            
        }

        public void btnFollowers_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Properties.Settings.Default.stalkName = btn.Text;
            Properties.Settings.Default.Save();


            conn.Open();
            SqlCommand cmd3 = new SqlCommand("Select * from AccountsTable where Username= '" + Properties.Settings.Default.stalkName + "' ", conn);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                if (dr3["PrivateSetting"].ToString() == "True")
                {
                    SqlCommand cmd2 = new SqlCommand("Select WhoTheyFollowed from FollowedTable where Username= '" + Properties.Settings.Default.uName + "' ", conn);
                    SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    if (dr2.HasRows)
                    {
                        while (dr2.Read())
                        {
                            if (dr2["WhoTheyFollowed"].ToString() == Properties.Settings.Default.stalkName)
                            {
                                MethodClass showControl = new MethodClass();
                                uc_otherAccounts otherAccounts = new uc_otherAccounts();
                                MethodClass.ShowUserControl(otherAccounts, panelProfile);
                                //MainPage mp = new MainPage();
                                //mp.stack.Push(otherAccounts);
                                //mp.btnBackPage.Visible = true;
                            }
                            else
                            {
                                MethodClass showControl = new MethodClass();
                                uc_PrivateAccount privateAccount = new uc_PrivateAccount();
                                MethodClass.ShowUserControl(privateAccount, panelProfile);
                                //MainPage mp = new MainPage();
                                //mp.stack.Push(privateAccount);
                                //mp.btnBackPage.Visible = true;
                            }
                        }

                    }

                    else
                    {

                        MethodClass showControl = new MethodClass();
                        uc_PrivateAccount privateAccount = new uc_PrivateAccount();
                        MethodClass.ShowUserControl(privateAccount, panelProfile);
                        //MainPage mp = new MainPage();
                        //mp.stack.Push(privateAccount);
                        //mp.btnBackPage.Visible = true;
                    }
                }
                else
                {

                    MethodClass showControl = new MethodClass();
                    uc_otherAccounts otherAccounts = new uc_otherAccounts();
                    MethodClass.ShowUserControl(otherAccounts, panelProfile);
                    //MainPage mp = new MainPage();
                    //mp.stack.Push(otherAccounts);
                    //mp.btnBackPage.Visible = true;
                }
            }


            dr3.Close();
            conn.Close();


        }

        private void panelFollowed_Click(object sender, EventArgs e)
        {
            btnClose2 = new Button();
            flowPanelFollowers.Visible = true;
            flowPanelFollowers.Enabled = true;
            btnClose2.Name = "btn" + i;
            btnClose2.Text = "X";
            btnClose2.Size = new Size(30, 30);
            btnClose2.Margin = new Padding(flowPanelFollowers.Width - btnClose2.Width - 20, 0, 0, 10);
            btnClose2.BackColor = Color.Thistle;
            btnClose2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            btnClose2.Click += new EventHandler(this.btnClose2_click);


            panelFollowed.Enabled = false;
            panelFollowers.Enabled = false;
            flowPanelFollowers.Controls.Add(btnClose2);
            FollowedTableVisible();

            i++;
        }

        public void btnClose2_click(object sendder, EventArgs e)
        {

            flowPanelFollowers.Enabled = false;
            flowPanelFollowers.Visible = false;
            flowPanelFollowers.Controls.Clear();
            panelFollowed.Enabled = true;
            panelFollowers.Enabled = true;
        }

        public void FollowedTableVisible()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from FollowedTable ", conn);
            SqlDataAdapter apd = new SqlDataAdapter(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["Username"].ToString() == Properties.Settings.Default.uName)
                {

                    btn2 = new Button();
                    btn2.Name = "button" + i;
                    btn2.Text = dr["WhoTheyFollowed"].ToString();
                    btn2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    btn2.AutoSize = true;
                    btn2.Margin = new Padding(0, 0, 20, 10);
                    btn2.BackColor = Color.Thistle;
                    btn2.Click += new EventHandler(this.btnFollowed_click);


                    flowPanelFollowers.Controls.Add(btn2);
                    i++;
                }
            }
            dr.Close();
            conn.Close();

        }

        public void btnFollowed_click(object sender, EventArgs e)
        {
            Button btn2 = sender as Button;
            Properties.Settings.Default.stalkName = btn2.Text;
            Properties.Settings.Default.Save();


            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from AccountsTable where Username= '" + Properties.Settings.Default.stalkName + "' ", conn);
            cmd.ExecuteReader();
            MethodClass showControl=new MethodClass();
            uc_otherAccounts otherAccounts=new uc_otherAccounts();
            MethodClass.ShowUserControl(otherAccounts, panelProfile);
            //MainPage mp = new MainPage();
            //mp.stack.Push(otherAccounts);
            //mp.btnBackPage.Visible = true;
            conn.Close();


        }

        private void timerSlidebar_Tick(object sender, EventArgs e)
        {
            if (Slidebar)
            {
                panelSlidebar.Height -= 2;
                if(panelSlidebar.Height ==panelSlidebar.MinimumSize.Height ) {

                    Slidebar = false;
                    timerSlidebar.Stop();
                }
            }
            else
            {
                panelSlidebar.Height += 2;
                if (panelSlidebar.Height == panelSlidebar.MaximumSize.Height)
                {

                    Slidebar = true;
                    timerSlidebar.Stop();
                }
            }
        }

        private void btnSlidebar_Click(object sender, EventArgs e)
        {
            timerSlidebar.Start();
        }

        private void btnBioUpdate_Click(object sender, EventArgs e)
        {
            //user inputbox
            String newBio = Interaction.InputBox("New Bio", "Input", "", 570, 300);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update AccountsTable set Bio= '"+newBio+"' where Username= '"+Properties.Settings.Default.uName+"'   ",conn);
            cmd.ExecuteNonQuery();
            lblBio.Text = newBio;
            conn.Close();
        }
    }
       
}
