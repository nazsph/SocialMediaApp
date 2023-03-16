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
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using PicturesWithData.SocialMediaDataSet1TableAdapters;

namespace PicturesWithData
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection conn=new SqlConnection(MethodClass.connection);

        
        public void LogIn()
        {

            conn.Open();
            String query = "Select * from AccountsTable where Username=@username AND Password=@password";
            SqlDataAdapter adp = new SqlDataAdapter(query, conn);

            string uName;

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM AccountsTable WHERE  Username=@username AND Password=@password", conn))
            {
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                
                
                
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    txtUsername.Text = Properties.Settings.Default.uName;



                    this.Hide();
                    MainPage mainPage=new MainPage();
                    mainPage.ShowDialog();

                    

                }
                else
                {
                    MessageBox.Show("Check Your Informations");

                }
            }
            conn.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SigninForm sign=new SigninForm();
            this.Hide();
            sign.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.uName = txtUsername.Text;
            Properties.Settings.Default.Save();

            LogIn();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Properties.Settings.Default.uName = txtUsername.Text;
                Properties.Settings.Default.Save();

                LogIn();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            panelUp.BackColor = Color.Transparent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int i = 2;
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            
            if (i%2==0)
            {
                this.WindowState = FormWindowState.Maximized;
                
            }
            if (i%2==1)
            {
                this.WindowState = FormWindowState.Normal;
                
            }
            i++;

        }
    }
}
