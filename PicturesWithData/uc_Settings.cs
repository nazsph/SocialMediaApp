using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturesWithData
{
    public partial class uc_Settings : UserControl
    {
        public uc_Settings()
        {
            InitializeComponent();
        }
        public bool priv;
        public SqlConnection conn = new SqlConnection(MethodClass.connection);

        private void uc_Settings_Load(object sender, EventArgs e)
        {
            LoadPrivateInfo();
            LoadInfo();

            panelSettings.BackColor = Color.Transparent;
            tabPageAccount.BackColor = Color.Transparent;
            tabPagePrivacy.BackColor = Color.Transparent;
            tabPageSecurity.BackColor = Color.Transparent;
            
            
        }

        public void LoadPrivateInfo()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select PrivateSetting from AccountsTable where Username= '"+Properties.Settings.Default.uName+"'  ", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            SqlDataReader dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["PrivateSetting"].ToString()=="true")
                {
                    rbPrivateAccount.Checked=true;
                    rbOpenAccount.Checked = false;
                }
                if (dr["PrivateSetting"].ToString() == "false")
                {
                    rbPrivateAccount.Checked = false;
                    rbOpenAccount.Checked = true;
                }
            }
            dr.Close();
            conn.Close();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if(rbOpenAccount.Checked == true)
            {
                priv = false;
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update AccountsTable set PrivateSetting= '" + priv + "' where Username= '" + Properties.Settings.Default.uName + "'  ", conn);
                cmd.Parameters.AddWithValue("@username", Properties.Settings.Default.uName);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if(rbPrivateAccount.Checked == true)
            {
                priv = true;
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update AccountsTable set PrivateSetting= '"+priv+"' where Username= '"+Properties.Settings.Default.uName+"'  ", conn);
                cmd.Parameters.AddWithValue("@username", Properties.Settings.Default.uName);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void LoadInfo()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from AccountsTable where Username= '" + Properties.Settings.Default.uName + "'  ", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                txtOldUsername.Text = dr["Username"].ToString();
                txtOldName.Text = dr["Name"].ToString();
                txtOldLName.Text = dr["Surname"].ToString() ;
            }
            dr.Close();
            conn.Close();
        }

        private void btnSaveUsername_Click(object sender, EventArgs e)
        {


            conn.Open();
            SqlCommand cmd3 = new SqlCommand("Select * from AccountsTable where Username=@newUname  ", conn);
            cmd3.Parameters.AddWithValue("@newUname", txtNewUsername.Text);
            SqlDataReader dr3 = cmd3.ExecuteReader();

            
                if (dr3.Read())
                {
                    MessageBox.Show("This Username is not available");

                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Select * from AccountsTable where Username= '" + Properties.Settings.Default.uName + "'  ", conn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        String id = dr["UserID"].ToString();

                        SqlCommand cmd2 = new SqlCommand("Update AccountsTable set Username= '" + txtNewUsername.Text + "' where UserID= '" + id + "'  ", conn);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Username Updated!");
                        Properties.Settings.Default.uName = txtNewUsername.Text;
                        Properties.Settings.Default.Save();
                        txtNewUsername.Text = "";

                    }
                    dr.Close();
                    cmd.ExecuteReader();

                }
            
 dr3.Close();

            conn.Close();
            LoadInfo();

        }

        private void btnSaveName_Click(object sender, EventArgs e)
        {
            conn.Open();                       
                SqlCommand cmd = new SqlCommand("Select * from AccountsTable where Username= '" + Properties.Settings.Default.uName + "'  ", conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String id = dr["UserID"].ToString();

                    SqlCommand cmd2 = new SqlCommand("Update AccountsTable set Name= '" + txtNewName.Text + "' where UserID= '" + id + "'  ", conn);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Name Updated!");
                    txtNewName.Text = "";

                }
                dr.Close();
                cmd.ExecuteReader();         
            conn.Close();
            LoadInfo();

        }

        private void btnSaveLastName_Click(object sender, EventArgs e)
        {
            conn.Open();
            
                SqlCommand cmd = new SqlCommand("Select * from AccountsTable where Username= '" + Properties.Settings.Default.uName + "'  ", conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String id = dr["UserID"].ToString();

                    SqlCommand cmd2 = new SqlCommand("Update AccountsTable set Surname= '" + txtNewLName.Text + "' where UserID= '" + id + "'  ", conn);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Last Name Updated!");
                    txtNewLName.Text = "";

                }
                dr.Close();
                cmd.ExecuteReader();

            


            conn.Close();
            LoadInfo();
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Password from AccountsTable where Username= '" + Properties.Settings.Default.uName + "' ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["Password"].ToString() == txtOldPassword.Text)
                {
                    if (txtNewPassword.Text == txtNewPassword2.Text)
                    {
                        SqlCommand cmd2 = new SqlCommand("Update AccountsTable set Password='" + txtNewPassword.Text + "' where Username= '" + Properties.Settings.Default.uName + "'  ", conn);
                        cmd2.ExecuteNonQuery();
                        txtOldPassword.Text = ""; txtNewPassword.Text = ""; txtNewPassword2.Text = "";
                        MessageBox.Show("Password Changed!");

                    }
                    else
                    {
                        MessageBox.Show("New Password Does Not Match!");
                    }
                }
                else
                {
                    MessageBox.Show("Old Password Is Wrong!");
                }
            }
            dr.Close();
            conn.Close();
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //SmtpClient sc = new SmtpClient();

            //sc = new SmtpClient();
            //sc.Host = "smtp.gmail.com";
            //sc.Port = 587;
            //sc.EnableSsl = true;

            //String To= "SphAppOfficial@gmail.com";
            //String CC="Başlık";
            //String Content="Test";

            //sc.Credentials = new NetworkCredential("SphAppOfficial@gmail.com", "hOtasice0211");
            //MailMessage mail=new MailMessage();
            //mail.From = new MailAddress("SphAppOfficial@gmail.com", "SphApp");
            //mail.To.Add(To);
            //mail.Subject = CC;
            //mail.Body =Content;
            //mail.IsBodyHtml= true;

            //sc.Send(mail);

            //MessageBox.Show("Sended");

            var smtpClient = new SmtpClient("your.smtp.host")
            {
                Port = 2525,
            };

            smtpClient.Send(from: "SphAppOfficial@gmail.com", recipients: "SphAppOfficial@gmail.com", subject: "bu Gelen", body: "Merhaba");
            MessageBox.Show("sended");




        }

    }
    }


