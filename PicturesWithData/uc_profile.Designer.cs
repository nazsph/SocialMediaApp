namespace PicturesWithData
{
    partial class uc_profile
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
            this.panelProfile = new System.Windows.Forms.Panel();
            this.panelSlidebar = new System.Windows.Forms.Panel();
            this.btnBioUpdate = new System.Windows.Forms.Button();
            this.btnSlidebar = new System.Windows.Forms.Button();
            this.flowPanelFollowers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.flowPanelPosts = new System.Windows.Forms.FlowLayoutPanel();
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
            this.socialMediaDataSet1 = new PicturesWithData.SocialMediaDataSet1();
            this.accountsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableTableAdapter = new PicturesWithData.SocialMediaDataSet1TableAdapters.AccountsTableTableAdapter();
            this.tableAdapterManager = new PicturesWithData.SocialMediaDataSet1TableAdapters.TableAdapterManager();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.postTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTableTableAdapter = new PicturesWithData.SocialMediaDataSet1TableAdapters.PostTableTableAdapter();
            this.picTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picTable2TableAdapter = new PicturesWithData.SocialMediaDataSet1TableAdapters.picTable2TableAdapter();
            this.timerSlidebar = new System.Windows.Forms.Timer(this.components);
            this.panelProfile.SuspendLayout();
            this.panelSlidebar.SuspendLayout();
            this.panelFollowed.SuspendLayout();
            this.panelFollowers.SuspendLayout();
            this.panelPostCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialMediaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTable2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProfile
            // 
            this.panelProfile.AutoScroll = true;
            this.panelProfile.Controls.Add(this.panelSlidebar);
            this.panelProfile.Controls.Add(this.flowPanelFollowers);
            this.panelProfile.Controls.Add(this.btnUpload);
            this.panelProfile.Controls.Add(this.lblUsername);
            this.panelProfile.Controls.Add(this.lblBio);
            this.panelProfile.Controls.Add(this.flowPanelPosts);
            this.panelProfile.Controls.Add(this.panelFollowed);
            this.panelProfile.Controls.Add(this.panelFollowers);
            this.panelProfile.Controls.Add(this.panelPostCount);
            this.panelProfile.Controls.Add(this.pbProfile);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProfile.Location = new System.Drawing.Point(0, 0);
            this.panelProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(702, 495);
            this.panelProfile.TabIndex = 3;
            // 
            // panelSlidebar
            // 
            this.panelSlidebar.Controls.Add(this.btnBioUpdate);
            this.panelSlidebar.Controls.Add(this.btnSlidebar);
            this.panelSlidebar.Location = new System.Drawing.Point(662, 3);
            this.panelSlidebar.MaximumSize = new System.Drawing.Size(34, 75);
            this.panelSlidebar.MinimumSize = new System.Drawing.Size(34, 34);
            this.panelSlidebar.Name = "panelSlidebar";
            this.panelSlidebar.Size = new System.Drawing.Size(34, 34);
            this.panelSlidebar.TabIndex = 24;
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
            this.btnBioUpdate.Click += new System.EventHandler(this.btnBioUpdate_Click);
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
            // flowPanelFollowers
            // 
            this.flowPanelFollowers.AutoScroll = true;
            this.flowPanelFollowers.BackColor = System.Drawing.Color.Thistle;
            this.flowPanelFollowers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanelFollowers.Location = new System.Drawing.Point(523, 3);
            this.flowPanelFollowers.Name = "flowPanelFollowers";
            this.flowPanelFollowers.Size = new System.Drawing.Size(136, 154);
            this.flowPanelFollowers.TabIndex = 23;
            this.flowPanelFollowers.Visible = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Thistle;
            this.btnUpload.Location = new System.Drawing.Point(662, 174);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(30, 30);
            this.btnUpload.TabIndex = 22;
            this.btnUpload.Text = "+";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(82, 174);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 20);
            this.lblUsername.TabIndex = 21;
            this.lblUsername.Text = "Username";
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBio.Location = new System.Drawing.Point(376, 137);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(31, 20);
            this.lblBio.TabIndex = 20;
            this.lblBio.Text = "bio";
            // 
            // flowPanelPosts
            // 
            this.flowPanelPosts.AutoScroll = true;
            this.flowPanelPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanelPosts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowPanelPosts.Location = new System.Drawing.Point(0, 205);
            this.flowPanelPosts.Name = "flowPanelPosts";
            this.flowPanelPosts.Size = new System.Drawing.Size(702, 290);
            this.flowPanelPosts.TabIndex = 19;
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
            this.panelFollowed.TabIndex = 16;
            this.panelFollowed.Click += new System.EventHandler(this.panelFollowed_Click);
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
            this.lblFollowed.Click += new System.EventHandler(this.panelFollowed_Click);
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
            this.lblFollowedCount.Click += new System.EventHandler(this.panelFollowed_Click);
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
            this.panelFollowers.TabIndex = 17;
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
            this.panelPostCount.TabIndex = 18;
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
            this.lblPostCount.Size = new System.Drawing.Size(17, 20);
            this.lblPostCount.TabIndex = 5;
            this.lblPostCount.Text = "0";
            // 
            // pbProfile
            // 
            this.pbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProfile.Location = new System.Drawing.Point(49, 16);
            this.pbProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(145, 145);
            this.pbProfile.TabIndex = 3;
            this.pbProfile.TabStop = false;
            this.pbProfile.Click += new System.EventHandler(this.pbProfile_Click);
            // 
            // socialMediaDataSet1
            // 
            this.socialMediaDataSet1.DataSetName = "SocialMediaDataSet1";
            this.socialMediaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsTableBindingSource
            // 
            this.accountsTableBindingSource.DataMember = "AccountsTable";
            this.accountsTableBindingSource.DataSource = this.socialMediaDataSet1;
            // 
            // accountsTableTableAdapter
            // 
            this.accountsTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountsTableTableAdapter = this.accountsTableTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FollowedTableTableAdapter = null;
            this.tableAdapterManager.FollowersTableTableAdapter = null;
            this.tableAdapterManager.NotificationsTableTableAdapter = null;
            this.tableAdapterManager.pics1TableTableAdapter = null;
            this.tableAdapterManager.picTable2TableAdapter = null;
            this.tableAdapterManager.PostTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PicturesWithData.SocialMediaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // postTableBindingSource
            // 
            this.postTableBindingSource.DataMember = "PostTable";
            this.postTableBindingSource.DataSource = this.socialMediaDataSet1;
            // 
            // postTableTableAdapter
            // 
            this.postTableTableAdapter.ClearBeforeFill = true;
            // 
            // picTable2BindingSource
            // 
            this.picTable2BindingSource.DataMember = "picTable2";
            this.picTable2BindingSource.DataSource = this.socialMediaDataSet1;
            // 
            // picTable2TableAdapter
            // 
            this.picTable2TableAdapter.ClearBeforeFill = true;
            // 
            // timerSlidebar
            // 
            this.timerSlidebar.Interval = 10;
            this.timerSlidebar.Tick += new System.EventHandler(this.timerSlidebar_Tick);
            // 
            // uc_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelProfile);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_profile";
            this.Size = new System.Drawing.Size(702, 495);
            this.Load += new System.EventHandler(this.uc_profile_Load);
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            this.panelSlidebar.ResumeLayout(false);
            this.panelFollowed.ResumeLayout(false);
            this.panelFollowed.PerformLayout();
            this.panelFollowers.ResumeLayout(false);
            this.panelFollowers.PerformLayout();
            this.panelPostCount.ResumeLayout(false);
            this.panelPostCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialMediaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTable2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.Panel panelFollowed;
        private System.Windows.Forms.Label lblFollowed;
        private System.Windows.Forms.Label lblFollowedCount;
        private System.Windows.Forms.Panel panelPostCount;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label lblPostCount;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.FlowLayoutPanel flowPanelPosts;
        private System.Windows.Forms.Label lblUsername;
        private SocialMediaDataSet1 socialMediaDataSet1;
        private System.Windows.Forms.BindingSource accountsTableBindingSource;
        private SocialMediaDataSet1TableAdapters.AccountsTableTableAdapter accountsTableTableAdapter;
        private SocialMediaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource postTableBindingSource;
        private SocialMediaDataSet1TableAdapters.PostTableTableAdapter postTableTableAdapter;
        private System.Windows.Forms.BindingSource picTable2BindingSource;
        private SocialMediaDataSet1TableAdapters.picTable2TableAdapter picTable2TableAdapter;
        public System.Windows.Forms.Panel panelFollowers;
        public System.Windows.Forms.Label lblFollowers;
        public System.Windows.Forms.Label lblFollowersCount;
        private System.Windows.Forms.FlowLayoutPanel flowPanelFollowers;
        private System.Windows.Forms.Panel panelSlidebar;
        private System.Windows.Forms.Button btnBioUpdate;
        private System.Windows.Forms.Button btnSlidebar;
        private System.Windows.Forms.Timer timerSlidebar;
    }
}
