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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PicturesWithData
{
    public partial class uc_MainPage : UserControl
    {
        public uc_MainPage()
        {
            InitializeComponent();
        }

        SqlConnection conn=new SqlConnection(MethodClass.connection);
        int i = 1,x,y,y2;
        public String picturepath;
        String usernames;

        private void uc_MainPage_Load(object sender, EventArgs e)
        {
            ShowOthersPics();
        }
        public void ShowOthersPics()
        {

            //kendi kullanıcı adımı seçtiricem followed tableda
            //foloowed tableda karşılık gelenleri posttableda seçtiricem

            Label lbl = new Label();
            Label lbl2 = new Label();
            PictureBox box = new PictureBox();

            String date;
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from FollowedTable inner join PostTable on FollowedTable.WhoTheyFollowed = PostTable.Username where FollowedTable.Username= '"+Properties.Settings.Default.uName+ "' order by postDate desc ", conn);
            SqlDataReader dr=cmd.ExecuteReader();
            while(dr.Read())
            {


                usernames = dr["WhoTheyFollowed"].ToString();
                lbl = new Label();
                lbl.Text = usernames;
                lbl.Name = "lbl" + i;
                lbl.AutoSize = true;
                lbl.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                lbl.BorderStyle = BorderStyle.Fixed3D;
                lbl.Click += new EventHandler(this.lbl_click);


                picturepath = dr["FilePath"].ToString();
                box = new PictureBox();
                box.ImageLocation = picturepath;
                box.Image = Image.FromFile(picturepath);
                box.Name = ("pictureBox" + i).ToString();
                box.Visible = true;
                box.BringToFront();
                box.Size = new System.Drawing.Size(330, 330); //220,220 3lü çıkarıyor ama orantısız büyük
                box.BorderStyle = BorderStyle.FixedSingle;
                box.SizeMode = PictureBoxSizeMode.StretchImage;


                date = dr["postDate"].ToString();
                lbl2 = new Label();
                lbl2.Text = date;
                lbl2.Name = "lbl" + i;
                lbl2.AutoSize = true;
                lbl2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                lbl2.BorderStyle = BorderStyle.Fixed3D;
                lbl2.Margin = new System.Windows.Forms.Padding(0, 0, 200, 50);


                flowPanelPictures.Controls.Add(lbl);
                flowPanelPictures.Controls.Add(box);
                flowPanelPictures.Controls.Add(lbl2);

            }




            dr.Close();
            conn.Close();
        }
        public void lbl_click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            Properties.Settings.Default.stalkName = lbl.Text;
            Properties.Settings.Default.Save();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from AccountsTable where Username= '"+Properties.Settings.Default.stalkName+"' ",conn);
            
            uc_otherAccounts otherAccounts=new uc_otherAccounts();
            MethodClass showControl = new MethodClass();
            MethodClass.ShowUserControl(otherAccounts, panelMainPageuc);
            conn.Close();
        }
    }
}
