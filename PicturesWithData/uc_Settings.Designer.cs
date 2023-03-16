namespace PicturesWithData
{
    partial class uc_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Settings));
            this.panelSettings = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.btnSaveLastName = new System.Windows.Forms.Button();
            this.btnSaveName = new System.Windows.Forms.Button();
            this.btnSaveUsername = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtNewLName = new System.Windows.Forms.TextBox();
            this.txtOldLName = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtOldName = new System.Windows.Forms.TextBox();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.txtOldUsername = new System.Windows.Forms.TextBox();
            this.tabPagePrivacy = new System.Windows.Forms.TabPage();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.lblPrivacy = new System.Windows.Forms.Label();
            this.rbPrivateAccount = new System.Windows.Forms.RadioButton();
            this.rbOpenAccount = new System.Windows.Forms.RadioButton();
            this.tabPageSecurity = new System.Windows.Forms.TabPage();
            this.linkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnSavePassword = new System.Windows.Forms.Button();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.btnSaveEmail = new System.Windows.Forms.Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword2 = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.txtOldEMail = new System.Windows.Forms.TextBox();
            this.panelSettings.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageAccount.SuspendLayout();
            this.tabPagePrivacy.SuspendLayout();
            this.tabPageSecurity.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.tabControl);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(702, 495);
            this.panelSettings.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAccount);
            this.tabControl.Controls.Add(this.tabPagePrivacy);
            this.tabControl.Controls.Add(this.tabPageSecurity);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(702, 495);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.Controls.Add(this.btnSaveLastName);
            this.tabPageAccount.Controls.Add(this.btnSaveName);
            this.tabPageAccount.Controls.Add(this.btnSaveUsername);
            this.tabPageAccount.Controls.Add(this.lblLastName);
            this.tabPageAccount.Controls.Add(this.lblName);
            this.tabPageAccount.Controls.Add(this.lblUsername);
            this.tabPageAccount.Controls.Add(this.txtNewLName);
            this.tabPageAccount.Controls.Add(this.txtOldLName);
            this.tabPageAccount.Controls.Add(this.txtNewName);
            this.tabPageAccount.Controls.Add(this.txtOldName);
            this.tabPageAccount.Controls.Add(this.txtNewUsername);
            this.tabPageAccount.Controls.Add(this.txtOldUsername);
            this.tabPageAccount.Location = new System.Drawing.Point(4, 30);
            this.tabPageAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAccount.Size = new System.Drawing.Size(694, 461);
            this.tabPageAccount.TabIndex = 0;
            this.tabPageAccount.Text = "Account";
            this.tabPageAccount.UseVisualStyleBackColor = true;
            // 
            // btnSaveLastName
            // 
            this.btnSaveLastName.AutoSize = true;
            this.btnSaveLastName.BackColor = System.Drawing.Color.Thistle;
            this.btnSaveLastName.Location = new System.Drawing.Point(346, 130);
            this.btnSaveLastName.Name = "btnSaveLastName";
            this.btnSaveLastName.Size = new System.Drawing.Size(76, 31);
            this.btnSaveLastName.TabIndex = 2;
            this.btnSaveLastName.Text = "Save";
            this.btnSaveLastName.UseVisualStyleBackColor = false;
            this.btnSaveLastName.Click += new System.EventHandler(this.btnSaveLastName_Click);
            // 
            // btnSaveName
            // 
            this.btnSaveName.AutoSize = true;
            this.btnSaveName.BackColor = System.Drawing.Color.Thistle;
            this.btnSaveName.Location = new System.Drawing.Point(346, 91);
            this.btnSaveName.Name = "btnSaveName";
            this.btnSaveName.Size = new System.Drawing.Size(76, 31);
            this.btnSaveName.TabIndex = 2;
            this.btnSaveName.Text = "Save";
            this.btnSaveName.UseVisualStyleBackColor = false;
            this.btnSaveName.Click += new System.EventHandler(this.btnSaveName_Click);
            // 
            // btnSaveUsername
            // 
            this.btnSaveUsername.AutoSize = true;
            this.btnSaveUsername.BackColor = System.Drawing.Color.Thistle;
            this.btnSaveUsername.Location = new System.Drawing.Point(346, 54);
            this.btnSaveUsername.Name = "btnSaveUsername";
            this.btnSaveUsername.Size = new System.Drawing.Size(75, 31);
            this.btnSaveUsername.TabIndex = 2;
            this.btnSaveUsername.Text = "Save";
            this.btnSaveUsername.UseVisualStyleBackColor = false;
            this.btnSaveUsername.Click += new System.EventHandler(this.btnSaveUsername_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(34, 133);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 21);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(67, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(37, 59);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 21);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username :";
            // 
            // txtNewLName
            // 
            this.txtNewLName.Location = new System.Drawing.Point(240, 130);
            this.txtNewLName.Name = "txtNewLName";
            this.txtNewLName.Size = new System.Drawing.Size(100, 29);
            this.txtNewLName.TabIndex = 0;
            // 
            // txtOldLName
            // 
            this.txtOldLName.Location = new System.Drawing.Point(134, 130);
            this.txtOldLName.Name = "txtOldLName";
            this.txtOldLName.Size = new System.Drawing.Size(100, 29);
            this.txtOldLName.TabIndex = 0;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(240, 91);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(100, 29);
            this.txtNewName.TabIndex = 0;
            // 
            // txtOldName
            // 
            this.txtOldName.Location = new System.Drawing.Point(134, 91);
            this.txtOldName.Name = "txtOldName";
            this.txtOldName.Size = new System.Drawing.Size(100, 29);
            this.txtOldName.TabIndex = 0;
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(240, 56);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(100, 29);
            this.txtNewUsername.TabIndex = 0;
            // 
            // txtOldUsername
            // 
            this.txtOldUsername.Location = new System.Drawing.Point(134, 56);
            this.txtOldUsername.Name = "txtOldUsername";
            this.txtOldUsername.Size = new System.Drawing.Size(100, 29);
            this.txtOldUsername.TabIndex = 0;
            // 
            // tabPagePrivacy
            // 
            this.tabPagePrivacy.Controls.Add(this.btnSave1);
            this.tabPagePrivacy.Controls.Add(this.lblPrivacy);
            this.tabPagePrivacy.Controls.Add(this.rbPrivateAccount);
            this.tabPagePrivacy.Controls.Add(this.rbOpenAccount);
            this.tabPagePrivacy.Location = new System.Drawing.Point(4, 30);
            this.tabPagePrivacy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPagePrivacy.Name = "tabPagePrivacy";
            this.tabPagePrivacy.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPagePrivacy.Size = new System.Drawing.Size(694, 461);
            this.tabPagePrivacy.TabIndex = 1;
            this.tabPagePrivacy.Text = "Privacy";
            this.tabPagePrivacy.UseVisualStyleBackColor = true;
            // 
            // btnSave1
            // 
            this.btnSave1.AutoSize = true;
            this.btnSave1.BackColor = System.Drawing.Color.Thistle;
            this.btnSave1.Location = new System.Drawing.Point(431, 53);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(120, 31);
            this.btnSave1.TabIndex = 3;
            this.btnSave1.Text = "Save Changes";
            this.btnSave1.UseVisualStyleBackColor = false;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // lblPrivacy
            // 
            this.lblPrivacy.AutoSize = true;
            this.lblPrivacy.Location = new System.Drawing.Point(7, 58);
            this.lblPrivacy.Name = "lblPrivacy";
            this.lblPrivacy.Size = new System.Drawing.Size(126, 21);
            this.lblPrivacy.TabIndex = 2;
            this.lblPrivacy.Text = "Account Privacy";
            // 
            // rbPrivateAccount
            // 
            this.rbPrivateAccount.AutoSize = true;
            this.rbPrivateAccount.Location = new System.Drawing.Point(282, 56);
            this.rbPrivateAccount.Name = "rbPrivateAccount";
            this.rbPrivateAccount.Size = new System.Drawing.Size(143, 25);
            this.rbPrivateAccount.TabIndex = 1;
            this.rbPrivateAccount.Text = "Private Account";
            this.rbPrivateAccount.UseVisualStyleBackColor = true;
            // 
            // rbOpenAccount
            // 
            this.rbOpenAccount.AutoSize = true;
            this.rbOpenAccount.Checked = true;
            this.rbOpenAccount.Location = new System.Drawing.Point(139, 56);
            this.rbOpenAccount.Name = "rbOpenAccount";
            this.rbOpenAccount.Size = new System.Drawing.Size(137, 25);
            this.rbOpenAccount.TabIndex = 0;
            this.rbOpenAccount.TabStop = true;
            this.rbOpenAccount.Text = "Public Account";
            this.rbOpenAccount.UseVisualStyleBackColor = true;
            // 
            // tabPageSecurity
            // 
            this.tabPageSecurity.Controls.Add(this.linkForgotPassword);
            this.tabPageSecurity.Controls.Add(this.btnSavePassword);
            this.tabPageSecurity.Controls.Add(this.lblOldPassword);
            this.tabPageSecurity.Controls.Add(this.btnSaveEmail);
            this.tabPageSecurity.Controls.Add(this.lblNewPassword);
            this.tabPageSecurity.Controls.Add(this.lbEmail);
            this.tabPageSecurity.Controls.Add(this.txtOldPassword);
            this.tabPageSecurity.Controls.Add(this.txtNewPassword2);
            this.tabPageSecurity.Controls.Add(this.txtNewPassword);
            this.tabPageSecurity.Controls.Add(this.txtNewEmail);
            this.tabPageSecurity.Controls.Add(this.txtOldEMail);
            this.tabPageSecurity.Location = new System.Drawing.Point(4, 30);
            this.tabPageSecurity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageSecurity.Name = "tabPageSecurity";
            this.tabPageSecurity.Size = new System.Drawing.Size(694, 461);
            this.tabPageSecurity.TabIndex = 2;
            this.tabPageSecurity.Text = "Security";
            this.tabPageSecurity.UseVisualStyleBackColor = true;
            // 
            // linkForgotPassword
            // 
            this.linkForgotPassword.AutoSize = true;
            this.linkForgotPassword.LinkColor = System.Drawing.Color.Black;
            this.linkForgotPassword.Location = new System.Drawing.Point(453, 136);
            this.linkForgotPassword.Name = "linkForgotPassword";
            this.linkForgotPassword.Size = new System.Drawing.Size(160, 21);
            this.linkForgotPassword.TabIndex = 11;
            this.linkForgotPassword.TabStop = true;
            this.linkForgotPassword.Text = "Forgot my password";
            this.linkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotPassword_LinkClicked);
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.AutoSize = true;
            this.btnSavePassword.BackColor = System.Drawing.Color.Thistle;
            this.btnSavePassword.Location = new System.Drawing.Point(371, 131);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(76, 31);
            this.btnSavePassword.TabIndex = 9;
            this.btnSavePassword.Text = "Save";
            this.btnSavePassword.UseVisualStyleBackColor = false;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(36, 101);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(117, 21);
            this.lblOldPassword.TabIndex = 7;
            this.lblOldPassword.Text = "Old Password :";
            // 
            // btnSaveEmail
            // 
            this.btnSaveEmail.AutoSize = true;
            this.btnSaveEmail.BackColor = System.Drawing.Color.Thistle;
            this.btnSaveEmail.Location = new System.Drawing.Point(371, 59);
            this.btnSaveEmail.Name = "btnSaveEmail";
            this.btnSaveEmail.Size = new System.Drawing.Size(75, 31);
            this.btnSaveEmail.TabIndex = 10;
            this.btnSaveEmail.Text = "Save";
            this.btnSaveEmail.UseVisualStyleBackColor = false;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(29, 136);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(124, 21);
            this.lblNewPassword.TabIndex = 7;
            this.lblNewPassword.Text = "New Password :";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(97, 64);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 21);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "Email :";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(159, 96);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(100, 29);
            this.txtOldPassword.TabIndex = 4;
            // 
            // txtNewPassword2
            // 
            this.txtNewPassword2.Location = new System.Drawing.Point(265, 131);
            this.txtNewPassword2.Name = "txtNewPassword2";
            this.txtNewPassword2.Size = new System.Drawing.Size(100, 29);
            this.txtNewPassword2.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(159, 131);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(100, 29);
            this.txtNewPassword.TabIndex = 4;
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Location = new System.Drawing.Point(265, 61);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(100, 29);
            this.txtNewEmail.TabIndex = 5;
            // 
            // txtOldEMail
            // 
            this.txtOldEMail.Location = new System.Drawing.Point(159, 61);
            this.txtOldEMail.Name = "txtOldEMail";
            this.txtOldEMail.Size = new System.Drawing.Size(100, 29);
            this.txtOldEMail.TabIndex = 6;
            // 
            // uc_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelSettings);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_Settings";
            this.Size = new System.Drawing.Size(702, 495);
            this.Load += new System.EventHandler(this.uc_Settings_Load);
            this.panelSettings.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageAccount.ResumeLayout(false);
            this.tabPageAccount.PerformLayout();
            this.tabPagePrivacy.ResumeLayout(false);
            this.tabPagePrivacy.PerformLayout();
            this.tabPageSecurity.ResumeLayout(false);
            this.tabPageSecurity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAccount;
        private System.Windows.Forms.TabPage tabPagePrivacy;
        private System.Windows.Forms.TabPage tabPageSecurity;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Label lblPrivacy;
        private System.Windows.Forms.RadioButton rbPrivateAccount;
        private System.Windows.Forms.RadioButton rbOpenAccount;
        private System.Windows.Forms.Button btnSaveLastName;
        private System.Windows.Forms.Button btnSaveName;
        private System.Windows.Forms.Button btnSaveUsername;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtNewLName;
        private System.Windows.Forms.TextBox txtOldLName;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtOldName;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.TextBox txtOldUsername;
        private System.Windows.Forms.LinkLabel linkForgotPassword;
        private System.Windows.Forms.Button btnSavePassword;
        private System.Windows.Forms.Button btnSaveEmail;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtNewPassword2;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.TextBox txtOldEMail;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
    }
}
