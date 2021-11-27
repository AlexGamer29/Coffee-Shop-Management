namespace Login
{
    partial class fAccountProfile
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
            this.panel_username = new System.Windows.Forms.Panel();
            this.label_userName = new System.Windows.Forms.Label();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.panel_displayName = new System.Windows.Forms.Panel();
            this.label_displayName = new System.Windows.Forms.Label();
            this.txtbox_displayName = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.panel_password = new System.Windows.Forms.Panel();
            this.txtbox_newPassword = new System.Windows.Forms.TextBox();
            this.panel_newPassword = new System.Windows.Forms.Panel();
            this.label_newPassword = new System.Windows.Forms.Label();
            this.panel_retypeNewPassword = new System.Windows.Forms.Panel();
            this.label_retypeNewPassword = new System.Windows.Forms.Label();
            this.txtbox_retypeNewPassword = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.panel_username.SuspendLayout();
            this.panel_displayName.SuspendLayout();
            this.panel_password.SuspendLayout();
            this.panel_newPassword.SuspendLayout();
            this.panel_retypeNewPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_username
            // 
            this.panel_username.BackColor = System.Drawing.Color.White;
            this.panel_username.Controls.Add(this.label_userName);
            this.panel_username.Controls.Add(this.txtbox_username);
            this.panel_username.Location = new System.Drawing.Point(0, 82);
            this.panel_username.Name = "panel_username";
            this.panel_username.Size = new System.Drawing.Size(456, 45);
            this.panel_username.TabIndex = 3;
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
            this.label_userName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbox_username
            // 
            this.txtbox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_username.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbox_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.txtbox_username.Location = new System.Drawing.Point(134, 13);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(290, 20);
            this.txtbox_username.TabIndex = 4;
            // 
            // panel_displayName
            // 
            this.panel_displayName.BackColor = System.Drawing.Color.White;
            this.panel_displayName.Controls.Add(this.label_displayName);
            this.panel_displayName.Controls.Add(this.txtbox_displayName);
            this.panel_displayName.Location = new System.Drawing.Point(0, 146);
            this.panel_displayName.Name = "panel_displayName";
            this.panel_displayName.Size = new System.Drawing.Size(456, 45);
            this.panel_displayName.TabIndex = 6;
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
            this.label_displayName.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbox_displayName
            // 
            this.txtbox_displayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_displayName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbox_displayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.txtbox_displayName.Location = new System.Drawing.Point(136, 12);
            this.txtbox_displayName.Name = "txtbox_displayName";
            this.txtbox_displayName.Size = new System.Drawing.Size(290, 20);
            this.txtbox_displayName.TabIndex = 4;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_password.Location = new System.Drawing.Point(11, 9);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(76, 19);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "Mật khẩu";
            // 
            // txtbox_password
            // 
            this.txtbox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_password.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbox_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.txtbox_password.Location = new System.Drawing.Point(136, 8);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(290, 20);
            this.txtbox_password.TabIndex = 4;
            // 
            // panel_password
            // 
            this.panel_password.BackColor = System.Drawing.Color.White;
            this.panel_password.Controls.Add(this.label_password);
            this.panel_password.Controls.Add(this.txtbox_password);
            this.panel_password.Location = new System.Drawing.Point(0, 214);
            this.panel_password.Name = "panel_password";
            this.panel_password.Size = new System.Drawing.Size(456, 45);
            this.panel_password.TabIndex = 7;
            // 
            // txtbox_newPassword
            // 
            this.txtbox_newPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_newPassword.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbox_newPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.txtbox_newPassword.Location = new System.Drawing.Point(153, 12);
            this.txtbox_newPassword.Name = "txtbox_newPassword";
            this.txtbox_newPassword.Size = new System.Drawing.Size(273, 20);
            this.txtbox_newPassword.TabIndex = 4;
            // 
            // panel_newPassword
            // 
            this.panel_newPassword.BackColor = System.Drawing.Color.White;
            this.panel_newPassword.Controls.Add(this.label_newPassword);
            this.panel_newPassword.Controls.Add(this.txtbox_newPassword);
            this.panel_newPassword.Location = new System.Drawing.Point(0, 280);
            this.panel_newPassword.Name = "panel_newPassword";
            this.panel_newPassword.Size = new System.Drawing.Size(456, 45);
            this.panel_newPassword.TabIndex = 8;
            // 
            // label_newPassword
            // 
            this.label_newPassword.AutoSize = true;
            this.label_newPassword.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_newPassword.Location = new System.Drawing.Point(11, 12);
            this.label_newPassword.Name = "label_newPassword";
            this.label_newPassword.Size = new System.Drawing.Size(107, 19);
            this.label_newPassword.TabIndex = 5;
            this.label_newPassword.Text = "Mật khẩu mới";
            // 
            // panel_retypeNewPassword
            // 
            this.panel_retypeNewPassword.BackColor = System.Drawing.Color.White;
            this.panel_retypeNewPassword.Controls.Add(this.label_retypeNewPassword);
            this.panel_retypeNewPassword.Controls.Add(this.txtbox_retypeNewPassword);
            this.panel_retypeNewPassword.Location = new System.Drawing.Point(0, 344);
            this.panel_retypeNewPassword.Name = "panel_retypeNewPassword";
            this.panel_retypeNewPassword.Size = new System.Drawing.Size(456, 45);
            this.panel_retypeNewPassword.TabIndex = 9;
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
            this.label_retypeNewPassword.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtbox_retypeNewPassword
            // 
            this.txtbox_retypeNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_retypeNewPassword.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbox_retypeNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.txtbox_retypeNewPassword.Location = new System.Drawing.Point(153, 12);
            this.txtbox_retypeNewPassword.Name = "txtbox_retypeNewPassword";
            this.txtbox_retypeNewPassword.Size = new System.Drawing.Size(273, 20);
            this.txtbox_retypeNewPassword.TabIndex = 4;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_update.Location = new System.Drawing.Point(271, 405);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 36);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_exit.Location = new System.Drawing.Point(375, 405);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 36);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.label_login.Location = new System.Drawing.Point(8, 27);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(271, 39);
            this.label_login.TabIndex = 12;
            this.label_login.Text = "Thông tin cá nhân";
            this.label_login.Click += new System.EventHandler(this.label_login_Click);
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_close.Image = global::Login.Properties.Resources.close;
            this.pictureBox_close.Location = new System.Drawing.Point(429, 2);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_close.TabIndex = 13;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // fAccountProfile
            // 
            this.AcceptButton = this.btn_update;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(455, 456);
            this.Controls.Add(this.pictureBox_close);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.panel_retypeNewPassword);
            this.Controls.Add(this.panel_newPassword);
            this.Controls.Add(this.panel_password);
            this.Controls.Add(this.panel_displayName);
            this.Controls.Add(this.panel_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAccountProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.fAccountProfile_Load);
            this.panel_username.ResumeLayout(false);
            this.panel_username.PerformLayout();
            this.panel_displayName.ResumeLayout(false);
            this.panel_displayName.PerformLayout();
            this.panel_password.ResumeLayout(false);
            this.panel_password.PerformLayout();
            this.panel_newPassword.ResumeLayout(false);
            this.panel_newPassword.PerformLayout();
            this.panel_retypeNewPassword.ResumeLayout(false);
            this.panel_retypeNewPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_username;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.Panel panel_displayName;
        private System.Windows.Forms.Label label_displayName;
        private System.Windows.Forms.TextBox txtbox_displayName;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Panel panel_password;
        private System.Windows.Forms.TextBox txtbox_newPassword;
        private System.Windows.Forms.Panel panel_newPassword;
        private System.Windows.Forms.Label label_newPassword;
        private System.Windows.Forms.Panel panel_retypeNewPassword;
        private System.Windows.Forms.Label label_retypeNewPassword;
        private System.Windows.Forms.TextBox txtbox_retypeNewPassword;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.PictureBox pictureBox_close;
    }
}