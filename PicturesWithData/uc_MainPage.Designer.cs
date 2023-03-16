namespace PicturesWithData
{
    partial class uc_MainPage
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMainPageuc = new System.Windows.Forms.Panel();
            this.flowPanelPictures = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMainPageuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainPageuc
            // 
            this.panelMainPageuc.AutoScroll = true;
            this.panelMainPageuc.Controls.Add(this.flowPanelPictures);
            this.panelMainPageuc.Location = new System.Drawing.Point(0, 0);
            this.panelMainPageuc.Name = "panelMainPageuc";
            this.panelMainPageuc.Size = new System.Drawing.Size(702, 495);
            this.panelMainPageuc.TabIndex = 0;
            // 
            // flowPanelPictures
            // 
            this.flowPanelPictures.AutoScroll = true;
            this.flowPanelPictures.Location = new System.Drawing.Point(168, 26);
            this.flowPanelPictures.Name = "flowPanelPictures";
            this.flowPanelPictures.Padding = new System.Windows.Forms.Padding(5);
            this.flowPanelPictures.Size = new System.Drawing.Size(367, 430);
            this.flowPanelPictures.TabIndex = 0;
            // 
            // uc_MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMainPageuc);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_MainPage";
            this.Size = new System.Drawing.Size(702, 495);
            this.Load += new System.EventHandler(this.uc_MainPage_Load);
            this.panelMainPageuc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainPageuc;
        private System.Windows.Forms.FlowLayoutPanel flowPanelPictures;
    }
}
