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
    public partial class SigninForm : Form
    {
        public SigninForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(MethodClass.connection);

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtName.Text == "" || txtLastName.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtPwAgain.Text == "" )
            {
                MessageBox.Show("Fill the blanks");

            }
            else if (txtPassword.Text != txtPwAgain.Text)
            {
                MessageBox.Show("Check Your Password Again!");
            }


            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into AccountsTable(Email,Name,Surname,Username,Password) values ('" + txtEmail.Text + "','" + txtName.Text + "','" + txtLastName.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account succesfully created");
                conn.Close();
                txtEmail.Text = ""; txtName.Text = ""; txtLastName.Text = ""; txtUsername.Text = ""; txtPassword.Text = ""; txtPwAgain.Text = "";

                MainPage mainPage=new MainPage();
                this.Hide();

                mainPage.ShowDialog();

            }
        }


        public void signin()
        {
            conn.Open();


            if (txtEmail.Text == "" || txtName.Text == "" || txtLastName.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtPwAgain.Text == "")
            {
                MessageBox.Show("Fill the blanks");

            }

            else if (txtPassword.Text != txtPwAgain.Text)
            {
                MessageBox.Show("Check Your Password Again!");
            }


            else
            {
                 SqlCommand com = new SqlCommand("insert into AccountsTable(Email,Name,Surname,Username,Password) values ('" + txtEmail.Text + "','" + txtName.Text + "','" + txtLastName.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "')", conn);
                 com.ExecuteNonQuery();
                 MessageBox.Show("Account succesfully created");
                 txtEmail.Text = ""; txtName.Text = ""; txtLastName.Text = ""; txtUsername.Text = ""; txtPassword.Text = ""; txtPwAgain.Text = "";
                 MainPage mainPage = new MainPage();
                 this.Hide();
                 mainPage.ShowDialog();
            }


            conn.Close();
                

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login=new LoginForm(); 
            this.Hide();
            login.ShowDialog();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPwAgain.Text)
            {
                errorProvider1.SetError(txtPwAgain, "Check your passwords");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtPwAgain_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPwAgain.Text)
            {
                errorProvider1.SetError(txtPwAgain, "Check your passwords");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void SigninForm_Load(object sender, EventArgs e)
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

            if (i % 2 == 0)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            if (i % 2 == 1)
            {
                this.WindowState = FormWindowState.Normal;

            }
            i++;

        }
    }
}


/*her sign in denince id veren yeni tablo oluşturması lazım 
 * idye göre de 1 dotoğraflar için ayrı tablo
 * 1 takip edenler için
 * 1 takip edilenler için ayrı tablo
 * 
 * yan tarafa sonra koyacak yer aramamak için
 * panel lazım
 * 
 * email gönderme gibi dm gönderme kısmı ennnn son belki
 * 
 * 
 * */