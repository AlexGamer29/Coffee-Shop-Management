using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;
using Login.DataTransferObject;
using Login.DataAccessObject;

namespace Login
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        public static bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }
        private void Button_Login_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = TextBox_UserName.Text;
                string passWord = TextBox_Password.Text;

                if (Login(userName, passWord))
                {
                    AccountAuthentication loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                    RadForm formManageTable = new RadForm(loginAccount);
                    this.Hide();
                    formManageTable.ShowDialog();
                    this.Show();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                }
            }
            catch (BCrypt.Net.SaltParseException ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        protected void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void TextBox_UserName_Click(object sender, EventArgs e)
        {
            TextBox_UserName.BackColor = Color.White;
            Panel_User.BackColor = Color.White;
            Panel_Password.BackColor = SystemColors.Control;
            TextBox_Password.BackColor = SystemColors.Control;
        }
        private void TextBox_Password_Click(object sender, EventArgs e)
        {
            TextBox_Password.BackColor = Color.White;
            Panel_Password.BackColor = Color.White;
            TextBox_UserName.BackColor = SystemColors.Control;
            Panel_User.BackColor = SystemColors.Control;
        }

        private void Password_Logo_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox_Password.UseSystemPasswordChar = false;
        }

        private void Password_Logo_MouseUp(object sender, MouseEventArgs e)
        {
            TextBox_Password.UseSystemPasswordChar = true;
        }


        private void PictureBox_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
