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
    public partial class fCreateAccount : Form
    {
        public fCreateAccount()
        {
            InitializeComponent();
        }

        private void label_login_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private static void ClearTextBoxes(Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();
                else
                    ClearTextBoxes(ctrl.Controls);
            }
        }

        private void btn_addAccount_Click(object sender, EventArgs e)
        {
        /** Xoá model Entities => Nhớ input lại
            try
            {
                CoffeeShopEntities coffeeEntities = new CoffeeShopEntities();
                Account account = new Account()
                {
                    userName = txtbox_username.Text,
                    displayName = txtbox_displayName.Text,
                    password = BCrypt.Net.BCrypt.HashString(txtbox_newPassword.Text),
                    accountType = 1,
                };
                var newPassword = txtbox_newPassword.Text;
                var retypeNewPassword = txtbox_retypeNewPassword.Text;

                if (newPassword != retypeNewPassword)
                {
                    MessageBox.Show("Retype new password. Two password not match");
                }
                else if (String.IsNullOrWhiteSpace(txtbox_username.Text))
                {
                    MessageBox.Show("Please type your username");
                }
                else if (String.IsNullOrWhiteSpace(txtbox_displayName.Text))
                {
                    MessageBox.Show("Please type your fullname");

                }
                else if (String.IsNullOrWhiteSpace(txtbox_newPassword.Text))
                {
                    MessageBox.Show("Please type your password");

                }
                else if (String.IsNullOrWhiteSpace(txtbox_retypeNewPassword.Text))
                {
                    MessageBox.Show("Please confirm your password");
                }
                else
                        {
                    coffeeEntities.Accounts.Add(account);
                    coffeeEntities.SaveChanges();

                    // Clear all textbox in Form
                    fCreateAccount fCreateAccount = new fCreateAccount();
                    fCreateAccount.ClearTextBoxes(this.Controls);
                    MessageBox.Show("AccountDAO added");
                }
            }
            
            catch (Exception)
            {
                throw;
            }
            **/
        }
    }
}
