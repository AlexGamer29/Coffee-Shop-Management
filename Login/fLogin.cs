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
            return DataAccessObject.AccountDAO.Instance.Login(userName, passWord);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtbox_userName.Text;
                string passWord = txtbox_password.Text;

                if (Login(userName, passWord))
                {
                    AccountAuthentication loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                    fManageTable formManageTable = new fManageTable(loginAccount);
                    this.Hide();
                    formManageTable.ShowDialog();
                    this.Show();
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

        private void txtbox_user_Click(object sender, EventArgs e)
        {
            txtbox_userName.BackColor = Color.White;
            panel_user.BackColor = Color.White;
            panel_password.BackColor = SystemColors.Control;
            txtbox_password.BackColor = SystemColors.Control;
        }

        private void user_logo_Click(object sender, EventArgs e)
        {

        }

        private void password_logo_MouseDown(object sender, MouseEventArgs e)
        {
            txtbox_password.UseSystemPasswordChar = false;
        }

        private void password_logo_MouseUp(object sender, MouseEventArgs e)
        {
            txtbox_password.UseSystemPasswordChar = true;
        }
        
        private void txtbox_password_Click(object sender, EventArgs e)
        {
            txtbox_password.BackColor = Color.White;
            panel_password.BackColor = Color.White;
            txtbox_userName.BackColor = SystemColors.Control;
            panel_user.BackColor = SystemColors.Control;
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
