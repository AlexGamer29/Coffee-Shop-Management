using Login.DataAccessObject;
using Login.DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = Login.DataTransferObject.Menu;

namespace Login
{
    public partial class fManageTable : Form
    {
        private AccountAuthentication loginAccount;

        public AccountAuthentication LoginAccount 
        { 
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.AccountType);  }
        }

        public fManageTable(AccountAuthentication login)
        {
            InitializeComponent();
            this.LoginAccount = login;
            LoadTable();
        }

        #region Methods

        void ChangeAccount(int accountType)
        {
            adminToolStripMenuItem.Enabled = accountType == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }

        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight};
                btn.Text = item.Name + Environment.NewLine + item.TableStatus;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.TableStatus)
                {
                    case "Trống":
                        btn.BackColor = Color.Gray;
                        break;
                    default:
                        btn.BackColor = Color.White;
                        break;
                }
                flowLayoutPanel_listTable.Controls.Add(btn);
            }
        }


        void ShowReceipt(int id)
        {
            listview_Receipt.Items.Clear();
            float totalPriceDisplay = 0;
            List<Menu> listReceiptInfo = MenuDAO.Instance.GetListMenuByTable(id);
            foreach (Menu item in listReceiptInfo)
            {
                string count = item.Count.ToString();
                string price = Currency.FormatCurrency("VND", ((decimal)item.Price));
                string totalPrice = Currency.FormatCurrency("VND", ((decimal)item.TotalPrice));
                ListViewItem listItem = new ListViewItem(item.FoodName.ToString());
                listItem.SubItems.Add(count);
                listItem.SubItems.Add(price);
                listItem.SubItems.Add(totalPrice);
                listview_Receipt.Items.Add(listItem);
                totalPriceDisplay += item.TotalPrice;
            }
            txtbox_totalPrice.Text = Currency.FormatCurrency("VND", ((decimal)totalPriceDisplay));
        }
        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int idTable = ((sender as Button).Tag as Table).ID;
            ShowReceipt(idTable);
        }

        private void btn_addMenu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fManageTable_Load(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile accountProfile = new fAccountProfile(LoginAccount);
            accountProfile.UpdateAccount += AccountProfile_UpdateAccount;
            accountProfile.ShowDialog();
        }

        private void AccountProfile_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Account.DisplayName + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin admin = new fAdmin();
            admin.ShowDialog();
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
