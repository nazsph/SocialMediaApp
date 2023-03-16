namespace PicturesWithData
{
    partial class uc_otherAccounts
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
            this.components = new System.ComponentModel.Container();
            this.panelOthers = new System.Windows.Forms.Panel();
            this.flowPanelFollowers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUnfollow = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.flowPanelPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFollowRequest = new System.Windows.Forms.Button();
            this.panelFollowed = new System.Windows.Forms.Panel();
            this.lblFollowed = new System.Windows.Forms.Label();
            this.lblFollowedCount = new System.Windows.Forms.Label();
            this.panelFollowers = new System.Windows.Forms.Panel();
            this.lblFollowers = new System.Windows.Forms.Label();
            this.lblFollowersCount = new System.Windows.Forms.Label();
            this.panelPostCount = new System.Windows.Forms.Panel();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblPostCount = new System.Windows.Forms.Label();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.panelSlidebar = new System.Windows.Forms.Panel();
            this.btnUnfollower = new System.Windows.Forms.Button();
            this.btnSlidebar = new System.Windows.Forms.Button();
            this.timerSlidebar = new System.Windows.Forms.Timer(this.components);
            this.panelOthers.SuspendLayout();
            this.panelFollowed.SuspendLayout();
            this.panelFollowers.SuspendLayout();
            this.panelPostCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.panelSlidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOthers
            // 
            this.panelOthers.Controls.Add(this.panelSlidebar);
            this.panelOthers.Controls.Add(this.flowPanelFollowers);
            this.panelOthers.Controls.Add(this.btnUnfollow);
            this.panelOthers.Controls.Add(this.lblUsername);
            this.panelOthers.Controls.Add(this.lblBio);
            this.panelOthers.Controls.Add(this.flowPanelPosts);
            this.panelOthers.Controls.Add(this.btnFollowRequest);
            this.panelOthers.Controls.Add(this.panelFollowed);
            this.panelOthers.Controls.Add(this.panelFollowers);
            this.panelOthers.Controls.Add(this.panelPostCount);
            this.panelOthers.Controls.Add(this.pbProfile);
            this.panelOthers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOthers.Location = new System.Drawing.Point(0, 0);
            this.panelOthers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelOthers.Name = "panelOthers";
            this.panelOthers.Size = new System.Drawing.Size(702, 495);
            this.panelOthers.TabIndex = 0;
            // 
            // flowPanelFollowers
            // 
            this.flowPanelFollowers.AutoScroll = true;
            this.flowPanelFollowers.BackColor = System.Drawing.Color.Thistle;
            this.flowPanelFollowers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanelFollowers.Location = new System.Drawing.Point(526, 3);
            this.flowPanelFollowers.Name = "flowPanelFollowers";
            this.flowPanelFollowers.Size = new System.Drawing.Size(136, 154);
            this.flowPanelFollowers.TabIndex = 33;
            this.flowPanelFollowers.Visible = false;
            // 
            // btnUnfollow
            // 
            this.btnUnfollow.BackColor = System.Drawing.Color.Thistle;
            this.btnUnfollow.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUnfollow.Location = new System.Drawing.Point(507, 83);
            this.btnUnfollow.Name = "btnUnfollow";
            this.btnUnfollow.Size = new System.Drawing.Size(31, 31);
            this.btnUnfollow.TabIndex = 32;
            this.btnUnfollow.Text = "X";
            this.btnUnfollow.UseVisualStyleBackColor = false;
            this.btnUnfollow.Visible = false;
            this.btnUnfollow.Click += new System.EventHandler(this.btnUnfollow_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(82, 166);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 21);
            this.lblUsername.TabIndex = 30;
            this.lblUsername.Text = "Username";
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBio.Location = new System.Drawing.Point(376, 129);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(34, 21);
            this.lblBio.TabIndex = 29;
            this.lblBio.Text = "bio";
            // 
            // flowPanelPosts
            // 
            this.flowPanelPosts.AutoScroll = true;
            this.flowPanelPosts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowPanelPosts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowPanelPosts.Location = new System.Drawing.Point(0, 205);
            this.flowPanelPosts.Name = "flowPanelPosts";
            this.flowPanelPosts.Size = new System.Drawing.Size(702, 290);
            this.flowPanelPosts.TabIndex = 28;
            // 
            // btnFollowRequest
            // 
            this.btnFollowRequest.AutoSize = true;
            this.btnFollowRequest.BackColor = System.Drawing.Color.Thistle;
            this.btnFollowRequest.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFollowRequest.Location = new System.Drawing.Point(402, 83);
            this.btnFollowRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFollowRequest.Name = "btnFollowRequest";
            this.btnFollowRequest.Size = new System.Drawing.Size(98, 31);
            this.btnFollowRequest.TabIndex = 24;
            this.btnFollowRequest.Text = "Follow";
            this.btnFollowRequest.UseVisualStyleBackColor = false;
            this.btnFollowRequest.Click += new System.EventHandler(this.btnFollowRequest_Click);
            // 
            // panelFollowed
            // 
            this.panelFollowed.Controls.Add(this.lblFollowed);
            this.panelFollowed.Controls.Add(this.lblFollowedCount);
            this.panelFollowed.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelFollowed.Location = new System.Drawing.Point(497, 38);
            this.panelFollowed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFollowed.Name = "panelFollowed";
            this.panelFollowed.Size = new System.Drawing.Size(81, 40);
            this.panelFollowed.TabIndex = 25;
            this.panelFollowed.Click += new System.EventHandler(this.PanelFollowed_Click);
            // 
            // lblFollowed
            // 
            this.lblFollowed.AutoSize = true;
            this.lblFollowed.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFollowed.Location = new System.Drawing.Point(6, 20);
            this.lblFollowed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFollowed.Name = "lblFollowed";
            this.lblFollowed.Size = new System.Drawing.Size(70, 20);
            this.lblFollowed.TabIndex = 10;
            this.lblFollowed.Text = "Followed";
            this.lblFollowed.Click += new System.EventHandler(this.PanelFollowed_Click);
            // 
            // lblFollowedCount
            // 
            this.lblFollowedCount.AutoSize = true;
            this.lblFollowedCount.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFollowedCount.Location = new System.Drawing.Point(33, 0);
            this.lblFollowedCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFollowedCount.Name = "lblFollowedCount";
            this.lblFollowedCount.Size = new System.Drawing.Size(17, 20);
            this.lblFollowedCount.TabIndex = 7;
            this.lblFollowedCount.Text = "0";
            this.lblFollowedCount.Click += new System.EventHandler(this.PanelFollowed_Click);
            // 
            // panelFollowers
            // 
            this.panelFollowers.Controls.Add(this.lblFollowers);
            this.panelFollowers.Controls.Add(this.lblFollowersCount);
            this.panelFollowers.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelFollowers.Location = new System.Drawing.Point(412, 38);
            this.panelFollowers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFollowers.Name = "panelFollowers";
            this.panelFollowers.Size = new System.Drawing.Size(77, 40);
            this.panelFollowers.TabIndex = 26;
            this.panelFollowers.Click += new System.EventHandler(this.panelFollowers_Click);
            // 
            // lblFollowers
            // 
            this.lblFollowers.AutoSize = true;
            this.lblFollowers.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFollowers.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFollowers.Location = new System.Drawing.Point(1, 20);
            this.lblFollowers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFollowers.Name = "lblFollowers";
            this.lblFollowers.Size = new System.Drawing.Size(73, 20);
            this.lblFollowers.TabIndex = 9;
            this.lblFollowers.Text = "Followers";
            this.lblFollowers.Click += new System.EventHandler(this.panelFollowers_Click);
            // 
            // lblFollowersCount
            // 
            this.lblFollowersCount.AutoSize = true;
            this.lblFollowersCount.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFollowersCount.Location = new System.Drawing.Point(29, 0);
            this.lblFollowersCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFollowersCount.Name = "lblFollowersCount";
            this.lblFollowersCount.Size = new System.Drawing.Size(17, 20);
            this.lblFollowersCount.TabIndex = 6;
            this.lblFollowersCount.Text = "0";
            this.lblFollowersCount.Click += new System.EventHandler(this.panelFollowers_Click);
            // 
            // panelPostCount
            // 
            this.panelPostCount.Controls.Add(this.lblPost);
            this.panelPostCount.Controls.Add(this.lblPostCount);
            this.panelPostCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelPostCount.Location = new System.Drawing.Point(328, 38);
            this.panelPostCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPostCount.Name = "panelPostCount";
            this.panelPostCount.Size = new System.Drawing.Size(75, 40);
            this.panelPostCount.TabIndex = 27;
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPost.Location = new System.Drawing.Point(-4, 20);
            this.lblPost.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(79, 20);
            this.lblPost.TabIndex = 8;
            this.lblPost.Text = "PostCount";
            // 
            // lblPostCount
            // 
            this.lblPostCount.AutoSize = true;
            this.lblPostCount.Location = new System.Drawing.Point(28, 0);
            this.lblPostCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPostCount.Name = "lblPostCount";
            this.lblPostCount.Size = new System.Drawing.Size(19, 21);
            this.lblPostCount.TabIndex = 5;
            this.lblPostCount.Text = "0";
            // 
            // pbProfile
            // 
            this.pbProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbProfile.Location = new System.Drawing.Point(49, 8);
            this.pbProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(145, 145);
            this.pbProfile.TabIndex = 23;
            this.pbProfile.TabStop = false;
            // 
            // panelSlidebar
            // 
            this.panelSlidebar.Controls.Add(this.btnUnfollower);
            this.panelSlidebar.Controls.Add(this.btnSlidebar);
            this.panelSlidebar.Location = new System.Drawing.Point(665, 3);
            this.panelSlidebar.MaximumSize = new System.Drawing.Size(34, 75);
            this.panelSlidebar.MinimumSize = new System.Drawing.Size(34, 34);
            this.panelSlidebar.Name = "panelSlidebar";
            this.panelSlidebar.Size = new System.Drawing.Size(34, 34);
            this.panelSlidebar.TabIndex = 34;
            // 
            // btnUnfollower
            // 
            this.btnUnfollower.BackColor = System.Drawing.Color.Thistle;
            this.btnUnfollower.Location = new System.Drawing.Point(3, 37);
            this.btnUnfollower.Name = "btnUnfollower";
            this.btnUnfollower.Size = new System.Drawing.Size(28, 28);
            this.btnUnfollower.TabIndex = 26;
            this.btnUnfollower.Text = "-";
            this.btnUnfollower.UseVisualStyleBackColor = false;
            this.btnUnfollower.Click += new System.EventHandler(this.btnUnfollower_Click);
            // 
            // btnSlidebar
            // 
            this.btnSlidebar.BackColor = System.Drawing.Color.Thistle;
            this.btnSlidebar.Location = new System.Drawing.Point(3, 3);
            this.btnSlidebar.Name = "btnSlidebar";
            this.btnSlidebar.Size = new System.Drawing.Size(28, 28);
            this.btnSlidebar.TabIndex = 25;
            this.btnSlidebar.Text = "|||";
            this.btnSlidebar.UseVisualStyleBackColor = false;
            this.btnSlidebar.Click += new System.EventHandler(this.btnSlidebar_Click);
            // 
            // timerSlidebar
            // 
            this.timerSlidebar.Interval = 10;
            this.timerSlidebar.Tick += new System.EventHandler(this.timerSlidebar_Tick);
            // 
            // uc_otherAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelOthers);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_otherAccounts";
            this.Size = new System.Drawing.Size(702, 495);
            this.Load += new System.EventHandler(this.uc_otherAccounts_Load);
            this.panelOthers.ResumeLayout(false);
            this.panelOthers.PerformLayout();
            this.panelFollowed.ResumeLayout(false);
            this.panelFollowed.PerformLayout();
            this.panelFollowers.ResumeLayout(false);
            this.panelFollowers.PerformLayout();
            this.panelPostCount.ResumeLayout(false);
            this.panelPostCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.panelSlidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOthers;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.FlowLayoutPanel flowPanelPosts;
        private System.Windows.Forms.Panel panelFollowed;
        private System.Windows.Forms.Label lblFollowed;
        private System.Windows.Forms.Label lblFollowedCount;
        private System.Windows.Forms.Panel panelFollowers;
        private System.Windows.Forms.Label lblFollowers;
        private System.Windows.Forms.Label lblFollowersCount;
        private System.Windows.Forms.Panel panelPostCount;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label lblPostCount;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.Button btnUnfollow;
        private System.Windows.Forms.FlowLayoutPanel flowPanelFollowers;
        private System.Windows.Forms.Panel panelSlidebar;
        private System.Windows.Forms.Button btnUnfollower;
        private System.Windows.Forms.Button btnSlidebar;
        private System.Windows.Forms.Timer timerSlidebar;
        public System.Windows.Forms.Button btnFollowRequest;
    }
}
