namespace PicturesWithData
{
    partial class uc_notifications
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
            this.panelNotifications = new System.Windows.Forms.Panel();
            this.flowPanelNotifications = new System.Windows.Forms.FlowLayoutPanel();
            this.panelNotifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNotifications
            // 
            this.panelNotifications.Controls.Add(this.flowPanelNotifications);
            this.panelNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNotifications.Location = new System.Drawing.Point(0, 0);
            this.panelNotifications.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelNotifications.Name = "panelNotifications";
            this.panelNotifications.Size = new System.Drawing.Size(702, 495);
            this.panelNotifications.TabIndex = 0;
            // 
            // flowPanelNotifications
            // 
            this.flowPanelNotifications.Location = new System.Drawing.Point(126, 54);
            this.flowPanelNotifications.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowPanelNotifications.Name = "flowPanelNotifications";
            this.flowPanelNotifications.Size = new System.Drawing.Size(450, 400);
            this.flowPanelNotifications.TabIndex = 0;
            // 
            // uc_notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelNotifications);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_notifications";
            this.Size = new System.Drawing.Size(702, 495);
            this.Load += new System.EventHandler(this.uc_notifications_Load);
            this.panelNotifications.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNotifications;
        private System.Windows.Forms.FlowLayoutPanel flowPanelNotifications;
    }
}
