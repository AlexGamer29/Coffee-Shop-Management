using Login.DataAccessObject;
using Login.DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class fAccountProfile : Form
    {
        private AccountAuthentication loginAccount;
        private event EventHandler<AccountEvent> updateAccount;

        public AccountAuthentication LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        public fAccountProfile(AccountAuthentication account)
        {
            InitializeComponent();
            LoginAccount = account;
        }

        void ChangeAccount(AccountAuthentication account)
        {
            txtbox_username.Text = LoginAccount.UserName;
            txtbox_displayName.Text = LoginAccount.DisplayName;
        }

        int checkCredential(string userName, string password)
        {
            bool credential = fLogin.Login(userName, password);
            return !credential ? 0 : 1;
        }

        void UpdateAccountInfo()
        {
            string userName = txtbox_username.Text;
            string displayName = txtbox_displayName.Text;
            string password = txtbox_password.Text;
            string newPassword = txtbox_newPassword.Text;
            string retypeNewPassword = txtbox_retypeNewPassword.Text;

            /// Nếu 2 trường mật khẩu mới null thì hash lại trường mật khẩu hiện tại
            /// Ngược lại check 2 trường mật khẩu 
            string hashPassword = "";

            if (!BCrypt.Net.BCrypt.Equals(newPassword, retypeNewPassword))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                int check = checkCredential(userName, password);
                if (string.IsNullOrEmpty(newPassword) && string.IsNullOrEmpty(retypeNewPassword) && string.IsNullOrWhiteSpace(newPassword) && string.IsNullOrWhiteSpace(retypeNewPassword))
                {
                    if (MessageBox.Show("Thay đổi userName", "Bạn có chắc muốn thay đồi userName", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        hashPassword += BCrypt.Net.BCrypt.HashPassword(password);
                    }
                }
                else
                {
                    hashPassword += BCrypt.Net.BCrypt.HashPassword(newPassword);
                }

                if (AccountDAO.Instance.UpdateAccount(userName, displayName, check, hashPassword)) /** BCrypt.Net.BCrypt.HashPassword(retypeNewPassword) **/
                {
                    MessageBox.Show("Cập nhật thông tin cá nhân thành công!");
                    if (updateAccount != null)
                    {
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }

        private void fAccountProfile_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Dispose();
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Dispose();
        }
    }
}