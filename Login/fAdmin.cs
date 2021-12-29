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

namespace Login
{
    public partial class fAdmin : Form
    {
        BindingSource accountList = new BindingSource();
        //private object dtgvReceipt;
        //private object dtpkToDate;

        public fAdmin()
        {
            InitializeComponent();
            LoadMethods();
        }

        void LoadMethods()
        {
            dataGridView_account.DataSource = accountList;
            
            LoadMenu();
            LoadListFood();

            // Chưa chạy được
            //LoadCategoryIntoCombobox(comboBox_category);
            //AddMenuBinding();
            //LoadAccountList();
            AddAccountBinding();
            LoadAccount();
            // Sorry ae, lại lỗi nữa rồi =(((
            LoadDateTimePickerReceipt();
            LoadListReceiptByDate(dateTimePicker_fromDate.Value, dateTimePicker_toDate.Value);
        }

        void LoadMenu()
        {
            string query = "SELECT * FROM dbo.Menu";
            dataGridView_menu.DataSource = DataAccess.Instance.ExecuteQuery(query);
        }

        void LoadAccountList()
        {
            string query = "EXEC dbo.USERPROC_GetAccountByUserName @userName";
            dataGridView_account.DataSource = DataAccess.Instance.ExecuteQuery(query, new object[] {"admin"});
        }
        void AddMenuBinding()
        {
            txtbox_foodName.DataBindings.Add(new Binding("Text",dataGridView_menu,"Name"));
            txtbox_foodID.DataBindings.Add(new Binding("Text", dataGridView_menu, "ID"));
            numericUpDown_foodPrice.DataBindings.Add(new Binding("Value", dataGridView_menu, "Price"));
        }
        void LoadCategoryIntoCombobox(ComboBox cb )
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        void LoadListFood()
        {
            dataGridView_menu.DataSource = FoodDAO.Instance.GetListFood();
        }
        void AddAccountBinding()
        {
            txtbox_userName.DataBindings.Add(new Binding("Text", dataGridView_account.DataSource, "Username", true, DataSourceUpdateMode.Never));
            txtbox_displayName.DataBindings.Add(new Binding("Text", dataGridView_account.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            txtbox_accountType.DataBindings.Add(new Binding("Text", dataGridView_account.DataSource, "AccountType", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void LoadListReceiptByDate(DateTime CheckIn, DateTime CheckOut)
        {
            dataGridView_receipt.DataSource = ReceiptDAO.Instance.GetReceiptListByDate(CheckIn, CheckOut);
        }
            
        
        void LoadDateTimePickerReceipt()
        {
            DateTime time = DateTime.Now;
            dateTimePicker_fromDate.Value = new DateTime(time.Year, time.Month, 1);
            dateTimePicker_toDate.Value = dateTimePicker_fromDate.Value.AddMonths(1).AddDays(-1); 
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
        }

        private void btn_viewAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btn_viewReceipt_Click(object sender, EventArgs e)
        {
            LoadListReceiptByDate(dateTimePicker_fromDate.Value, dateTimePicker_toDate.Value);
            
        }
    }
}
