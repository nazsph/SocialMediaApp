namespace PicturesWithData
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panelUp = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnBackPage = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowPanelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.flowPanelSearchBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelUp.SuspendLayout();
            this.flowPanelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUp.Controls.Add(this.btnClose);
            this.panelUp.Controls.Add(this.btnNextPage);
            this.panelUp.Controls.Add(this.btnBackPage);
            this.panelUp.Controls.Add(this.btnMaximize);
            this.panelUp.Controls.Add(this.btnMinimize);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(873, 54);
            this.panelUp.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Thistle;
            this.btnClose.Location = new System.Drawing.Point(831, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Thistle;
            this.btnNextPage.Location = new System.Drawing.Point(57, 5);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(38, 38);
            this.btnNextPage.TabIndex = 0;
            this.btnNextPage.Text = "->";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Visible = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnBackPage
            // 
            this.btnBackPage.BackColor = System.Drawing.Color.Thistle;
            this.btnBackPage.Location = new System.Drawing.Point(11, 5);
            this.btnBackPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(38, 38);
            this.btnBackPage.TabIndex = 0;
            this.btnBackPage.Text = "<-";
            this.btnBackPage.UseVisualStyleBackColor = false;
            this.btnBackPage.Visible = false;
            this.btnBackPage.Click += new System.EventHandler(this.btnBackPage_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Thistle;
            this.btnMaximize.Location = new System.Drawing.Point(785, 5);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(38, 38);
            this.btnMaximize.TabIndex = 0;
            this.btnMaximize.Text = "❒";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Thistle;
            this.btnMinimize.Location = new System.Drawing.Point(739, 5);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 38);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Location = new System.Drawing.Point(0, 54);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(873, 496);
            this.panelMain.TabIndex = 0;
            // 
            // flowPanelLeft
            // 
            this.flowPanelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanelLeft.Controls.Add(this.btnMainPage);
            this.flowPanelLeft.Controls.Add(this.btnNotifications);
            this.flowPanelLeft.Controls.Add(this.btnProfile);
            this.flowPanelLeft.Controls.Add(this.btnSettings);
            this.flowPanelLeft.Controls.Add(this.btnLogout);
            this.flowPanelLeft.Controls.Add(this.txtSearch);
            this.flowPanelLeft.Controls.Add(this.flowPanelSearchBar);
            this.flowPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowPanelLeft.Location = new System.Drawing.Point(0, 54);
            this.flowPanelLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowPanelLeft.Name = "flowPanelLeft";
            this.flowPanelLeft.Size = new System.Drawing.Size(174, 496);
            this.flowPanelLeft.TabIndex = 1;
            // 
            // btnMainPage
            // 
            this.btnMainPage.BackColor = System.Drawing.Color.Thistle;
            this.btnMainPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMainPage.Location = new System.Drawing.Point(4, 5);
            this.btnMainPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(166, 39);
            this.btnMainPage.TabIndex = 0;
            this.btnMainPage.Text = "Main Page";
            this.btnMainPage.UseVisualStyleBackColor = false;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.BackColor = System.Drawing.Color.Thistle;
            this.btnNotifications.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNotifications.Location = new System.Drawing.Point(4, 54);
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(166, 39);
            this.btnNotifications.TabIndex = 0;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.UseVisualStyleBackColor = false;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Thistle;
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProfile.Location = new System.Drawing.Point(4, 103);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(166, 39);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Thistle;
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSettings.Location = new System.Drawing.Point(4, 152);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(166, 39);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Thistle;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Location = new System.Drawing.Point(4, 201);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(166, 39);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(3, 248);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(167, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // flowPanelSearchBar
            // 
            this.flowPanelSearchBar.AutoScroll = true;
            this.flowPanelSearchBar.Location = new System.Drawing.Point(30, 281);
            this.flowPanelSearchBar.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.flowPanelSearchBar.Name = "flowPanelSearchBar";
            this.flowPanelSearchBar.Size = new System.Drawing.Size(113, 201);
            this.flowPanelSearchBar.TabIndex = 3;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 550);
            this.Controls.Add(this.flowPanelLeft);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelUp);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panelUp.ResumeLayout(false);
            this.flowPanelLeft.ResumeLayout(false);
            this.flowPanelLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.FlowLayoutPanel flowPanelLeft;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel flowPanelSearchBar;
        public System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.Button btnNextPage;
        public System.Windows.Forms.Button btnBackPage;
    }
}