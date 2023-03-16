namespace PicturesWithData
{
    partial class uc_PrivateAccount
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
            this.panelPrivate = new System.Windows.Forms.Panel();
            this.btnUnfollow = new System.Windows.Forms.Button();
            this.flowPanelPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnFollowRequest = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.PanelFollowed = new System.Windows.Forms.Panel();
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
            this.btnBioUpdate = new System.Windows.Forms.Button();
            this.btnSlidebar = new System.Windows.Forms.Button();
            this.panelPrivate.SuspendLayout();
            this.flowPanelPosts.SuspendLayout();
            this.PanelFollowed.SuspendLayout();
            this.panelFollowers.SuspendLayout();
            this.panelPostCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.panelSlidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrivate
            // 
            this.panelPrivate.Controls.Add(this.panelSlidebar);
            this.panelPrivate.Controls.Add(this.btnUnfollow);
            this.panelPrivate.Controls.Add(this.flowPanelPosts);
            this.panelPrivate.Controls.Add(this.btnFollowRequest);
            this.panelPrivate.Controls.Add(this.lblUsername);
            this.panelPrivate.Controls.Add(this.lblBio);
            this.panelPrivate.Controls.Add(this.PanelFollowed);
            this.panelPrivate.Controls.Add(this.panelFollowers);
            this.panelPrivate.Controls.Add(this.panelPostCount);
            this.panelPrivate.Controls.Add(this.pbProfile);
            this.panelPrivate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrivate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelPrivate.Location = new System.Drawing.Point(0, 0);
            this.panelPrivate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPrivate.Name = "panelPrivate";
            this.panelPrivate.Size = new System.Drawing.Size(702, 495);
            this.panelPrivate.TabIndex = 0;
            // 
            // btnUnfollow
            // 
            this.btnUnfollow.BackColor = System.Drawing.Color.Thistle;
            this.btnUnfollow.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUnfollow.Location = new System.Drawing.Point(507, 83);
            this.btnUnfollow.Name = "btnUnfollow";
            this.btnUnfollow.Size = new System.Drawing.Size(31, 31);
            this.btnUnfollow.TabIndex = 34;
            this.btnUnfollow.Text = "X";
            this.btnUnfollow.UseVisualStyleBackColor = false;
            this.btnUnfollow.Visible = false;
            this.btnUnfollow.Click += new System.EventHandler(this.btnUnfollow_Click);
            // 
            // flowPanelPosts
            // 
            this.flowPanelPosts.AutoScroll = true;
            this.flowPanelPosts.BackColor = System.Drawing.Color.Thistle;
            this.flowPanelPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanelPosts.Controls.Add(this.lblWarning);
            this.flowPanelPosts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowPanelPosts.Location = new System.Drawing.Point(0, 205);
            this.flowPanelPosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowPanelPosts.Name = "flowPanelPosts";
            this.flowPanelPosts.Size = new System.Drawing.Size(702, 290);
            this.flowPanelPosts.TabIndex = 33;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Thistle;
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarning.Location = new System.Drawing.Point(4, 0);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Padding = new System.Windows.Forms.Padding(240, 81, 0, 0);
            this.lblWarning.Size = new System.Drawing.Size(472, 111);
            this.lblWarning.TabIndex = 31;
            this.lblWarning.Text = "This account is Private";
            // 
            // btnFollowRequest
            // 
            this.btnFollowRequest.AutoSize = true;
            this.btnFollowRequest.BackColor = System.Drawing.Color.Thistle;
            this.btnFollowRequest.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFollowRequest.Location = new System.Drawing.Point(402, 83);
            this.btnFollowRequest.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnFollowRequest.Name = "btnFollowRequest";
            this.btnFollowRequest.Size = new System.Drawing.Size(98, 31);
            this.btnFollowRequest.TabIndex = 32;
            this.btnFollowRequest.Text = "Follow";
            this.btnFollowRequest.UseVisualStyleBackColor = false;
            this.btnFollowRequest.Click += new System.EventHandler(this.btnFollowRequest_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(82, 174);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 21);
            this.lblUsername.TabIndex = 29;
            this.lblUsername.Text = "Username";
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBio.Location = new System.Drawing.Point(443, 206);
            this.lblBio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(34, 21);
            this.lblBio.TabIndex = 28;
            this.lblBio.Text = "bio";
            // 
            // PanelFollowed
            // 
            this.PanelFollowed.Controls.Add(this.lblFollowed);
            this.PanelFollowed.Controls.Add(this.lblFollowedCount);
            this.PanelFollowed.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelFollowed.Location = new System.Drawing.Point(497, 38);
            this.PanelFollowed.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.PanelFollowed.Name = "PanelFollowed";
            this.PanelFollowed.Size = new System.Drawing.Size(81, 40);
            this.PanelFollowed.TabIndex = 24;
            // 
            // lblFollowed
            // 
            this.lblFollowed.AutoSize = true;
            this.lblFollowed.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFollowed.Location = new System.Drawing.Point(6, 20);
            this.lblFollowed.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblFollowed.Name = "lblFollowed";
            this.lblFollowed.Size = new System.Drawing.Size(70, 20);
            this.lblFollowed.TabIndex = 10;
            this.lblFollowed.Text = "Followed";
            // 
            // lblFollowedCount
            // 
            this.lblFollowedCount.AutoSize = true;
            this.lblFollowedCount.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFollowedCount.Location = new System.Drawing.Point(34, 0);
            this.lblFollowedCount.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblFollowedCount.Name = "lblFollowedCount";
            this.lblFollowedCount.Size = new System.Drawing.Size(17, 20);
            this.lblFollowedCount.TabIndex = 7;
            this.lblFollowedCount.Text = "0";
            // 
            // panelFollowers
            // 
            this.panelFollowers.Controls.Add(this.lblFollowers);
            this.panelFollowers.Controls.Add(this.lblFollowersCount);
            this.panelFollowers.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelFollowers.Location = new System.Drawing.Point(412, 38);
            this.panelFollowers.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panelFollowers.Name = "panelFollowers";
            this.panelFollowers.Size = new System.Drawing.Size(81, 40);
            this.panelFollowers.TabIndex = 25;
            // 
            // lblFollowers
            // 
            this.lblFollowers.AutoSize = true;
            this.lblFollowers.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblFollowers.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFollowers.Location = new System.Drawing.Point(4, 20);
            this.lblFollowers.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblFollowers.Name = "lblFollowers";
            this.lblFollowers.Size = new System.Drawing.Size(73, 20);
            this.lblFollowers.TabIndex = 9;
            this.lblFollowers.Text = "Followers";
            // 
            // lblFollowersCount
            // 
            this.lblFollowersCount.AutoSize = true;
            this.lblFollowersCount.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFollowersCount.Location = new System.Drawing.Point(33, 0);
            this.lblFollowersCount.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblFollowersCount.Name = "lblFollowersCount";
            this.lblFollowersCount.Size = new System.Drawing.Size(17, 20);
            this.lblFollowersCount.TabIndex = 6;
            this.lblFollowersCount.Text = "0";
            // 
            // panelPostCount
            // 
            this.panelPostCount.Controls.Add(this.lblPost);
            this.panelPostCount.Controls.Add(this.lblPostCount);
            this.panelPostCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelPostCount.Location = new System.Drawing.Point(328, 38);
            this.panelPostCount.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panelPostCount.Name = "panelPostCount";
            this.panelPostCount.Size = new System.Drawing.Size(81, 40);
            this.panelPostCount.TabIndex = 26;
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPost.Location = new System.Drawing.Point(2, 21);
            this.lblPost.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(79, 20);
            this.lblPost.TabIndex = 8;
            this.lblPost.Text = "PostCount";
            // 
            // lblPostCount
            // 
            this.lblPostCount.AutoSize = true;
            this.lblPostCount.Location = new System.Drawing.Point(30, 0);
            this.lblPostCount.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblPostCount.Name = "lblPostCount";
            this.lblPostCount.Size = new System.Drawing.Size(19, 21);
            this.lblPostCount.TabIndex = 5;
            this.lblPostCount.Text = "0";
            // 
            // pbProfile
            // 
            this.pbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProfile.Location = new System.Drawing.Point(49, 16);
            this.pbProfile.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(145, 145);
            this.pbProfile.TabIndex = 23;
            this.pbProfile.TabStop = false;
            // 
            // panelSlidebar
            // 
            this.panelSlidebar.Controls.Add(this.btnBioUpdate);
            this.panelSlidebar.Controls.Add(this.btnSlidebar);
            this.panelSlidebar.Location = new System.Drawing.Point(665, 3);
            this.panelSlidebar.MaximumSize = new System.Drawing.Size(34, 75);
            this.panelSlidebar.MinimumSize = new System.Drawing.Size(34, 34);
            this.panelSlidebar.Name = "panelSlidebar";
            this.panelSlidebar.Size = new System.Drawing.Size(34, 34);
            this.panelSlidebar.TabIndex = 35;
            // 
            // btnBioUpdate
            // 
            this.btnBioUpdate.BackColor = System.Drawing.Color.Thistle;
            this.btnBioUpdate.Location = new System.Drawing.Point(3, 37);
            this.btnBioUpdate.Name = "btnBioUpdate";
            this.btnBioUpdate.Size = new System.Drawing.Size(28, 28);
            this.btnBioUpdate.TabIndex = 26;
            this.btnBioUpdate.Text = "-";
            this.btnBioUpdate.UseVisualStyleBackColor = false;
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
            // 
            // uc_PrivateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPrivate);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_PrivateAccount";
            this.Size = new System.Drawing.Size(702, 495);
            this.Load += new System.EventHandler(this.uc_PrivateAccount_Load);
            this.panelPrivate.ResumeLayout(false);
            this.panelPrivate.PerformLayout();
            this.flowPanelPosts.ResumeLayout(false);
            this.flowPanelPosts.PerformLayout();
            this.PanelFollowed.ResumeLayout(false);
            this.PanelFollowed.PerformLayout();
            this.panelFollowers.ResumeLayout(false);
            this.panelFollowers.PerformLayout();
            this.panelPostCount.ResumeLayout(false);
            this.panelPostCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.panelSlidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrivate;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.Panel PanelFollowed;
        private System.Windows.Forms.Label lblFollowed;
        private System.Windows.Forms.Label lblFollowedCount;
        private System.Windows.Forms.Panel panelFollowers;
        private System.Windows.Forms.Label lblFollowers;
        private System.Windows.Forms.Label lblFollowersCount;
        private System.Windows.Forms.Panel panelPostCount;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label lblPostCount;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.Button btnFollowRequest;
        private System.Windows.Forms.FlowLayoutPanel flowPanelPosts;
        private System.Windows.Forms.Button btnUnfollow;
        private System.Windows.Forms.Panel panelSlidebar;
        private System.Windows.Forms.Button btnBioUpdate;
        private System.Windows.Forms.Button btnSlidebar;
    }
}
