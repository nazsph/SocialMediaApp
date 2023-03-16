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
    public partial class uc_notifications : UserControl
    {
        public uc_notifications()
        {
            InitializeComponent();
        }

        public SqlConnection conn = new SqlConnection(MethodClass.connection);
        int i = 1;
        public Label lblSender;
        public Label lbl;
        public Button btnAccept;
        public Button btnDecline;

        uc_otherAccounts otherAccounts = new uc_otherAccounts();
        uc_PrivateAccount privateAccount=new uc_PrivateAccount();
        MainPage mainPage=new MainPage();


        private void uc_notifications_Load(object sender, EventArgs e)
        {
            showRequests();
            
        }

        public void showRequests()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from NotificationsTable ", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["MessageReciever"].ToString() == Properties.Settings.Default.uName)
                {
                    
                    lblSender = new Label();
                    lbl = new Label();
                    btnAccept = new Button();
                    btnDecline = new Button();

                    lblSender.Name = "label" + i;
                    lblSender.Text = dr["MessageSender"].ToString() ;
                    lblSender.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    lblSender.AutoSize = true;
                    lblSender.Margin = new Padding(0, 0, 0, 0);

                    lbl.Name = "label" + i;
                    lbl.Text = " wants to follow you, click to accept";
                    lbl.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    lbl.AutoSize = true;
                    lbl.Margin = new Padding(0, 0, 100, 0);

                    btnAccept.AutoSize = true;
                    btnAccept.Name = "button" + i;
                    btnAccept.BackColor = Color.Thistle;
                    btnAccept.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    btnAccept.Text = "Accept";                    
                    btnAccept.Margin = new Padding(0, 0, 10, 0);
                    btnAccept.Click += new EventHandler(this.buttonAccept_click);

                    btnDecline.AutoSize = true;
                    btnDecline.Name = "button" + i;
                    btnDecline.BackColor = Color.Thistle;
                    btnDecline.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    btnDecline.Text = "Decline";
                    btnDecline.Margin= new Padding(0, 0, 250, 30);
                    btnDecline.Click += new EventHandler(this.buttonDecline_click);                    

                    flowPanelNotifications.Controls.Add(lblSender);
                    flowPanelNotifications.Controls.Add(lbl);
                    flowPanelNotifications.Controls.Add(btnAccept);
                    flowPanelNotifications.Controls.Add(btnDecline);
                    i++;


                    lblSender.Click += new EventHandler(this.lblSender_click);
                    lbl.Click += new EventHandler(this.lblSender_click);

                }



            }
            dr.Close();
            conn.Close();

        }

        void buttonAccept_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Panel pnl = new Panel();

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("insert into FollowersTable(Username,WhoFollowesThem) values('" + Properties.Settings.Default.uName + "',@messageSender)", conn);
            SqlCommand cmd2 = new SqlCommand("Select * from NotificationsTable where MessageReciever= '" + Properties.Settings.Default.uName + "' ", conn);
            SqlCommand cmd3 = new SqlCommand("update NotificationsTable set Answer=1 where MessageSender= @messageSender and MessageReciever= '"+Properties.Settings.Default.uName+"' ", conn);
            SqlCommand cmd4 = new SqlCommand("insert into FollowedTable(Username,WhoTheyFollowed) values(@username,@whoTheyFollowed)", conn);

            SqlDataReader dr = cmd2.ExecuteReader();
            dr.Read();

            cmd1.Parameters.AddWithValue("@messageSender", dr["MessageSender"].ToString());
            cmd3.Parameters.AddWithValue("@messageSender", dr["MessageSender"].ToString());
            cmd4.Parameters.AddWithValue("@username", dr["MessageSender"].ToString());
            cmd4.Parameters.AddWithValue("@whoTheyFollowed", Properties.Settings.Default.uName);
            cmd1.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();

            dr.Close();


            SqlCommand cmd5 = new SqlCommand("select * from FollowedTable where Username= ('" + Properties.Settings.Default.stalkName + "') and WhoTheyFollowed=('" + Properties.Settings.Default.uName + "')", conn);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                if (dr5["Username"].ToString() == Properties.Settings.Default.stalkName)
                {
                    
                    otherAccounts.answer = true;
                    privateAccount.answer= true;
                    otherAccounts.btnFollowRequest.BackColor = Color.MistyRose;

                }
                else
                {
                    otherAccounts.answer= false;
                    privateAccount.answer= false;
                }
            }
            dr5.Close();

            conn.Close();
            
            DeleteRequest();
            
        }

        void buttonDecline_click(object sender, EventArgs e)
        {
            //Get the button clicked
            Button btn = sender as Button;
            
            DeleteRequest();
            
        }

        public void DeleteRequest()
        {
            

            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from NotificationsTable where MessageReciever= '" + Properties.Settings.Default.uName + "' ", conn);
            SqlCommand cmd3 = new SqlCommand("update NotificationsTable set Answer=1 where MessageSender= @messageSender and MessageReciever= '" + Properties.Settings.Default.uName + "' ", conn);
           SqlCommand cmd1 = new SqlCommand("delete from NotificationsTable where Answer=1 ", conn);
            SqlDataReader dr = cmd2.ExecuteReader();
            dr.Read();

            cmd3.Parameters.AddWithValue("@messageSender", dr["MessageSender"].ToString());
            cmd3.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            
            
            dr.Close();
            conn.Close();
            flowPanelNotifications.Controls.Clear();
            showRequests();
            
        }

        public void lblSender_click(object sender, EventArgs e)
        {
            Label lblSender = sender as Label;
            Properties.Settings.Default.stalkName = lblSender.Text;
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
                                MethodClass.ShowUserControl(otherAccounts, panelNotifications);
                                
                                //MainPage mp = new MainPage();
                                //mp.stack.Push(otherAccounts);
                                //mp.btnBackPage.Visible = true;
                            }
                            else
                            {
                                MethodClass showControl = new MethodClass();
                                uc_PrivateAccount privateAccount = new uc_PrivateAccount();
                                MethodClass.ShowUserControl(privateAccount, panelNotifications);
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
                        MethodClass.ShowUserControl(privateAccount, panelNotifications);
                        //MainPage mp = new MainPage();
                        //mp.stack.Push(privateAccount);
                        //mp.btnBackPage.Visible = true;

                    }
                }
                else
                {

                    MethodClass showControl = new MethodClass();
                    uc_otherAccounts otherAccounts = new uc_otherAccounts();
                    MethodClass.ShowUserControl(otherAccounts, panelNotifications);
                    //MainPage mp = new MainPage();
                    //mp.stack.Push(otherAccounts);
                    //mp.btnBackPage.Visible = true;

                }
            }


            dr3.Close();
            conn.Close();

        }

    }
        
    }
