namespace Login
{
    partial class fCreateAccount
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
            this.label_login = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_addAccount = new System.Windows.Forms.Button();
            this.panel_retypeNewPassword = new System.Windows.Forms.Panel();
            this.label_retypeNewPassword = new System.Windows.Forms.Label();
            this.txtbox_retypeNewPassword = new System.Windows.Forms.TextBox();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.panel_newPassword = new System.Windows.Forms.Panel();
            this.label_newPassword = new System.Windows.Forms.Label();
            this.txtbox_newPassword = new System.Windows.Forms.TextBox();
            this.panel_displayName = new System.Windows.Forms.Panel();
            this.label_displayName = new System.Windows.Forms.Label();
            this.txtbox_displayName = new System.Windows.Forms.TextBox();
            this.label_userName = new System.Windows.Forms.Label();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.panel_username = new System.Windows.Forms.Panel();
            this.panel_retypeNewPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.panel_newPassword.SuspendLayout();
            this.panel_displayName.SuspendLayout();
            this.panel_username.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.label_login.Location = new System.Drawing.Point(12, 29);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(271, 39);
            this.label_login.TabIndex = 21;
            this.label_login.Text = "Thông tin cá nhân";
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_exit.Location = new System.Drawing.Point(379, 407);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 36);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_addAccount
            // 
            this.btn_addAccount.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_addAccount.Location = new System.Drawing.Point(233, 407);
            this.btn_addAccount.Name = "btn_addAccount";
            this.btn_addAccount.Size = new System.Drawing.Size(117, 36);
            this.btn_addAccount.TabIndex = 19;
            this.btn_addAccount.Text = "Thêm tài khoản";
            this.btn_addAccount.UseVisualStyleBackColor = true;
            this.btn_addAccount.Click += new System.EventHandler(this.btn_addAccount_Click);
            // 
            // panel_retypeNewPassword
            // 
            this.panel_retypeNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.panel_retypeNewPassword.Controls.Add(this.label_retypeNewPassword);
            this.panel_retypeNewPassword.Controls.Add(this.txtbox_retypeNewPassword);
            this.panel_retypeNewPassword.Location = new System.Drawing.Point(5, 305);
            this.panel_retypeNewPassword.Name = "panel_retypeNewPassword";
            this.panel_retypeNewPassword.Size = new System.Drawing.Size(456, 45);
            this.panel_retypeNewPassword.TabIndex = 18;
            // 
            // label_retypeNewPassword
            // 
            this.label_retypeNewPassword.AutoSize = true;
            this.label_retypeNewPassword.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_retypeNewPassword.Location = new System.Drawing.Point(11, 12);
            this.label_retypeNewPassword.Name = "label_retypeNewPassword";
            this.label_retypeNewPassword.Size = new System.Drawing.Size(136, 19);
            this.label_retypeNewPassword.TabIndex = 5;
            this.label_retypeNewPassword.Text = "Nhập lại mật khẩu";
            // 
            // txtbox_retypeNewPassword
            // 
            this.txtbox_retypeNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_retypeNewPassword.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbox_retypeNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.txtbox_retypeNewPassword.Location = new System.Drawing.Point(167, 12);
            this.txtbox_retypeNewPassword.Name = "txtbox_retypeNewPassword";
            this.txtbox_retypeNewPassword.Size = new System.Drawing.Size(273, 20);
            this.txtbox_retypeNewPassword.TabIndex = 4;
            this.txtbox_retypeNewPassword.UseSystemPasswordChar = true;
            this.txtbox_retypeNewPassword.UseWaitCursor = true;
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_close.Image = global::Login.Properties.Resources.close;
            this.pictureBox_close.Location = new System.Drawing.Point(433, 4);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_close.TabIndex = 22;
            this.pictureBox_close.TabStop = false;
            // 
            // panel_newPassword
            // 
            this.panel_newPassword.BackColor = System.Drawing.Color.Transparent;
            this.panel_newPassword.Controls.Add(this.label_newPassword);
            this.panel_newPassword.Controls.Add(this.txtbox_newPassword);
            this.panel_newPassword.Location = new System.Drawing.Point(5, 241);
            this.panel_newPassword.Name = "panel_newPassword";
            this.panel_newPassword.Size = new System.Drawing.Size(456, 45);
            this.panel_newPassword.TabIndex = 17;
            // 
            // label_newPassword
            // 
            this.label_newPassword.AutoSize = true;
            this.label_newPassword.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_newPassword.Location = new System.Drawing.Point(11, 12);
            this.label_newPassword.Name = "label_newPassword";
            this.label_newPassword.Size = new System.Drawing.Size(76, 19);
            this.label_newPassword.TabIndex = 5;
            this.label_newPassword.Text = "Mật khẩu";
            // 
            // txtbox_newPassword
            // 
            this.txtbox_newPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_newPassword.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbox_newPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.txtbox_newPassword.Location = new System.Drawing.Point(167, 12);
            this.txtbox_newPassword.Name = "txtbox_newPassword";
            this.txtbox_newPassword.Size = new System.Drawing.Size(273, 20);
            this.txtbox_newPassword.TabIndex = 4;
            this.txtbox_newPassword.UseSystemPasswordChar = true;
            this.txtbox_newPassword.UseWaitCursor = true;
            // 
            // panel_displayName
            // 
            this.panel_displayName.BackColor = System.Drawing.Color.Transparent;
            this.panel_displayName.Controls.Add(this.label_displayName);
            this.panel_displayName.Controls.Add(this.txtbox_displayName);
            this.panel_displayName.Location = new System.Drawing.Point(5, 173);
            this.panel_displayName.Name = "panel_displayName";
            this.panel_displayName.Size = new System.Drawing.Size(456, 45);
            this.panel_displayName.TabIndex = 15;
            // 
            // label_displayName
            // 
            this.label_displayName.AutoSize = true;
            this.label_displayName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_displayName.Location = new System.Drawing.Point(11, 12);
            this.label_displayName.Name = "label_displayName";
            this.label_displayName.Size = new System.Drawing.Size(77, 19);
            this.label_displayName.TabIndex = 5;
            this.label_displayName.Text = "Họ và tên";
            // 
            // txtbox_displayName
            // 
            this.txtbox_displayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_displayName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbox_displayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.txtbox_displayName.Location = new System.Drawing.Point(167, 12);
            this.txtbox_displayName.Name = "txtbox_displayName";
            this.txtbox_displayName.Size = new System.Drawing.Size(273, 20);
            this.txtbox_displayName.TabIndex = 4;
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_userName.Location = new System.Drawing.Point(11, 13);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(110, 19);
            this.label_userName.TabIndex = 5;
            this.label_userName.Text = "Tên đăng nhập";
            this.label_userName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbox_username
            // 
            this.txtbox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_username.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbox_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.txtbox_username.Location = new System.Drawing.Point(167, 12);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(273, 20);
            this.txtbox_username.TabIndex = 4;
            // 
            // panel_username
            // 
            this.panel_username.BackColor = System.Drawing.Color.Transparent;
            this.panel_username.Controls.Add(this.label_userName);
            this.panel_username.Controls.Add(this.txtbox_username);
            this.panel_username.Location = new System.Drawing.Point(5, 109);
            this.panel_username.Name = "panel_username";
            this.panel_username.Size = new System.Drawing.Size(456, 45);
            this.panel_username.TabIndex = 14;
            // 
            // fCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_addAccount);
            this.Controls.Add(this.panel_retypeNewPassword);
            this.Controls.Add(this.pictureBox_close);
            this.Controls.Add(this.panel_newPassword);
            this.Controls.Add(this.panel_displayName);
            this.Controls.Add(this.panel_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCreateAccount";
            this.Text = "Form1";
            this.panel_retypeNewPassword.ResumeLayout(false);
            this.panel_retypeNewPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.panel_newPassword.ResumeLayout(false);
            this.panel_newPassword.PerformLayout();
            this.panel_displayName.ResumeLayout(false);
            this.panel_displayName.PerformLayout();
            this.panel_username.ResumeLayout(false);
            this.panel_username.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_addAccount;
        private System.Windows.Forms.Panel panel_retypeNewPassword;
        private System.Windows.Forms.Label label_retypeNewPassword;
        private System.Windows.Forms.TextBox txtbox_retypeNewPassword;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Panel panel_newPassword;
        private System.Windows.Forms.Label label_newPassword;
        private System.Windows.Forms.TextBox txtbox_newPassword;
        private System.Windows.Forms.Panel panel_displayName;
        private System.Windows.Forms.Label label_displayName;
        private System.Windows.Forms.TextBox txtbox_displayName;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.Panel panel_username;
    }
}