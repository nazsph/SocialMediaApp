using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace PicturesWithData
{
    internal class MethodClass
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public static void ShowUserControl(Control control, Control panel)
        {

            panel.Controls.Clear();
            panel.Dock = DockStyle.Fill;
            panel.BringToFront();
            panel.Focus();
            panel.Controls.Add(control);
        }
        public static string connection = ConfigurationManager.ConnectionStrings["PicturesWithData.Properties.Settings.SocialMediaConnectionString"].ConnectionString;
        // public string address = System.IO.File.ReadAllText(@"C:\Users\aysen\Desktop");
       
    }
}