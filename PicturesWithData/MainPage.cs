using System;
using System.Collections;
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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public SqlConnection conn = new SqlConnection(MethodClass.connection);
        int i = 0;
        int j = 2;
        public Label lbl;
        public Stack<UserControl> stack = new Stack<UserControl>();
        public Stack<UserControl> stack2 = new Stack<UserControl>();
        bool bp = true;
        bool fp = true;


        private void MainPage_Load(object sender, EventArgs e)
        {
            foreach (Panel pnl in this.Controls)
            {
                pnl.BackColor = Color.Transparent;
            }

            MethodClass showControl = new MethodClass();
            uc_MainPage uc_Main = new uc_MainPage();
            MethodClass.ShowUserControl(uc_Main, panelMain);
            stack.Push(uc_Main);
           // SearchBar();

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            btnBackPage.Visible = true;
            MethodClass showControl = new MethodClass();
            uc_profile uc_Profile=new uc_profile();
            MethodClass.ShowUserControl(uc_Profile,panelMain);
            stack.Push(uc_Profile);
            bp = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm=new LoginForm();
            this.Close();
            this.Hide();
            loginForm.ShowDialog();
            
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String search = txtSearch.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from AccountsTable where Username like  '" + search + "%'", conn);
           // SqlCommand cmd2 = new SqlCommand("Select Username from AccountsTable", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
           // SqlDataReader dr2= cmd2.ExecuteReader();
            while (dr.Read())
            {
               // while (dr2.Read()) {
                    if (dr.HasRows)
                    {

                       // if (dr["Username"].ToString() == dr2["Username"].ToString())
                   // {
                        
                            lbl = new Label();
                            lbl.Text = dr["Username"].ToString();
                            lbl.AutoSize = true;
                            lbl.Name = ("lbl" + i).ToString();
                            lbl.BorderStyle = BorderStyle.Fixed3D;
                            lbl.Visible = true;
                            lbl.BringToFront();
                            lbl.Click += new EventHandler(this.lbl_click);
                            flowPanelSearchBar.Controls.Add(lbl);
                   

                        }
                        if (txtSearch.Text == "")
                        {
                            flowPanelSearchBar.Controls.Clear();
                        }
                   // }
           // }
            }

            //dr2.Close();
            dr.Close();
            conn.Close();


        }

        public void lbl_click(object sender, EventArgs e)
        {
            Label lbl=sender as Label;
            Properties.Settings.Default.stalkName = lbl.Text;
            Properties.Settings.Default.Save();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from AccountsTable", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[1].ToString() == Properties.Settings.Default.stalkName)
                {
                    if (dr["PrivateSetting"].ToString() == "True")
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
                                    MethodClass.ShowUserControl(otherAccounts, panelMain);
                                    //stack.Push(otherAccounts);
                                }
                                else
                                {
                                    MethodClass showControl = new MethodClass();
                                    uc_PrivateAccount privateAccount = new uc_PrivateAccount();
                                    MethodClass.ShowUserControl(privateAccount, panelMain);
                                    //stack.Push(privateAccount);
                                }
                            }
                        }
                        else
                        {
                            MethodClass showControl = new MethodClass();
                            uc_PrivateAccount privateAccount = new uc_PrivateAccount();
                            MethodClass.ShowUserControl(privateAccount, panelMain);
                           // stack.Push(privateAccount);

                        }

                    }
                    else
                    {
                        MethodClass showControl = new MethodClass();
                        uc_otherAccounts otherAccounts = new uc_otherAccounts();
                        MethodClass.ShowUserControl(otherAccounts, panelMain);
                       // stack.Push(otherAccounts);

                    }

                }
            }

            conn.Close();
            
        }       

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            btnBackPage.Visible = true;
            uc_notifications notifications=new uc_notifications();
            MethodClass showControl = new MethodClass();
            MethodClass.ShowUserControl(notifications, panelMain);
            stack.Push(notifications);
            bp = true;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnBackPage.Visible = true;
            MethodClass showControl = new MethodClass();
            uc_Settings settings =new uc_Settings();
            MethodClass.ShowUserControl(settings, panelMain);
            stack.Push(settings);
            bp = true;

        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            btnBackPage.Visible = true;
            MethodClass showControl=new MethodClass();
            uc_MainPage uc_Main=new uc_MainPage();
            MethodClass.ShowUserControl(uc_Main, panelMain);
            stack.Push(uc_Main);
            bp = true;


        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
                
        private void btnMaximize_Click(object sender, EventArgs e)
        {

            if (j % 2 == 0)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            if (j % 2 == 1)
            {
                this.WindowState = FormWindowState.Normal;

            }
            j++;

        }

        public void SearchBar()
        {
            String search = txtSearch.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Username from AccountsTable", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            SqlDataReader dr = cmd.ExecuteReader();

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            
            
            

            while (dr.Read())
            {
                collection.Add(dr["Username"].ToString());
                
            }
            txtSearch.AutoCompleteCustomSource = collection;
            


            dr.Close();
            conn.Close();
        }        

        private void btnBackPage_Click(object sender, EventArgs e)
        {

            if (bp == true)
            {
                stack.Pop();
                bp = false;
            }
            if (stack.Count != 0)
            {
                stack2.Push(stack.Peek());

                MethodClass.ShowUserControl(stack.Pop(), panelMain);
                


            }
            if (stack.Count==0)
            {
                btnBackPage.Visible = false;
            }
            btnNextPage.Visible = true;
            fp = true;

        }
                      
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if(fp==true)
            {
                stack2.Pop();
                fp = false;
            }
            if (stack2.Count != 0)
            {

                stack.Push(stack2.Peek());
                MethodClass.ShowUserControl(stack2.Pop(), panelMain);



            }
            if (stack2.Count == 0)
            {
                btnNextPage.Visible= false;
            }
        }

    }
}
