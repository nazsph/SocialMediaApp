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

namespace PicturesWithData
{
    public partial class uc_PrivateAccount : UserControl
    {
        public uc_PrivateAccount()
        {
            InitializeComponent();
        }
        public SqlConnection conn = new SqlConnection(MethodClass.connection);

        public bool answer;
        private void uc_PrivateAccount_Load(object sender, EventArgs e)
        {
            WhoClicked();
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
        private void btnFollowRequest_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into NotificationsTable(MessageSender,MessageReciever) values ('" + Properties.Settings.Default.uName + "','" + Properties.Settings.Default.stalkName + "')", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
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
            if (Properties.Settings.Default.reqAccepted == true)
            {
                btnUnfollow.Visible = true;

                conn.Open();
                SqlCommand cmd = new SqlCommand("Select WhoTheyFollowed from FollowedTable where Username= '" + Properties.Settings.Default.uName + "'", conn);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows)
                    {
                        btnUnfollow.Visible = true;
                        btnFollowRequest.Text = "Following";

                        DialogResult dialogResult = MessageBox.Show("Are You Sure?", "Unfollow", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            conn.Open();
                            SqlCommand cmd2 = new SqlCommand("delete from FollowedTable where Username= ('" + Properties.Settings.Default.stalkName + "') and  WhoTheyFollowed = ('" + Properties.Settings.Default.uName + "') ", conn);
                            SqlDataAdapter adp = new SqlDataAdapter(cmd2);
                            cmd2.ExecuteNonQuery();
                            conn.Close();
                            LoadInfo();

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                        }
                    }
                }
                dr.Close();
                conn.Close();

            }
            else
            {
                btnUnfollow.Visible = false;
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
    }
}
