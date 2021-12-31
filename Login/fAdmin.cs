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
using Login.DataAccessObject;
using Login.DataTransferObject;

namespace Login
{
    public partial class fAdmin : Form
    {
        BindingSource accountList = new BindingSource();
        BindingSource foodList = new BindingSource();

        //private object dtgvReceipt;
        //private object dtpkToDate;
        private object DateTimePickerReceipt;
        private object DateTimePickerToDate;

        public object DateTimePickerToDate1 { get => DateTimePickerToDate; set => DateTimePickerToDate = value; }
        //public object DateTimePickerReceipt1 { get => DateTimePickerReceipt; set => DateTimePickerReceipt = value; }

        public AccountAuthentication loginAccount;

        public fAdmin()
        {
            InitializeComponent();
            LoadMethods();
        }

        void LoadMethods()
        {
            dataGridView_menu.DataSource = foodList;
            dataGridView_account.DataSource = accountList;
            
            //LoadMenu(); => bỏ
            LoadListFood();

            LoadCategoryIntoCombobox(comboBox_category);
            AddMenuBinding();
            //LoadAccountList();
            AddAccountBinding();
            LoadAccount();
            LoadDateTimePickerReceipt();
            LoadListReceiptByDate(dateTimePicker_fromDate.Value, dateTimePicker_toDate.Value);
        }

        //void LoadMenu()
        //{
        //    string query = "SELECT * FROM dbo.Menu";
        //    dataGridView_menu.DataSource = DataAccess.Instance.ExecuteQuery(query);
        //}

        //void LoadAccountList()
        //{
        //    string query = "EXEC dbo.USERPROC_GetAccountByUserName @userName";
        //    dataGridView_account.DataSource = DataAccess.Instance.ExecuteQuery(query, new object[] {"admin"});
        //}

        void AddMenuBinding()
        {
            txtbox_foodName.DataBindings.Add(new Binding("Text",dataGridView_menu.DataSource,"Name", true, DataSourceUpdateMode.Never));
            txtbox_foodID.DataBindings.Add(new Binding("Text", dataGridView_menu.DataSource, "ID", true, DataSourceUpdateMode.Never));
            numericUpDown_foodPrice.DataBindings.Add(new Binding("Value", dataGridView_menu.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryIntoCombobox(ComboBox cb )
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void AddAccountBinding()
        {
            txtbox_userName.DataBindings.Add(new Binding("Text", dataGridView_account.DataSource, "Username", true, DataSourceUpdateMode.Never));
            txtbox_displayName.DataBindings.Add(new Binding("Text", dataGridView_account.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            numericUpDown_accountType.DataBindings.Add(new Binding("Value", dataGridView_account.DataSource, "AccountType", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void LoadListReceiptByDate(DateTime arrivalDate, DateTime departDate)
        {
            dataGridView_receipt.DataSource = ReceiptDAO.Instance.GetReceiptListByDate(arrivalDate, departDate);
        }
            
        
        void LoadDateTimePickerReceipt()
        {
            DateTime time = DateTime.Now;
            dateTimePicker_fromDate.Value = new DateTime(time.Year, time.Month, 1);
            dateTimePicker_toDate.Value = dateTimePicker_fromDate.Value.AddMonths(1).AddDays(-1); 
        }

        void AddAccount(string userName, string displayName, int accountType)
        {
            if(AccountDAO.Instance.InsertAccount(userName, displayName, accountType))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Bạn không thể xóa tài khoản bạn đang dùng");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int accountType)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, accountType))
            {
                MessageBox.Show("Sửa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPassword(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            fCreateAccount formCreateAccount = new fCreateAccount();
            formCreateAccount.ShowDialog();
            this.Show();
        }

        private void btn_viewMenu_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //thieu ham SearchFoodByName
        }
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private void btn_viewAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btn_viewReceipt_Click(object sender, EventArgs e)
        {
            LoadListReceiptByDate(dateTimePicker_fromDate.Value, dateTimePicker_toDate.Value);
        }
            
        private void txtbox_foodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_menu.SelectedCells.Count > 0)
                {
                    int id = (int)dataGridView_menu.SelectedCells[0].OwningRow.Cells["idCategories"].Value;
                    Category category = CategoryDAO.Instance.GetCategoryByID(id);
                    comboBox_category.SelectedItem = category;
                    int index = -1;
                    int i = 0;
                    foreach (Category item in comboBox_category.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    comboBox_category.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void btn_addMenu_Click(object sender, EventArgs e)
        {
            string name = txtbox_foodName.Text;
            int categoryID = (comboBox_category.SelectedItem as Category).ID;
            float price = (float)numericUpDown_foodPrice.Value;

            if(FoodDAO.Instance.AddFood(name, categoryID, price))
            {
                MessageBox.Show("Them mon thanh cong");
                LoadListFood();
                if(insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Co loi khi them mon");
            }
        }

        private void btn_editMenu_Click(object sender, EventArgs e)
        {
            string name = txtbox_foodName.Text;
            int categoryID = (comboBox_category.SelectedItem as Category).ID;
            float price = (float)numericUpDown_foodPrice.Value;
            int id = Convert.ToInt32(txtbox_foodID.Text);


            if (FoodDAO.Instance.UpdateFood(name, categoryID, price,id))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                if(updateFood != null)
                    updateFood(this,new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa món");
            }
        }

        private void btn_deleteMenu_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtbox_foodID.Text);


            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this,new EventArgs());
            }
            else
            {
                MessageBox.Show("Co loi khi xoa mon");
            }
        }

        private void btn_addAccount_Click(object sender, EventArgs e)
        {
            string userName = txtbox_userName.Text;
            string displayName = txtbox_displayName.Text;
            int accountType = (int) numericUpDown_accountType.Value;

            AddAccount(userName, displayName, accountType);
        }

        private void btn_deleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txtbox_userName.Text;

            DeleteAccount(userName);
        }

        private void btn_editAccount_Click(object sender, EventArgs e)
        {
            string userName = txtbox_userName.Text;
            string displayName = txtbox_displayName.Text;
            int accountType = (int)numericUpDown_accountType.Value;

            EditAccount(userName, displayName, accountType);
        }

        private void btn_resetPassword_Click(object sender, EventArgs e)
        {
            string userName = txtbox_userName.Text;

            ResetPassword(userName);
        }
    }
}