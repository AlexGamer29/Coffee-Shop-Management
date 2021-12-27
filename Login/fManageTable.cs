﻿using Login.DataAccessObject;
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
            LoadCategory();
        }

        #region Methods

        void ChangeAccount(int accountType)
        {
            adminToolStripMenuItem.Enabled = accountType == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }

        void LoadCategory()
        {
            List<Category> categories = CategoryDAO.Instance.GetListCategory();
            combobox_categories.DataSource = categories;
            combobox_categories.DisplayMember = "Name";

        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> foodList = FoodDAO.Instance.GetFoodByCategoryID(id);
            comboBox_food.DataSource = foodList;
            comboBox_food.DisplayMember = "Name";
            // Đổi tên Combox1
        }

        void LoadTable()
        { 
            flowLayoutPanel_listTable.Controls.Clear();

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
                string price = Currency.FormatCurrency("VND", (decimal)item.Price);
                string totalPrice = Currency.FormatCurrency("VND", (decimal)item.TotalPrice);
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
            listview_Receipt.Tag = (sender as Button).Tag;
            ShowReceipt(idTable);
        }

        private void btn_addMenu_Click(object sender, EventArgs e)
        {
            Table table = listview_Receipt.Tag as Table;
            
            int idReceipt = ReceiptDAO.Instance.GetUncheckReceiptIDByTableID(table.ID);
            int idFood = (comboBox_food.SelectedItem as Food).ID;
            int count = (int)numericUpDown_foodCount.Value;

            if (idReceipt == -1)
            {
                ReceiptDAO.Instance.InsertReceipt(table.ID);
                ReceiptInfoDAO.Instance.InsertReceiptInfo(ReceiptDAO.Instance.GetMaxIDReceipt(), idFood, count);
            }
            else
            {
                ReceiptInfoDAO.Instance.InsertReceiptInfo(idReceipt, idFood, count);    
            }
            ShowReceipt(table.ID);
            LoadTable();
        }

        private void btn_switchTable_Click(object sender, EventArgs e)
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
        

        private void combobox_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox combo = sender as ComboBox;

            if (combo.SelectedItem == null)
                return;

            Category Selected = combo.SelectedItem as Category;
            id = Selected.ID;

            LoadFoodListByCategoryID(id);
        }
        private void btn_checkOut_Click(object sender, EventArgs e)
        {
            Table table = listview_Receipt.Tag as Table;

            int idReceipt = ReceiptDAO.Instance.GetUncheckReceiptIDByTableID(table.ID);
            int discount = (int)amount_discount.Value;

            double totalPrice = Convert.ToDouble(txtbox_totalPrice.Text.Split(' ')[0]);
            double finaltotalPrice = totalPrice - (totalPrice/100) * discount;
            if (idReceipt != -1)
            {
                if (MessageBox.Show(String.Format("Ban co chac thanh toan hoa don cho ban {0}\n Tong tien" +
                    "Tong tien - (Tong tien/100) * Giam gia = {1} - ({1}/100) * {2} = {3}", table.Name, totalPrice, discount, finaltotalPrice), "Thong bao ", 
                    MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    ReceiptDAO.Instance.CheckOut(idReceipt, discount);
                    ShowReceipt(table.ID);

                    LoadTable(); 
                }
            }
        }
        #endregion


    }
}
