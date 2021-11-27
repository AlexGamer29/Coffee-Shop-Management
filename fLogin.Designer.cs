namespace Login
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label_coffee2 = new System.Windows.Forms.Label();
            this.label_coffee1 = new System.Windows.Forms.Label();
            this.coffee_logo = new System.Windows.Forms.PictureBox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.btn_forgot = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel_password = new System.Windows.Forms.Panel();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.password_logo = new System.Windows.Forms.PictureBox();
            this.panel_user = new System.Windows.Forms.Panel();
            this.txtbox_user = new System.Windows.Forms.TextBox();
            this.user_logo = new System.Windows.Forms.PictureBox();
            this.label_login = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_logo)).BeginInit();
            this.panel_login.SuspendLayout();
            this.panel_password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_logo)).BeginInit();
            this.panel_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.panel_logo.Controls.Add(this.label_coffee2);
            this.panel_logo.Controls.Add(this.label_coffee1);
            this.panel_logo.Controls.Add(this.coffee_logo);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(300, 530);
            this.panel_logo.TabIndex = 0;
            // 
            // label_coffee2
            // 
            this.label_coffee2.AutoSize = true;
            this.label_coffee2.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_coffee2.Location = new System.Drawing.Point(102, 272);
            this.label_coffee2.Name = "label_coffee2";
            this.label_coffee2.Size = new System.Drawing.Size(109, 23);
            this.label_coffee2.TabIndex = 1;
            this.label_coffee2.Text = "coffee shop";
            // 
            // label_coffee1
            // 
            this.label_coffee1.AutoSize = true;
            this.label_coffee1.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_coffee1.Location = new System.Drawing.Point(66, 247);
            this.label_coffee1.Name = "label_coffee1";
            this.label_coffee1.Size = new System.Drawing.Size(169, 23);
            this.label_coffee1.TabIndex = 0;
            this.label_coffee1.Text = "Phần mềm quản lý";
            // 
            // coffee_logo
            // 
            this.coffee_logo.Image = ((System.Drawing.Image)(resources.GetObject("coffee_logo.Image")));
            this.coffee_logo.Location = new System.Drawing.Point(96, 114);
            this.coffee_logo.Name = "coffee_logo";
            this.coffee_logo.Size = new System.Drawing.Size(120, 120);
            this.coffee_logo.TabIndex = 0;
            this.coffee_logo.TabStop = false;
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.pictureBox_close);
            this.panel_login.Controls.Add(this.btn_forgot);
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.panel_password);
            this.panel_login.Controls.Add(this.panel_user);
            this.panel_login.Controls.Add(this.label_login);
            this.panel_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_login.Location = new System.Drawing.Point(300, 0);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(450, 530);
            this.panel_login.TabIndex = 1;
            // 
            // btn_forgot
            // 
            this.btn_forgot.BackColor = System.Drawing.SystemColors.Control;
            this.btn_forgot.FlatAppearance.BorderSize = 0;
            this.btn_forgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forgot.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_forgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btn_forgot.Location = new System.Drawing.Point(120, 300);
            this.btn_forgot.Name = "btn_forgot";
            this.btn_forgot.Size = new System.Drawing.Size(105, 38);
            this.btn_forgot.TabIndex = 5;
            this.btn_forgot.Text = "Forget Password?";
            this.btn_forgot.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(21, 300);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(93, 38);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel_password
            // 
            this.panel_password.BackColor = System.Drawing.SystemColors.Control;
            this.panel_password.Controls.Add(this.txtbox_password);
            this.panel_password.Controls.Add(this.password_logo);
            this.panel_password.Location = new System.Drawing.Point(0, 236);
            this.panel_password.Name = "panel_password";
            this.panel_password.Size = new System.Drawing.Size(450, 45);
            this.panel_password.TabIndex = 3;
            // 
            // txtbox_password
            // 
            this.txtbox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_password.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbox_password.Location = new System.Drawing.Point(56, 14);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(370, 20);
            this.txtbox_password.TabIndex = 5;
            this.txtbox_password.UseSystemPasswordChar = true;
            this.txtbox_password.Click += new System.EventHandler(this.txtbox_password_Click);
            // 
            // password_logo
            // 
            this.password_logo.Image = ((System.Drawing.Image)(resources.GetObject("password_logo.Image")));
            this.password_logo.Location = new System.Drawing.Point(6, 11);
            this.password_logo.Name = "password_logo";
            this.password_logo.Size = new System.Drawing.Size(24, 24);
            this.password_logo.TabIndex = 1;
            this.password_logo.TabStop = false;
            this.password_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.password_logo_MouseDown);
            this.password_logo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.password_logo_MouseUp);
            // 
            // panel_user
            // 
            this.panel_user.BackColor = System.Drawing.Color.White;
            this.panel_user.Controls.Add(this.txtbox_user);
            this.panel_user.Controls.Add(this.user_logo);
            this.panel_user.Location = new System.Drawing.Point(0, 185);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(450, 45);
            this.panel_user.TabIndex = 2;
            // 
            // txtbox_user
            // 
            this.txtbox_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_user.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbox_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.txtbox_user.Location = new System.Drawing.Point(56, 12);
            this.txtbox_user.Name = "txtbox_user";
            this.txtbox_user.Size = new System.Drawing.Size(370, 20);
            this.txtbox_user.TabIndex = 4;
            this.txtbox_user.Click += new System.EventHandler(this.txtbox_user_Click);
            // 
            // user_logo
            // 
            this.user_logo.Image = ((System.Drawing.Image)(resources.GetObject("user_logo.Image")));
            this.user_logo.Location = new System.Drawing.Point(6, 10);
            this.user_logo.Name = "user_logo";
            this.user_logo.Size = new System.Drawing.Size(24, 24);
            this.user_logo.TabIndex = 0;
            this.user_logo.TabStop = false;
            this.user_logo.Click += new System.EventHandler(this.user_logo_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.label_login.Location = new System.Drawing.Point(23, 114);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(322, 39);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "Login to your account";
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Image = global::Login.Properties.Resources.close;
            this.pictureBox_close.Location = new System.Drawing.Point(423, 3);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_close.TabIndex = 6;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // fLogin
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.panel_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_logo)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_password.ResumeLayout(false);
            this.panel_password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_logo)).EndInit();
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label label_coffee1;
        private System.Windows.Forms.Label label_coffee2;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Panel panel_password;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.PictureBox user_logo;
        private System.Windows.Forms.Button btn_forgot;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.PictureBox password_logo;
        private System.Windows.Forms.TextBox txtbox_user;
        private System.Windows.Forms.PictureBox coffee_logo;
        private System.Windows.Forms.PictureBox pictureBox_close;
    }
}

