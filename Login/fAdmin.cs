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
        //private object dtgvReceipt;
        //private object dtpkToDate;

        public fAdmin()
        {
            InitializeComponent();
            LoadMethods();
        }

        void LoadMethods()
        {
            dataGridView_menu.DataSource = accountList;
            
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
        //Thieu ham lay LoadListRecriptByDate va LoadDateTimePikerReciept
        void AddMenuBinding()
        {
            txtbox_foodName.DataBindings.Add(new Binding("Text",dataGridView_menu.DataSource,"Name", true,DataSourceUpdateMode.Never));
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
            accountList.DataSource = FoodDAO.Instance.GetListFood();
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
            //thieu LoadListByReceiptByDate
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

<<<<<<< Updated upstream
        private void btn_viewReceipt_Click(object sender, EventArgs e)
        {
            LoadListReceiptByDate(dateTimePicker_fromDate.Value, dateTimePicker_toDate.Value);
            
=======
        private void txtbox_foodID_TextChanged(object sender, EventArgs e)
        {
            if(dataGridView_menu.SelectedCells.Count > 0)
            {
                int id = (int)dataGridView_menu.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                Category category = CategoryDAO.Instance.GetCategoryByID(1);
                comboBox_category.SelectedItem = category;
                int index = -1;
                int i = 0;
                foreach (Category item in comboBox_category.Items)
                {
                    if(item.ID == category.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                comboBox_category.SelectedIndex = index;
            }

        }

        private void btn_addMenu_Click(object sender, EventArgs e)
        {
            string name = txtbox_foodName.Text;
            int categoryID = (comboBox_category.SelectedItem as Category).ID;
            float price = (float)numericUpDown_foodPrice.Value;

            if(FoodDAO.Instance.InsertFood(name, categoryID,price))
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
                MessageBox.Show("Sua mon thanh cong");
                LoadListFood();
                if(updateFood != null)
                    updateFood(this,new EventArgs());
            }
            else
            {
                MessageBox.Show("Co loi khi sua mon");
            }
        }

        private void btn_deleteMenu_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtbox_foodID.Text);


            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xoa mon thanh cong");
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this,new EventArgs());
            }
            else
            {
                MessageBox.Show("Co loi khi xoa mon");
            }
>>>>>>> Stashed changes
        }
    }
}