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
            this.panel_logo = new System.Windows.Forms.Panel();
            this.Label_Coffee2 = new System.Windows.Forms.Label();
            this.Label_Coffee1 = new System.Windows.Forms.Label();
            this.coffee_logo = new System.Windows.Forms.PictureBox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.PictureBox_Close = new System.Windows.Forms.PictureBox();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Panel_Password = new System.Windows.Forms.Panel();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Password_Logo = new System.Windows.Forms.PictureBox();
            this.Panel_User = new System.Windows.Forms.Panel();
            this.TextBox_UserName = new System.Windows.Forms.TextBox();
            this.user_logo = new System.Windows.Forms.PictureBox();
            this.label_login = new System.Windows.Forms.Label();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_logo)).BeginInit();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Close)).BeginInit();
            this.Panel_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Password_Logo)).BeginInit();
            this.Panel_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(232)))));
            this.panel_logo.Controls.Add(this.Label_Coffee2);
            this.panel_logo.Controls.Add(this.Label_Coffee1);
            this.panel_logo.Controls.Add(this.coffee_logo);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(300, 530);
            this.panel_logo.TabIndex = 0;
            // 
            // Label_Coffee2
            // 
            this.Label_Coffee2.AutoSize = true;
            this.Label_Coffee2.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label_Coffee2.Location = new System.Drawing.Point(103, 272);
            this.Label_Coffee2.Name = "Label_Coffee2";
            this.Label_Coffee2.Size = new System.Drawing.Size(105, 24);
            this.Label_Coffee2.TabIndex = 1;
            this.Label_Coffee2.Text = "coffee shop";
            // 
            // Label_Coffee1
            // 
            this.Label_Coffee1.AutoSize = true;
            this.Label_Coffee1.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label_Coffee1.Location = new System.Drawing.Point(70, 247);
            this.Label_Coffee1.Name = "Label_Coffee1";
            this.Label_Coffee1.Size = new System.Drawing.Size(164, 24);
            this.Label_Coffee1.TabIndex = 0;
            this.Label_Coffee1.Text = "Phần mềm quản lý";
            // 
            // coffee_logo
            // 
            this.coffee_logo.Image = global::Login.Properties.Resources.Coffee_logo;
            this.coffee_logo.Location = new System.Drawing.Point(96, 114);
            this.coffee_logo.Name = "coffee_logo";
            this.coffee_logo.Size = new System.Drawing.Size(120, 120);
            this.coffee_logo.TabIndex = 0;
            this.coffee_logo.TabStop = false;
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.PictureBox_Close);
            this.panel_login.Controls.Add(this.Button_Login);
            this.panel_login.Controls.Add(this.Panel_Password);
            this.panel_login.Controls.Add(this.Panel_User);
            this.panel_login.Controls.Add(this.label_login);
            this.panel_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_login.Location = new System.Drawing.Point(300, 0);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(450, 530);
            this.panel_login.TabIndex = 1;
            // 
            // PictureBox_Close
            // 
            this.PictureBox_Close.Image = global::Login.Properties.Resources.close;
            this.PictureBox_Close.Location = new System.Drawing.Point(423, 3);
            this.PictureBox_Close.Name = "PictureBox_Close";
            this.PictureBox_Close.Size = new System.Drawing.Size(24, 24);
            this.PictureBox_Close.TabIndex = 6;
            this.PictureBox_Close.TabStop = false;
            this.PictureBox_Close.Click += new System.EventHandler(this.PictureBox_Close_Click);
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(232)))));
            this.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Login.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_Login.ForeColor = System.Drawing.Color.White;
            this.Button_Login.Location = new System.Drawing.Point(21, 299);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(93, 38);
            this.Button_Login.TabIndex = 4;
            this.Button_Login.Text = "LOGIN";
            this.Button_Login.UseCompatibleTextRendering = true;
            this.Button_Login.UseVisualStyleBackColor = false;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Panel_Password
            // 
            this.Panel_Password.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_Password.Controls.Add(this.TextBox_Password);
            this.Panel_Password.Controls.Add(this.Password_Logo);
            this.Panel_Password.Location = new System.Drawing.Point(0, 236);
            this.Panel_Password.Name = "Panel_Password";
            this.Panel_Password.Size = new System.Drawing.Size(450, 45);
            this.Panel_Password.TabIndex = 3;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Password.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.TextBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(232)))));
            this.TextBox_Password.Location = new System.Drawing.Point(56, 14);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(370, 21);
            this.TextBox_Password.TabIndex = 5;
            this.TextBox_Password.UseSystemPasswordChar = true;
            this.TextBox_Password.Click += new System.EventHandler(this.TextBox_Password_Click);
            // 
            // Password_Logo
            // 
            this.Password_Logo.Image = global::Login.Properties.Resources.padlock;
            this.Password_Logo.Location = new System.Drawing.Point(6, 11);
            this.Password_Logo.Name = "Password_Logo";
            this.Password_Logo.Size = new System.Drawing.Size(24, 24);
            this.Password_Logo.TabIndex = 1;
            this.Password_Logo.TabStop = false;
            this.Password_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Password_Logo_MouseDown);
            this.Password_Logo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Password_Logo_MouseUp);
            // 
            // Panel_User
            // 
            this.Panel_User.BackColor = System.Drawing.Color.White;
            this.Panel_User.Controls.Add(this.TextBox_UserName);
            this.Panel_User.Controls.Add(this.user_logo);
            this.Panel_User.Location = new System.Drawing.Point(0, 185);
            this.Panel_User.Name = "Panel_User";
            this.Panel_User.Size = new System.Drawing.Size(450, 45);
            this.Panel_User.TabIndex = 2;
            // 
            // TextBox_UserName
            // 
            this.TextBox_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_UserName.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.TextBox_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(232)))));
            this.TextBox_UserName.Location = new System.Drawing.Point(56, 12);
            this.TextBox_UserName.Name = "TextBox_UserName";
            this.TextBox_UserName.Size = new System.Drawing.Size(370, 21);
            this.TextBox_UserName.TabIndex = 4;
            this.TextBox_UserName.Click += new System.EventHandler(this.TextBox_UserName_Click);
            // 
            // user_logo
            // 
            this.user_logo.Image = global::Login.Properties.Resources.user;
            this.user_logo.Location = new System.Drawing.Point(6, 10);
            this.user_logo.Name = "user_logo";
            this.user_logo.Size = new System.Drawing.Size(24, 24);
            this.user_logo.TabIndex = 0;
            this.user_logo.TabStop = false;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(232)))));
            this.label_login.Location = new System.Drawing.Point(23, 114);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(322, 39);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "Login to your account";
            // 
            // fLogin
            // 
            this.AcceptButton = this.Button_Login;
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
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Close)).EndInit();
            this.Panel_Password.ResumeLayout(false);
            this.Panel_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Password_Logo)).EndInit();
            this.Panel_User.ResumeLayout(false);
            this.Panel_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label Label_Coffee1;
        private System.Windows.Forms.Label Label_Coffee2;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Panel Panel_Password;
        private System.Windows.Forms.Panel Panel_User;
        private System.Windows.Forms.PictureBox user_logo;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.PictureBox Password_Logo;
        private System.Windows.Forms.TextBox TextBox_UserName;
        private System.Windows.Forms.PictureBox coffee_logo;
        private System.Windows.Forms.PictureBox PictureBox_Close;
    }
}

