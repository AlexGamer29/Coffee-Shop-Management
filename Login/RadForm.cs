using Login.DataAccessObject;
using Login.DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layout;
using Telerik.WinControls.UI;

namespace Login
{
    public partial class RadForm : Telerik.WinControls.UI.RadForm
    {
        public BindingSource foodList = new BindingSource();
        public BindingSource categoryList = new BindingSource();
        public BindingSource tableList = new BindingSource();
        public BindingSource accountList = new BindingSource();

        private AccountAuthentication loginAccount;
        public AccountAuthentication LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.AccountType); }
        }

        private AccountAuthentication loginProfile;
        public AccountAuthentication LoginProfile
        {
            get { return loginProfile; }
            set { loginProfile = value; LoadProfile(loginProfile); }
        }


        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
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

        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }
        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }
        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }

        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }
        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }
        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }

        public RadForm(AccountAuthentication login)
        {
            InitializeComponent();
            LoadMethods();
            this.LoginAccount = login;
            this.LoginProfile = login;
        }

        private void RadForm_Load(object sender, EventArgs e)
        {
            InsertFood += Dashboard_InsertFood;
            DeleteFood += Dashboard_DeleteFood;
            UpdateFood += Dashboard_UpdateFood;

            InsertTable += Dashboard_InsertTable;
            DeleteTable += Dashboard_DeleteTable;
            UpdateTable += Dashboard_UpdateTable;

            InsertCategory += Dashboard_InsertCategory;
            DeleteCategory += Dashboard_DeleteCategory;
            UpdateCategory += Dashboard_UpdateCategory;
        }
        #region Method
        void LoadMethods()
        {
            GridView_Menu.DataSource = foodList;
            GridView_Category.DataSource = categoryList;
            GridView_Table.DataSource = tableList;
            GridView_Employee.DataSource = accountList;

            //Dashboard PageView
            ControlDashboard dashboard = new ControlDashboard();
            LoadTable();
            dashboard.LoadObjectIntoComboBox(ComboBox_Categories);
            dashboard.LoadComboBoxTable(ComboBox_SwitchTable);

            //Revenue PageView
            ControlRevenue revenue = new ControlRevenue();
            revenue.LoadDateTimePickerReceipt(DateTimePicker_FromDate, DateTimePicker_ToDate);
            revenue.LoadListReceiptByDate(GridView_Receipt, DateTimePicker_FromDate.Value, DateTimePicker_ToDate.Value);
            revenue.TotalRevenueDaily(GridView_Receipt);

            //Menu PageView
            ControlMenu menu = new ControlMenu();
            menu.LoadListObject(foodList);
            menu.LoadObjectIntoComboBox(ComboBox_Category);
            menu.GridView_ElementModifyAttribute(GridView_Menu);
            AddMenuBinding();

            //Category PageView
            ControlCategory category = new ControlCategory();
            category.LoadListObject(categoryList);
            category.GridView_ElementModifyAttribute(GridView_Category);
            AddCategoryBinding();

            //Table PageView
            ControlTable table = new ControlTable();
            table.LoadListObject(tableList);
            table.LoadObjectIntoComboBox(ComboBox_TableStatus);
            table.GridView_ElementModifyAttribute(GridView_Table);
            AddTableBinding();

            //Employee PageView
            EmployeeControl employee = new EmployeeControl();
            employee.LoadListObject(accountList);
            employee.GridView_ElementModifyAttribute(GridView_Employee);
            AddAccountBinding();
        }
        
        #region Profile
        void LoadProfile(AccountAuthentication account)
        {
            TextBox_ProfileUsername.Text = LoginAccount.UserName;
            TextBox_ProfileDisplayname.Text = LoginAccount.DisplayName;
        }

        int CheckCredential(string userName, string password)
        {
            bool credential = fLogin.Login(userName, password);
            return !credential ? 0 : 1;
        }

        void UpdateAccountInfo()
        {
            string userName = TextBox_ProfileUsername.Text;
            string displayName = TextBox_ProfileDisplayname.Text;
            string password = TextBox_ProfilePassword.Text;
            string newPassword = TextBox_ProfileNewPassword.Text;
            string retypeNewPassword = TextBox_ProfileRetypeNewPassword.Text;

            /// Nếu 2 trường mật khẩu mới null thì hash lại trường mật khẩu hiện tại
            /// Ngược lại check 2 trường mật khẩu 
            string hashPassword = "";

            if (!BCrypt.Net.BCrypt.Equals(newPassword, retypeNewPassword))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                int check = CheckCredential(userName, password);
                if (string.IsNullOrEmpty(newPassword) && string.IsNullOrEmpty(retypeNewPassword) && string.IsNullOrWhiteSpace(newPassword) && string.IsNullOrWhiteSpace(retypeNewPassword))
                {
                    if (MessageBox.Show("Bạn có chắc muốn thay đổi userName", "Thay đổi userName", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        hashPassword += BCrypt.Net.BCrypt.HashPassword(password);
                        TextBox_ProfilePassword.Clear();
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
                    TextBox_ProfilePassword.Clear();
                    TextBox_ProfileNewPassword.Clear();
                    TextBox_ProfileRetypeNewPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }

        #endregion

        #region Dashboard

        void LoadTable()
        {
            FlowLayout_ListTable.Controls.Clear();

            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Image = global::Login.Properties.Resources.table_96;
                btn.ImageAlign = ContentAlignment.TopCenter;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Font = new System.Drawing.Font("Source Sans Pro", 9.5F);
                btn.Text = Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine
                    + Environment.NewLine + item.Name + Environment.NewLine + item.TableStatus;
                btn.Click += Btn_Click;
                btn.Tag = item;

                switch (item.TableStatus)
                {
                    case "Trống":
                        btn.BackColor = System.Drawing.ColorTranslator.FromHtml("0xF1F2F7");
                        break;
                    default:
                        btn.BackColor = System.Drawing.ColorTranslator.FromHtml("0xD7533B");
                        break;
                }
                FlowLayout_ListTable.Controls.Add(btn);
            }
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> foodList = FoodDAO.Instance.GetFoodByCategoryID(id);
            ComboBox_Food.DataSource = foodList;
            ComboBox_Food.DisplayMember = "Name";
        }

        void ShowReceipt(int id)
        {
            ListView_Receipt.Items.Clear();
            float totalPriceDisplay = 0;
            List<DataTransferObject.Menu> listReceiptInfo = MenuDAO.Instance.GetListMenuByTable(id);
            foreach (DataTransferObject.Menu item in listReceiptInfo)
            {
                string foodName = item.FoodName.ToString();
                string count = item.Count.ToString();
                string price = Currency.FormatCurrency("VND", (decimal)item.Price);
                string totalPrice = Currency.FormatCurrency("VND", (decimal)item.TotalPrice);

                ListViewDataItem listItem = new ListViewDataItem();
                //ListViewItem listItem = new ListViewItem(item.FoodName.ToString());
                listItem.SubItems.Add(foodName);
                listItem.SubItems.Add(count);
                listItem.SubItems.Add(price);
                listItem.SubItems.Add(totalPrice);
                totalPriceDisplay += item.TotalPrice;
                ListView_Receipt.Items.Add(listItem);

                //ListView_Receipt.Items.A

            }
            TextBox_TotalPrice.Text = Currency.FormatCurrency("VND", (decimal)totalPriceDisplay);
        }

        #endregion

        void ChangeAccount(int accountType)
        {
            PageView_Revenue.Enabled = accountType == 1;
            PageView_Menu.Enabled = accountType == 1;
            PageView_Category.Enabled = accountType == 1;
            PageView_Table.Enabled = accountType == 1;
            PageView_Employee.Enabled = accountType == 1;
        }


        void AddMenuBinding()
        {
            TextBox_FoodName.DataBindings.Add(new Binding("Text", GridView_Menu.DataSource, "Name", true, DataSourceUpdateMode.Never));
            TextBox_IDFood.DataBindings.Add(new Binding("Text", GridView_Menu.DataSource, "ID", true, DataSourceUpdateMode.Never));
            UpDown_Price.DataBindings.Add(new Binding("Text", GridView_Menu.DataSource, "Price", true, DataSourceUpdateMode.Never));
            //DropDownList_Category.DataBindings.Add(new Binding("Text", GridView_Menu.DataSource, "idCategories", true, DataSourceUpdateMode.Never));
        }

        void AddCategoryBinding()
        {
            TextBox_IDCategory.DataBindings.Add(new Binding("Text", GridView_Category.DataSource, "ID", true, DataSourceUpdateMode.Never));
            TextBox_CategoryName.DataBindings.Add(new Binding("Text", GridView_Category.DataSource, "name", true, DataSourceUpdateMode.Never));
        }

        void AddTableBinding()
        {
            TextBox_IDTable.DataBindings.Add(new Binding("Text", GridView_Table.DataSource, "ID", true, DataSourceUpdateMode.Never));
            TextBox_TableName.DataBindings.Add(new Binding("Text", GridView_Table.DataSource, "Name", true, DataSourceUpdateMode.Never));
            ComboBox_TableStatus.DataBindings.Add(new Binding("Text", GridView_Table.DataSource, "tableStatus", true, DataSourceUpdateMode.Never));
        }

        void AddAccountBinding()
        {
            TextBox_Username.DataBindings.Add(new Binding("Text", GridView_Employee.DataSource, "Username", true, DataSourceUpdateMode.Never));
            TextBox_Displayname.DataBindings.Add(new Binding("Text", GridView_Employee.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            UpDown_AccountType.DataBindings.Add(new Binding("Text", GridView_Employee.DataSource, "AccountType", false, DataSourceUpdateMode.Never));
        }

        void AddAccount(string userName, string displayName, int accountType)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, accountType))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            EmployeeControl employee = new EmployeeControl();
            employee.LoadListObject(accountList);
        }

        void DeleteAccount(string userName)
        {
            if (LoginAccount.UserName.Equals(userName))
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
            EmployeeControl employee = new EmployeeControl();
            employee.LoadListObject(accountList);
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
            EmployeeControl employee = new EmployeeControl();
            employee.LoadListObject(accountList);
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

        #endregion

        #region Events

        #region Profile
        private void Button_UpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
        #endregion

        #region Dashboard
        void Btn_Click(object sender, EventArgs e)
        {
            int idTable = ((sender as Button).Tag as Table).ID;
            ListView_Receipt.Tag = (sender as Button).Tag;
            ShowReceipt(idTable);
        }

        private void Button_AddFood_Click(object sender, EventArgs e)
        {
            Table table = ListView_Receipt.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            try
            {
                int idReceipt = ReceiptDAO.Instance.GetUncheckReceiptIDByTableID(table.ID);
                int idFood = (ComboBox_Food.SelectedItem as Food).ID;
                int count = Convert.ToInt32(UpDown_FoodCount.Text.ToString());

                if (idReceipt == -1)
                {
                    ReceiptDAO.Instance.InsertReceipt(table.ID);
                    ReceiptInfoDAO.Instance.InsertReceiptInfo(ReceiptDAO.Instance.GetMaxIDReceipt(), idFood, count);
                }
                else
                {
                    ReceiptInfoDAO.Instance.InsertReceiptInfo(idReceipt, idFood, count);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Danh mục bạn chọn không có món nào để thêm. Vui lòng chọn danh mục khác!");
            }

            ShowReceipt(table.ID);
            LoadTable();
        }

        private void Button_SwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (ListView_Receipt.Tag as Table).ID;
            int id2 = (ComboBox_SwitchTable.SelectedItem as Table).ID;

            TableDAO.Instance.SwitchTable(id1, id2);
            LoadTable();
        }

        private void ComboBox_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox combo = sender as ComboBox;

            if (combo.SelectedItem == null)
                return;

            Category selected = combo.SelectedItem as Category;
            id = selected.ID;
            
            LoadFoodListByCategoryID(id);
        }

        private void Button_CheckOut_Click(object sender, EventArgs e)
        {
            Table table = ListView_Receipt.Tag as Table;

            int idReceipt = ReceiptDAO.Instance.GetUncheckReceiptIDByTableID(table.ID);
            int discount = Convert.ToInt32(UpDown_Discount.Text.ToString());

            decimal totalPrice = Convert.ToDecimal(TextBox_TotalPrice.Text.ToString().Split(' ')[0]);
            decimal finaltotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idReceipt != -1)
            {
                if (MessageBox.Show(String.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\n Tổng tiền" +
                    "Tổng tiền - (Tổng tiền/100) * Giảm giá\n => {1} - ({1}/100) * {2} = {3}", table.Name, totalPrice, discount, finaltotalPrice), "Thông báo ",
                    MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    ReceiptDAO.Instance.CheckOut(idReceipt, discount, (float)finaltotalPrice);
                    ShowReceipt(table.ID);

                    LoadTable();
                }
            }
        }
        #endregion

        #region Revenue
        private void Button_ViewReceipt_Click(object sender, EventArgs e)
        {
            ControlRevenue revenue = new ControlRevenue();
            revenue.LoadListReceiptByDate(GridView_Receipt, DateTimePicker_FromDate.Value, DateTimePicker_ToDate.Value);
        }
        #endregion

        #region Menu
        void Dashboard_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((ComboBox_Categories.SelectedItem as Category).ID);
            if (ListView_Receipt.Tag != null)
                ShowReceipt((ListView_Receipt.Tag as Table).ID);
        }

        void Dashboard_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((ComboBox_Categories.SelectedItem as Category).ID);
            if (ListView_Receipt.Tag != null)
                ShowReceipt((ListView_Receipt.Tag as Table).ID);
        }

        void Dashboard_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((ComboBox_Categories.SelectedItem as Category).ID);
            if (ListView_Receipt.Tag != null)
                ShowReceipt((ListView_Receipt.Tag as Table).ID);
            LoadTable();
        }


        ControlMenu cMenu = new ControlMenu();
        private void Button_Search_Click(object sender, EventArgs e)
        {

            foodList.DataSource = cMenu.SearchFoodByName(TextBox_SearchFoodName.Text);
        }

        private void Button_AddMenu_Click(object sender, EventArgs e)
        {
            string name = TextBox_FoodName.Text;
            int categoryID = (ComboBox_Category.SelectedItem as Category).ID;
            double price = Convert.ToDouble(UpDown_Price.Text.ToString());

            if (FoodDAO.Instance.AddFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                cMenu.LoadListObject(foodList);
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món");
            }
        }

        private void Button_DeleteMenu_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox_IDFood.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                cMenu.LoadListObject(foodList);
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa món");
            }
        }

        private void Button_EditMenu_Click(object sender, EventArgs e)
        {
            string name = TextBox_FoodName.Text;
            int categoryID = (ComboBox_Category.SelectedItem as Category).ID;
            double price = Convert.ToDouble(UpDown_Price.Text.ToString());
            int id = Convert.ToInt32(TextBox_IDFood.Text);

            if (FoodDAO.Instance.UpdateFood(name, categoryID, price, id))
            {
                MessageBox.Show("Sửa món thành công");
                ControlMenu cMenu = new ControlMenu();
                cMenu.LoadListObject(foodList);
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa món");
            }
        }

        private void Button_ViewMenu_Click(object sender, EventArgs e)
        {
            cMenu.LoadListObject(foodList);
        }
        private void TextBox_IDFood_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (GridView_Menu.SelectedRows.Count > 0)
                {
                    int id = (int)GridView_Menu.CurrentRow.Cells["IdCategories"].Value;
                    Category category = CategoryDAO.Instance.GetCategoryByID(id);
                    ComboBox_Category.SelectedItem = category;
                    int index = -1;
                    int i = 0;
                    foreach (Category item in ComboBox_Category.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    ComboBox_Category.SelectedIndex = index;
                }
            }
            catch { }
        }
        #endregion

        #region Category
        void Dashboard_InsertCategory(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((ComboBox_Categories.SelectedItem as Category).ID);
            ControlDashboard cDashboard = new ControlDashboard();
            cDashboard.LoadObjectIntoComboBox(ComboBox_Categories);
            if (ListView_Receipt.Tag != null)
                ShowReceipt((ListView_Receipt.Tag as Table).ID);
        }

        void Dashboard_DeleteCategory(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((ComboBox_Categories.SelectedItem as Category).ID);
            ControlDashboard cDashboard = new ControlDashboard();
            cDashboard.LoadObjectIntoComboBox(ComboBox_Categories);
            if (ListView_Receipt.Tag != null)
                ShowReceipt((ListView_Receipt.Tag as Table).ID);
        }

        void Dashboard_UpdateCategory(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((ComboBox_Categories.SelectedItem as Category).ID);
            ControlDashboard cDashboard = new ControlDashboard();
            cDashboard.LoadObjectIntoComboBox(ComboBox_Categories);
            if (ListView_Receipt.Tag != null)
                ShowReceipt((ListView_Receipt.Tag as Table).ID);
            LoadTable();
        }

        ControlCategory cCategory = new ControlCategory();
        private void Button_AddCategory_Click(object sender, EventArgs e)
        {
            string name = TextBox_CategoryName.Text;

            if (CategoryDAO.Instance.AddCategory(name))
            {
                MessageBox.Show("Thêm danh mục thành công");
                cCategory.LoadListObject(categoryList);
                if (insertCategory != null)
                    insertCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm danh mục thất bại");
            }
        }

        private void Button_EditCategory_Click(object sender, EventArgs e)
        {
            string name = TextBox_CategoryName.Text;
            int idCategory = Convert.ToInt32(TextBox_IDCategory.Text);

            if (CategoryDAO.Instance.UpdateCategory(name, idCategory))
            {
                MessageBox.Show("Sửa danh mục thành công");
                cCategory.LoadListObject(categoryList);
                if (updateCategory != null)
                    updateCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Sửa danh mục thất bại");
            }
        }

        private void Button_DeleteCategory_Click(object sender, EventArgs e)
        {
            int idCategory = Convert.ToInt32(TextBox_IDCategory.Text);

            //try
            //{

            //}
            //catch (System.Data.SqlClient.SqlException)
            //{

            //    MessageBox.Show("Bạn không thể xóa danh mục này");
            //}

            if (CategoryDAO.Instance.DeleteCategory(idCategory))
            {
                MessageBox.Show("Xóa danh mục thành công");
                cCategory.LoadListObject(categoryList);
                if (deleteCategory != null)
                    deleteCategory(this, new EventArgs());
            }
        }

        private void Button_ViewCategory_Click(object sender, EventArgs e)
        {
            cCategory.LoadListObject(categoryList);
        }
        #endregion

        #region Table
        void Dashboard_InsertTable(object sender, EventArgs e)
        {
            if (ListView_Receipt.Tag != null)
                ShowReceipt((ListView_Receipt.Tag as Table).ID);
            LoadTable();
        }

        void Dashboard_UpdateTable(object sender, EventArgs e)
        {
            if (ListView_Receipt.Tag != null)
                ShowReceipt((ListView_Receipt.Tag as Table).ID);
            LoadTable();
        }

        void Dashboard_DeleteTable(object sender, EventArgs e)
        {
            if (ListView_Receipt.Tag != null)
                ShowReceipt((ListView_Receipt.Tag as Table).ID);
            LoadTable();
        }

        ControlTable cTable = new ControlTable();
        private void Button_AddTable_Click(object sender, EventArgs e)
        {
            string tableName = TextBox_TableName.Text;
            string tableStatus = ComboBox_TableStatus.Text;


            if (TableDAO.Instance.AddTable(tableName, tableStatus))
            {
                MessageBox.Show("Thêm bàn thành công");
                cTable.LoadListObject(tableList);
                if (insertTable != null)
                    insertTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại");
            }
        }

        private void Button_EditTable_Click(object sender, EventArgs e)
        {
            string tableName = TextBox_TableName.Text;
            string tableStatus = ComboBox_TableStatus.Text;
            int idTable = Convert.ToInt32(TextBox_IDTable.Text);

            if (TableDAO.Instance.UpdateTable(tableName, tableStatus, idTable))
            {
                MessageBox.Show("Sửa bàn thành công");
                cTable.LoadListObject(tableList);
                if (updateTable != null)
                    updateTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Sửa bàn thất bại");
            }
        }

        private void Button_DeleteTable_Click(object sender, EventArgs e)
        {
            int idTable = Convert.ToInt32(TextBox_IDTable.Text);

            try
            {
                if (TableDAO.Instance.DeleteTable(idTable))
                {
                    MessageBox.Show("Xóa bàn thành công");
                    cTable.LoadListObject(tableList);
                    if (deleteTable != null)
                        deleteTable(this, new EventArgs());
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {

                MessageBox.Show("Bạn không thể xóa bàn này");
            }
        }

        private void Button_ViewTable_Click(object sender, EventArgs e)
        {
            cTable.LoadListObject(tableList);
        }
        #endregion

        #region Employee
        private void TextBox_Username_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (GridView_Employee.SelectedRows.Count > 0)
                {
                    int accountType = (int)GridView_Employee.CurrentRow.Cells["AccountType"].Value;
                    UpDown_AccountType.Value = accountType;
                }
            }
            catch { }
        }

        private void Button_AddAccount_Click(object sender, EventArgs e)
        {
            string userName = TextBox_Username.Text;
            string displayName = TextBox_Displayname.Text;
            int accountType = Convert.ToInt32(UpDown_AccountType.Text.ToString());

            AddAccount(userName, displayName, accountType);
        }

        private void Button_DeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = TextBox_Username.Text;

            DeleteAccount(userName);
        }

        private void Button_EditAccount_Click(object sender, EventArgs e)
        {
            string userName = TextBox_Username.Text;
            string displayName = TextBox_Displayname.Text;
            int accountType = Convert.ToInt32(UpDown_AccountType.Text.ToString());
            
            EditAccount(userName, displayName, accountType);
        }

        private void Button_ViewAccount_Click(object sender, EventArgs e)
        {
            EmployeeControl employee = new EmployeeControl();
            employee.LoadListObject(accountList);
        }
        private void Button_ResetPassword_Click(object sender, EventArgs e)
        {
            string userName = TextBox_Username.Text;

            ResetPassword(userName);
        }


        #endregion

        #endregion
    }
}
