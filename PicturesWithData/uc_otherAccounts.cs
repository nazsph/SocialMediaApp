using PicturesWithData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PicturesWithData
{
    public partial class uc_otherAccounts : UserControl
    {
        public uc_otherAccounts()
        {
            InitializeComponent();
        }
        public SqlConnection conn = new SqlConnection(MethodClass.connection);

        FileDialog file;
        PictureBox box;
        int i = 3;        
        String picturepath;
        int count = 0;
        bool sended;
        bool Slidebar;

        public Button btn=new Button();
        public bool answer;
        public Button btnClose;
        public Button btnClose2;
        public Button btn1;
        public Button btn2;

        private void uc_otherAccounts_Load(object sender, EventArgs e)
        {
           WhoClicked();
           ShowPics();
           LoadInfo();
           CheckRequest();
           



        }
        public void WhoClicked()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from AccountsTable", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[1].ToString() == Properties.Settings.Default.stalkName)
                {
                    lblUsername.Text = dr[1].ToString();
                    //lblFollowersCount.Text = dr[6].ToString();
                    //lblFollowedCount.Text = dr[7].ToString();
                    //lblPostCount.Text = dr[8].ToString();
                    pbProfile.ImageLocation = dr[11].ToString();
                    pbProfile.BackgroundImageLayout = ImageLayout.Stretch;
                    pbProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                    lblBio.Text = dr[9].ToString();

                }
            }

            conn.Close();

        }
        public void ShowPics()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from PostTable where Username= @username ", conn);
            cmd.Parameters.AddWithValue("@username", Properties.Settings.Default.stalkName.ToString());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                picturepath = dr["FilePath"].ToString();
                box = new PictureBox();
                box.ImageLocation = picturepath;
                box.Image = Image.FromFile(picturepath);
                box.Name = ("pictureBox" + i).ToString();
                box.Visible = true;
                box.BringToFront();
                box.Size = new System.Drawing.Size(130, 130); //220,220 3lü çıkarıyor ama orantısız büyük
                box.BorderStyle = BorderStyle.FixedSingle;
                box.SizeMode = PictureBoxSizeMode.StretchImage;

                this.Controls.Add(box);
                flowPanelPosts.Controls.Add(box);
                

            }
            dr.Close();
            conn.Close();
        }
        private void btnFollowRequest_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into NotificationsTable(MessageSender,MessageReciever) values ('"+Properties.Settings.Default.uName+"','"+Properties.Settings.Default.stalkName+"')", conn);
            SqlDataAdapter adp=new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();          
            conn.Close();
            CheckRequest();
        }
        public void LoadInfo()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Count(*) WhoFollowesThem from FollowersTable where Username= '" + Properties.Settings.Default.stalkName + "' ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                lblFollowersCount.Text = dr[0].ToString();

            }
            dr.Close();

            SqlCommand cmd2 = new SqlCommand("SELECT Count(*) WhoTheyFolowed from FollowedTable where Username= '" + Properties.Settings.Default.stalkName + "' ", conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {

                lblFollowedCount.Text = dr2[0].ToString();

            }
            dr2.Close();


            SqlCommand cmd3 = new SqlCommand("SELECT Count(*) FilePath from PostTable where Username= '" + Properties.Settings.Default.stalkName + "' ", conn);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                lblPostCount.Text = dr3[0].ToString();

            }
            dr3.Close();

            SqlCommand cmd4 = new SqlCommand("SELECT Bio from AccountsTable where Username= '" + Properties.Settings.Default.stalkName + "' ", conn);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                lblBio.Text = dr4[0].ToString();

            }
            dr4.Close();


            SqlCommand cmd5 = new SqlCommand("select * from FollowersTable where Username= ('" + Properties.Settings.Default.stalkName + "') and WhoFollowesThem=('" + Properties.Settings.Default.uName + "')", conn);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                if (dr5.HasRows)
                {
                    btnFollowRequest.Text = "Following";
                    btnFollowRequest.Enabled = false;
                    btnUnfollow.Visible = true;
                   // btnFollowRequest.BackColor = Color.MistyRose;

                }
                else
                {
                }
            }
            dr5.Close();


            conn.Close();
            
        }
        private void btnUnfollow_Click(object sender, EventArgs e)
        {
            if (btnUnfollow.Visible == true)
            {
                btn.Enabled = true;

                
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Are You Sure?", "Unfollow", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from FollowersTable where Username=('" + Properties.Settings.Default.stalkName + "') and WhoFollowesThem= ('" + Properties.Settings.Default.uName + "') ", conn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        SqlCommand cmd2 = new SqlCommand("delete from FollowersTable where Username=('" + Properties.Settings.Default.stalkName + "') and WhoFollowesThem= ('" + Properties.Settings.Default.uName + "') ", conn);
                        SqlCommand cmd3 = new SqlCommand("delete from FollowedTable where Username=('" + Properties.Settings.Default.uName + "') and WhoTheyFollowed= ('" + Properties.Settings.Default.stalkName + "') ", conn);
                        SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
                        SqlDataAdapter adp3 = new SqlDataAdapter(cmd3);
                        cmd3.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        
                    }
                    dr.Close();
                    conn.Close();
                    LoadInfo();
                    
                }
                else
                {
                }

            }
        }
        public void CheckRequest()
        {
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("select * from NotificationsTable where MessageSender= ('" + Properties.Settings.Default.uName + "') and MessageReciever=('" + Properties.Settings.Default.stalkName + "')", conn);
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                if (dr["MessageReciever"].ToString() == Properties.Settings.Default.stalkName)
                {
                    btnFollowRequest.Enabled = false;
                    btnFollowRequest.Text = "RequestSended";
                    btnFollowRequest.BackColor = Color.MistyRose;
                }
            }
            dr.Close();
            
            conn.Close();
        }
        private void panelFollowers_Click(object sender, EventArgs e)
        {
            
            btnClose = new Button();
            flowPanelFollowers.Visible = true;
            flowPanelFollowers.Enabled = true;
            btnClose.Name = "btn" + i;
            btnClose.Text = "X";
            btnClose.Size = new Size(30, 30);
            btnClose.Margin = new Padding(flowPanelFollowers.Width - btnClose.Width - 20, 0, 0, 10);
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
            SqlDataAdapter apd = new SqlDataAdapter(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["Username"].ToString() == Properties.Settings.Default.stalkName)
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
        public void btnClose_click(object sendder, EventArgs e)
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
            if (Properties.Settings.Default.stalkName == Properties.Settings.Default.uName)
            {
                uc_profile profile = new uc_profile();
                MethodClass.ShowUserControl(profile, panelOthers);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from AccountsTable where Username= '" + Properties.Settings.Default.stalkName + "' ", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["PrivateSetting"].ToString() == "True")
                    {
                        //biz onun takip ediyo muyuz

                        SqlCommand cmd2 = new SqlCommand("Select * from FollowedTable where Username= '" + Properties.Settings.Default.stalkName + "' and WhoTheyFollowed= '" + Properties.Settings.Default.uName + "'  ", conn);
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        if (dr2.HasRows)
                        {
                            uc_otherAccounts otherAccounts = new uc_otherAccounts();
                            MethodClass.ShowUserControl(otherAccounts, panelOthers);
                            //MainPage mp=new MainPage();
                            //mp.stack.Push(otherAccounts);
                        }
                        else
                        {
                            uc_PrivateAccount privateAccount = new uc_PrivateAccount();
                            MethodClass.ShowUserControl(privateAccount, panelOthers);
                            //MainPage mp = new MainPage();
                            //mp.stack.Push(privateAccount);
                        }
                    }
                    else
                    {
                        uc_otherAccounts otherAccounts = new uc_otherAccounts();
                        uc_PrivateAccount privateAccount = new uc_PrivateAccount();
                        MethodClass.ShowUserControl(otherAccounts, panelOthers);
                        //MainPage mp = new MainPage();
                        //mp.stack.Push(otherAccounts);
                    }
                }


                conn.Close();
            }

        }
        private void PanelFollowed_Click(object sender, EventArgs e)
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
                if (dr["Username"].ToString() == Properties.Settings.Default.stalkName)
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
            Button btn = sender as Button;
            Properties.Settings.Default.stalkName = btn.Text;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.stalkName == Properties.Settings.Default.uName)
            {
                uc_profile profile = new uc_profile();
                MethodClass.ShowUserControl(profile, panelOthers);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from AccountsTable where Username= '" + Properties.Settings.Default.stalkName + "' ", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["PrivateSetting"].ToString() == "True")
                    {
                        //biz onun takip ediyo muyuz

                        SqlCommand cmd2 = new SqlCommand("Select * from FollowedTable where Username= '" + Properties.Settings.Default.stalkName + "' and WhoTheyFollowed= '" + Properties.Settings.Default.uName + "'  ", conn);
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        if (dr2.HasRows)
                        {
                            uc_otherAccounts otherAccounts = new uc_otherAccounts();
                            MethodClass.ShowUserControl(otherAccounts, panelOthers);
                            //MainPage mp = new MainPage();
                            //mp.stack.Push(otherAccounts);
                        }
                        else
                        {
                            uc_PrivateAccount privateAccount = new uc_PrivateAccount();
                            MethodClass.ShowUserControl(privateAccount, panelOthers);
                            //MainPage mp = new MainPage();
                            //mp.stack.Push(privateAccount);
                        }
                    }
                    else
                    {
                        uc_otherAccounts otherAccounts = new uc_otherAccounts();
                        uc_PrivateAccount privateAccount = new uc_PrivateAccount();
                        MethodClass.ShowUserControl(otherAccounts, panelOthers);
                        //MainPage mp = new MainPage();
                        //mp.stack.Push(otherAccounts);
                    }
                }


                conn.Close();
            }


        }

        

        
        private void timerSlidebar_Tick(object sender, EventArgs e)
        {
            if (Slidebar)
            {
                panelSlidebar.Height -= 2;
                if (panelSlidebar.Height == panelSlidebar.MinimumSize.Height)
                {

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

        private void btnUnfollower_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from FollowedTable where WhoTheyFollowed='" + Properties.Settings.Default.uName + "' ", conn);
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["Username"].ToString() == Properties.Settings.Default.stalkName)
                {
                    SqlCommand cmd2 = new SqlCommand("Delete from FollowedTable where WhoTheyFollowed= ('" + Properties.Settings.Default.uName + "') and Username= ('"+Properties.Settings.Default.stalkName+"')  ",conn);
                    SqlCommand cmd3 = new SqlCommand("Delete from FollowersTable where WhoFollowesThem= ('" + Properties.Settings.Default.stalkName + "') and Username= ('"+Properties.Settings.Default.uName+"')  ",conn);
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("You Made Them Unfollow You!");
                }
            }
            conn.Close();
            LoadInfo();

        }
    }
}