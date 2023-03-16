using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ButtonControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Button button;
        List<Button> buttons;
        int i = 2;
        
       

        private void button1_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;

            Button buttonDynamic = new Button
            {
                Text = "Dynamic",
                Visible = true,
            };

           // buttonDynamic.Click += ButtonDynamic_Click;
            buttonDynamic.Location = new Point(12, 12);

            this.Controls.Add(buttonDynamic);
        }

       
        public void yeniKlasörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button = new Button();
            button.Name = ("button" + i).ToString();
            button.Size = new System.Drawing.Size(75, 23);
            button.UseVisualStyleBackColor = true;                
            button.Visible = true;
            button.BringToFront();
            var relativePoint = this.PointToClient(Cursor.Position);
            button.Location = relativePoint;

            Controls.Add(button);
            label1.Text = button.Name;
           
            i++;
        }

        private void btnFotoEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file= new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {

                flowLayoutPanel1.Controls.Add(new PictureBox()
                {
                    Size = new System.Drawing.Size(130, 130),
                    BorderStyle = BorderStyle.FixedSingle,
                    Image = new Bitmap(file.FileName),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    SizeMode = PictureBoxSizeMode.StretchImage

                }) ;
            }
             ;
        }
    }
}
