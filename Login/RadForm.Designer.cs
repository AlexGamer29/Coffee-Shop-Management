namespace Login
{
    partial class RadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Tên món");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Số lượng");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Đơn giá");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Thành tiền");
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition5 = new Telerik.WinControls.UI.TableViewDefinition();
            this.USP_GetListBillByDateForReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopDataSet21 = new Login.CoffeeShopDataSet21();
            this.uSERPROCGetListReceiptByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_GetListBillByDateForReportTableAdapter = new Login.CoffeeShopDataSet21TableAdapters.USP_GetListBillByDateForReportTableAdapter();
            this.uSERPROC_GetListReceiptByDateTableAdapter = new Login.CoffeeShopDataSet21TableAdapters.USERPROC_GetListReceiptByDateTableAdapter();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.PageView_Dashboard = new Telerik.WinControls.UI.RadPageViewPage();
            this.Panel_ListTable = new Telerik.WinControls.UI.RadPanel();
            this.FlowLayout_ListTable = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_FunctionDashboard = new Telerik.WinControls.UI.RadPanel();
            this.UpDown_Discount = new Telerik.WinControls.UI.RadSpinEditor();
            this.Label_TotalPrice = new Telerik.WinControls.UI.RadLabel();
            this.Label_Discount = new Telerik.WinControls.UI.RadLabel();
            this.Button_SwitchTable = new Telerik.WinControls.UI.RadButton();
            this.Button_CheckOut = new Telerik.WinControls.UI.RadButton();
            this.TextBox_TotalPrice = new Telerik.WinControls.UI.RadTextBox();
            this.ComboBox_SwitchTable = new System.Windows.Forms.ComboBox();
            this.Panel_ListViewDashboard = new Telerik.WinControls.UI.RadPanel();
            this.ListView_Receipt = new Telerik.WinControls.UI.RadListView();
            this.PanelOperation_Dashboard = new Telerik.WinControls.UI.RadPanel();
            this.UpDown_FoodCount = new Telerik.WinControls.UI.RadSpinEditor();
            this.Button_AddFood = new Telerik.WinControls.UI.RadButton();
            this.ComboBox_Food = new System.Windows.Forms.ComboBox();
            this.ComboBox_Categories = new System.Windows.Forms.ComboBox();
            this.PageView_Account = new Telerik.WinControls.UI.RadPageViewPage();
            this.ViewPage_PersonalInfo = new Telerik.WinControls.UI.RadPageViewPage();
            this.TextBox_ProfileNewPassword = new Telerik.WinControls.UI.RadTextBox();
            this.TextBox_ProfileUsername = new Telerik.WinControls.UI.RadTextBox();
            this.TextBox_ProfileRetypeNewPassword = new Telerik.WinControls.UI.RadTextBox();
            this.Label_Profile = new Telerik.WinControls.UI.RadLabel();
            this.TextBox_ProfileDisplayname = new Telerik.WinControls.UI.RadTextBox();
            this.Button_UpdateProfile = new Telerik.WinControls.UI.RadButton();
            this.TextBox_ProfilePassword = new Telerik.WinControls.UI.RadTextBox();
            this.PageView_Management = new Telerik.WinControls.UI.RadPageViewPage();
            this.PageView_Revenue = new Telerik.WinControls.UI.RadPageViewPage();
            this.Panel_GridViewReceipt = new Telerik.WinControls.UI.RadPanel();
            this.GridView_Receipt = new Telerik.WinControls.UI.RadGridView();
            this.PanelOperation_Revenue = new Telerik.WinControls.UI.RadPanel();
            this.Button_ViewReceipt = new Telerik.WinControls.UI.RadButton();
            this.DateTimePicker_ToDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.DateTimePicker_FromDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.PageView_Menu = new Telerik.WinControls.UI.RadPageViewPage();
            this.Panel_MenuBinding = new Telerik.WinControls.UI.RadPanel();
            this.UpDown_Price = new Telerik.WinControls.UI.RadSpinEditor();
            this.ComboBox_Category = new System.Windows.Forms.ComboBox();
            this.TextBox_IDFood = new Telerik.WinControls.UI.RadTextBox();
            this.Label_FoodName = new Telerik.WinControls.UI.RadLabel();
            this.Label_Category = new Telerik.WinControls.UI.RadLabel();
            this.TextBox_FoodName = new Telerik.WinControls.UI.RadTextBox();
            this.Label_Price = new Telerik.WinControls.UI.RadLabel();
            this.Label_IDFood = new Telerik.WinControls.UI.RadLabel();
            this.Panel_GridViewMenu = new Telerik.WinControls.UI.RadPanel();
            this.GridView_Menu = new Telerik.WinControls.UI.RadGridView();
            this.Panel_SearchMenu = new Telerik.WinControls.UI.RadPanel();
            this.TextBox_SearchFoodName = new Telerik.WinControls.UI.RadTextBox();
            this.Button_Search = new Telerik.WinControls.UI.RadButton();
            this.PanelOperation_Menu = new Telerik.WinControls.UI.RadPanel();
            this.Button_DeleteMenu = new Telerik.WinControls.UI.RadButton();
            this.Button_EditMenu = new Telerik.WinControls.UI.RadButton();
            this.Button_ViewMenu = new Telerik.WinControls.UI.RadButton();
            this.Button_AddMenu = new Telerik.WinControls.UI.RadButton();
            this.PageView_Category = new Telerik.WinControls.UI.RadPageViewPage();
            this.PanelOperation_Category = new Telerik.WinControls.UI.RadPanel();
            this.Button_DeleteCategory = new Telerik.WinControls.UI.RadButton();
            this.Button_EditCategory = new Telerik.WinControls.UI.RadButton();
            this.Button_ViewCategory = new Telerik.WinControls.UI.RadButton();
            this.Button_AddCategory = new Telerik.WinControls.UI.RadButton();
            this.Panel_CategoryBinding = new Telerik.WinControls.UI.RadPanel();
            this.TextBox_IDCategory = new Telerik.WinControls.UI.RadTextBox();
            this.Label_CategoryName = new Telerik.WinControls.UI.RadLabel();
            this.TextBox_CategoryName = new Telerik.WinControls.UI.RadTextBox();
            this.Label_IDCategory = new Telerik.WinControls.UI.RadLabel();
            this.Panel_GridViewCategory = new Telerik.WinControls.UI.RadPanel();
            this.GridView_Category = new Telerik.WinControls.UI.RadGridView();
            this.PageView_Table = new Telerik.WinControls.UI.RadPageViewPage();
            this.PanelOperation_Table = new Telerik.WinControls.UI.RadPanel();
            this.Button_DeleteTable = new Telerik.WinControls.UI.RadButton();
            this.Button_EditTable = new Telerik.WinControls.UI.RadButton();
            this.Button_ViewTable = new Telerik.WinControls.UI.RadButton();
            this.Button_AddTable = new Telerik.WinControls.UI.RadButton();
            this.Panel_TableBinding = new Telerik.WinControls.UI.RadPanel();
            this.ComboBox_TableStatus = new System.Windows.Forms.ComboBox();
            this.TextBox_IDTable = new Telerik.WinControls.UI.RadTextBox();
            this.Label_TableName = new Telerik.WinControls.UI.RadLabel();
            this.Label_TableStatus = new Telerik.WinControls.UI.RadLabel();
            this.TextBox_TableName = new Telerik.WinControls.UI.RadTextBox();
            this.Label_IDTable = new Telerik.WinControls.UI.RadLabel();
            this.Panel_GridViewTable = new Telerik.WinControls.UI.RadPanel();
            this.GridView_Table = new Telerik.WinControls.UI.RadGridView();
            this.PageView_Employee = new Telerik.WinControls.UI.RadPageViewPage();
            this.PanelOperation_Employee = new Telerik.WinControls.UI.RadPanel();
            this.Button_ViewAccount = new Telerik.WinControls.UI.RadButton();
            this.Button_EditAccount = new Telerik.WinControls.UI.RadButton();
            this.Button_DeleteAccount = new Telerik.WinControls.UI.RadButton();
            this.Button_AddAccount = new Telerik.WinControls.UI.RadButton();
            this.Panel_EmployeeBinding = new Telerik.WinControls.UI.RadPanel();
            this.UpDown_AccountType = new Telerik.WinControls.UI.RadSpinEditor();
            this.Button_ResetPassword = new Telerik.WinControls.UI.RadButton();
            this.Label_AccountType = new Telerik.WinControls.UI.RadLabel();
            this.TextBox_Displayname = new Telerik.WinControls.UI.RadTextBox();
            this.Label_Displayname = new Telerik.WinControls.UI.RadLabel();
            this.TextBox_Username = new Telerik.WinControls.UI.RadTextBox();
            this.Label_Username = new Telerik.WinControls.UI.RadLabel();
            this.Panel_GridViewEmployee = new Telerik.WinControls.UI.RadPanel();
            this.GridView_Employee = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateForReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERPROCGetListReceiptByDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.PageView_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_ListTable)).BeginInit();
            this.Panel_ListTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_FunctionDashboard)).BeginInit();
            this.Panel_FunctionDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_TotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_Discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_SwitchTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_CheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_TotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_ListViewDashboard)).BeginInit();
            this.Panel_ListViewDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListView_Receipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelOperation_Dashboard)).BeginInit();
            this.PanelOperation_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_FoodCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddFood)).BeginInit();
            this.ViewPage_PersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_ProfileNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_ProfileUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_ProfileRetypeNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_Profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_ProfileDisplayname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_UpdateProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_ProfilePassword)).BeginInit();
            this.PageView_Revenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_GridViewReceipt)).BeginInit();
            this.Panel_GridViewReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Receipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Receipt.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelOperation_Revenue)).BeginInit();
            this.PanelOperation_Revenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ViewReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimePicker_ToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimePicker_FromDate)).BeginInit();
            this.PageView_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_MenuBinding)).BeginInit();
            this.Panel_MenuBinding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_IDFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_FoodName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_FoodName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_IDFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_GridViewMenu)).BeginInit();
            this.Panel_GridViewMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Menu.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_SearchMenu)).BeginInit();
            this.Panel_SearchMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_SearchFoodName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelOperation_Menu)).BeginInit();
            this.PanelOperation_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_DeleteMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_EditMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddMenu)).BeginInit();
            this.PageView_Category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelOperation_Category)).BeginInit();
            this.PanelOperation_Category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_DeleteCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_EditCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ViewCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_CategoryBinding)).BeginInit();
            this.Panel_CategoryBinding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_IDCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_CategoryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_CategoryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_IDCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_GridViewCategory)).BeginInit();
            this.Panel_GridViewCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Category.MasterTemplate)).BeginInit();
            this.PageView_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelOperation_Table)).BeginInit();
            this.PanelOperation_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_DeleteTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_EditTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ViewTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_TableBinding)).BeginInit();
            this.Panel_TableBinding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_IDTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_TableName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_TableStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_TableName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_IDTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_GridViewTable)).BeginInit();
            this.Panel_GridViewTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Table.MasterTemplate)).BeginInit();
            this.PageView_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelOperation_Employee)).BeginInit();
            this.PanelOperation_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ViewAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_EditAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_DeleteAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_EmployeeBinding)).BeginInit();
            this.Panel_EmployeeBinding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_AccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ResetPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_AccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_Displayname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_Displayname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_GridViewEmployee)).BeginInit();
            this.Panel_GridViewEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Employee.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // USP_GetListBillByDateForReportBindingSource
            // 
            this.USP_GetListBillByDateForReportBindingSource.DataMember = "USP_GetListBillByDateForReport";
            this.USP_GetListBillByDateForReportBindingSource.DataSource = this.coffeeShopDataSet21;
            // 
            // coffeeShopDataSet21
            // 
            this.coffeeShopDataSet21.DataSetName = "DataSet21";
            this.coffeeShopDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERPROCGetListReceiptByDateBindingSource
            // 
            this.uSERPROCGetListReceiptByDateBindingSource.DataMember = "USERPROC_GetListReceiptByDate";
            this.uSERPROCGetListReceiptByDateBindingSource.DataSource = this.coffeeShopDataSet21;
            // 
            // USP_GetListBillByDateForReportTableAdapter
            // 
            this.USP_GetListBillByDateForReportTableAdapter.ClearBeforeFill = true;
            // 
            // uSERPROC_GetListReceiptByDateTableAdapter
            // 
            this.uSERPROC_GetListReceiptByDateTableAdapter.ClearBeforeFill = true;
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.PageView_Dashboard);
            this.radPageView1.Controls.Add(this.PageView_Account);
            this.radPageView1.Controls.Add(this.ViewPage_PersonalInfo);
            this.radPageView1.Controls.Add(this.PageView_Management);
            this.radPageView1.Controls.Add(this.PageView_Revenue);
            this.radPageView1.Controls.Add(this.PageView_Menu);
            this.radPageView1.Controls.Add(this.PageView_Category);
            this.radPageView1.Controls.Add(this.PageView_Table);
            this.radPageView1.Controls.Add(this.PageView_Employee);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Font = new System.Drawing.Font("Source Sans Pro Light", 11F);
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.PageView_Dashboard;
            this.radPageView1.Size = new System.Drawing.Size(1100, 659);
            this.radPageView1.TabIndex = 0;
            this.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.NavigationView;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).HeaderHeight = 35;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).ExpandedPaneWidth = 235;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.radPageView1.GetChildAt(0))).CollapsedPaneWidth = 30;
            // 
            // PageView_Dashboard
            // 
            this.PageView_Dashboard.Controls.Add(this.Panel_ListTable);
            this.PageView_Dashboard.Controls.Add(this.Panel_FunctionDashboard);
            this.PageView_Dashboard.Controls.Add(this.Panel_ListViewDashboard);
            this.PageView_Dashboard.Controls.Add(this.PanelOperation_Dashboard);
            this.PageView_Dashboard.Image = global::Login.Properties.Resources.dashboard;
            this.PageView_Dashboard.ItemSize = new System.Drawing.SizeF(175F, 41F);
            this.PageView_Dashboard.Location = new System.Drawing.Point(236, 36);
            this.PageView_Dashboard.Name = "PageView_Dashboard";
            this.PageView_Dashboard.Size = new System.Drawing.Size(863, 622);
            this.PageView_Dashboard.Text = "Dashboard";
            // 
            // Panel_ListTable
            // 
            this.Panel_ListTable.Controls.Add(this.FlowLayout_ListTable);
            this.Panel_ListTable.Location = new System.Drawing.Point(3, 3);
            this.Panel_ListTable.Name = "Panel_ListTable";
            this.Panel_ListTable.Size = new System.Drawing.Size(461, 616);
            this.Panel_ListTable.TabIndex = 4;
            // 
            // FlowLayout_ListTable
            // 
            this.FlowLayout_ListTable.AutoScroll = true;
            this.FlowLayout_ListTable.Location = new System.Drawing.Point(3, 3);
            this.FlowLayout_ListTable.Name = "FlowLayout_ListTable";
            this.FlowLayout_ListTable.Size = new System.Drawing.Size(455, 610);
            this.FlowLayout_ListTable.TabIndex = 0;
            // 
            // Panel_FunctionDashboard
            // 
            this.Panel_FunctionDashboard.Controls.Add(this.UpDown_Discount);
            this.Panel_FunctionDashboard.Controls.Add(this.Label_TotalPrice);
            this.Panel_FunctionDashboard.Controls.Add(this.Label_Discount);
            this.Panel_FunctionDashboard.Controls.Add(this.Button_SwitchTable);
            this.Panel_FunctionDashboard.Controls.Add(this.Button_CheckOut);
            this.Panel_FunctionDashboard.Controls.Add(this.TextBox_TotalPrice);
            this.Panel_FunctionDashboard.Controls.Add(this.ComboBox_SwitchTable);
            this.Panel_FunctionDashboard.Location = new System.Drawing.Point(470, 562);
            this.Panel_FunctionDashboard.Name = "Panel_FunctionDashboard";
            this.Panel_FunctionDashboard.Size = new System.Drawing.Size(393, 57);
            this.Panel_FunctionDashboard.TabIndex = 3;
            // 
            // UpDown_Discount
            // 
            this.UpDown_Discount.Location = new System.Drawing.Point(106, 30);
            this.UpDown_Discount.Name = "UpDown_Discount";
            this.UpDown_Discount.Size = new System.Drawing.Size(52, 24);
            this.UpDown_Discount.TabIndex = 2;
            // 
            // Label_TotalPrice
            // 
            this.Label_TotalPrice.Font = new System.Drawing.Font("Source Sans Pro", 9.5F);
            this.Label_TotalPrice.Location = new System.Drawing.Point(197, 5);
            this.Label_TotalPrice.Name = "Label_TotalPrice";
            this.Label_TotalPrice.Size = new System.Drawing.Size(58, 20);
            this.Label_TotalPrice.TabIndex = 9;
            this.Label_TotalPrice.Text = "Tổng tiền";
            // 
            // Label_Discount
            // 
            this.Label_Discount.Font = new System.Drawing.Font("Source Sans Pro", 9.5F);
            this.Label_Discount.Location = new System.Drawing.Point(105, 5);
            this.Label_Discount.Name = "Label_Discount";
            this.Label_Discount.Size = new System.Drawing.Size(54, 20);
            this.Label_Discount.TabIndex = 8;
            this.Label_Discount.Text = "Giảm giá";
            // 
            // Button_SwitchTable
            // 
            this.Button_SwitchTable.Font = new System.Drawing.Font("Source Sans Pro", 11F);
            this.Button_SwitchTable.Location = new System.Drawing.Point(3, 3);
            this.Button_SwitchTable.Name = "Button_SwitchTable";
            this.Button_SwitchTable.Size = new System.Drawing.Size(97, 24);
            this.Button_SwitchTable.TabIndex = 6;
            this.Button_SwitchTable.Text = "Chuyển bàn";
            this.Button_SwitchTable.Click += new System.EventHandler(this.Button_SwitchTable_Click);
            // 
            // Button_CheckOut
            // 
            this.Button_CheckOut.Font = new System.Drawing.Font("Source Sans Pro", 11F);
            this.Button_CheckOut.Location = new System.Drawing.Point(304, 3);
            this.Button_CheckOut.Name = "Button_CheckOut";
            this.Button_CheckOut.Size = new System.Drawing.Size(86, 51);
            this.Button_CheckOut.TabIndex = 5;
            this.Button_CheckOut.Text = "Thanh toán";
            this.Button_CheckOut.Click += new System.EventHandler(this.Button_CheckOut_Click);
            // 
            // TextBox_TotalPrice
            // 
            this.TextBox_TotalPrice.Location = new System.Drawing.Point(164, 30);
            this.TextBox_TotalPrice.Name = "TextBox_TotalPrice";
            this.TextBox_TotalPrice.Size = new System.Drawing.Size(134, 24);
            this.TextBox_TotalPrice.TabIndex = 7;
            // 
            // ComboBox_SwitchTable
            // 
            this.ComboBox_SwitchTable.FormattingEnabled = true;
            this.ComboBox_SwitchTable.Location = new System.Drawing.Point(3, 33);
            this.ComboBox_SwitchTable.Name = "ComboBox_SwitchTable";
            this.ComboBox_SwitchTable.Size = new System.Drawing.Size(97, 21);
            this.ComboBox_SwitchTable.TabIndex = 5;
            // 
            // Panel_ListViewDashboard
            // 
            this.Panel_ListViewDashboard.Controls.Add(this.ListView_Receipt);
            this.Panel_ListViewDashboard.Location = new System.Drawing.Point(470, 69);
            this.Panel_ListViewDashboard.Name = "Panel_ListViewDashboard";
            this.Panel_ListViewDashboard.Size = new System.Drawing.Size(393, 490);
            this.Panel_ListViewDashboard.TabIndex = 2;
            // 
            // ListView_Receipt
            // 
            this.ListView_Receipt.AutoScroll = true;
            this.ListView_Receipt.AutoSizeColumnsMode = Telerik.WinControls.UI.ListViewAutoSizeColumnsMode.Fill;
            listViewDetailColumn1.HeaderText = "Tên món";
            listViewDetailColumn1.Width = 105.476F;
            listViewDetailColumn2.HeaderText = "Số lượng";
            listViewDetailColumn2.Width = 105.476F;
            listViewDetailColumn3.HeaderText = "Đơn giá";
            listViewDetailColumn3.Width = 104.496F;
            listViewDetailColumn4.HeaderText = "Thành tiền";
            listViewDetailColumn4.Width = 78.55206F;
            this.ListView_Receipt.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4});
            this.ListView_Receipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView_Receipt.GroupItemSize = new System.Drawing.Size(200, 28);
            this.ListView_Receipt.ItemSize = new System.Drawing.Size(200, 28);
            this.ListView_Receipt.ItemSpacing = -1;
            this.ListView_Receipt.Location = new System.Drawing.Point(0, 0);
            this.ListView_Receipt.Name = "ListView_Receipt";
            this.ListView_Receipt.Size = new System.Drawing.Size(393, 490);
            this.ListView_Receipt.TabIndex = 0;
            this.ListView_Receipt.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // PanelOperation_Dashboard
            // 
            this.PanelOperation_Dashboard.Controls.Add(this.UpDown_FoodCount);
            this.PanelOperation_Dashboard.Controls.Add(this.Button_AddFood);
            this.PanelOperation_Dashboard.Controls.Add(this.ComboBox_Food);
            this.PanelOperation_Dashboard.Controls.Add(this.ComboBox_Categories);
            this.PanelOperation_Dashboard.Location = new System.Drawing.Point(470, 3);
            this.PanelOperation_Dashboard.Name = "PanelOperation_Dashboard";
            this.PanelOperation_Dashboard.Size = new System.Drawing.Size(393, 57);
            this.PanelOperation_Dashboard.TabIndex = 1;
            // 
            // UpDown_FoodCount
            // 
            this.UpDown_FoodCount.Location = new System.Drawing.Point(203, 30);
            this.UpDown_FoodCount.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.UpDown_FoodCount.Name = "UpDown_FoodCount";
            this.UpDown_FoodCount.NullableValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDown_FoodCount.Size = new System.Drawing.Size(187, 24);
            this.UpDown_FoodCount.TabIndex = 1;
            this.UpDown_FoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Button_AddFood
            // 
            this.Button_AddFood.Font = new System.Drawing.Font("Source Sans Pro", 11F);
            this.Button_AddFood.Image = global::Login.Properties.Resources.add;
            this.Button_AddFood.Location = new System.Drawing.Point(3, 30);
            this.Button_AddFood.Name = "Button_AddFood";
            this.Button_AddFood.Size = new System.Drawing.Size(187, 24);
            this.Button_AddFood.TabIndex = 4;
            this.Button_AddFood.Text = "Thêm món";
            this.Button_AddFood.Click += new System.EventHandler(this.Button_AddFood_Click);
            // 
            // ComboBox_Food
            // 
            this.ComboBox_Food.FormattingEnabled = true;
            this.ComboBox_Food.Location = new System.Drawing.Point(203, 3);
            this.ComboBox_Food.Name = "ComboBox_Food";
            this.ComboBox_Food.Size = new System.Drawing.Size(187, 21);
            this.ComboBox_Food.TabIndex = 1;
            // 
            // ComboBox_Categories
            // 
            this.ComboBox_Categories.FormattingEnabled = true;
            this.ComboBox_Categories.Location = new System.Drawing.Point(3, 3);
            this.ComboBox_Categories.Name = "ComboBox_Categories";
            this.ComboBox_Categories.Size = new System.Drawing.Size(187, 21);
            this.ComboBox_Categories.TabIndex = 0;
            this.ComboBox_Categories.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Categories_SelectedIndexChanged);
            // 
            // PageView_Account
            // 
            this.PageView_Account.Image = global::Login.Properties.Resources.account;
            this.PageView_Account.ItemSize = new System.Drawing.SizeF(175F, 41F);
            this.PageView_Account.Location = new System.Drawing.Point(236, 36);
            this.PageView_Account.Name = "PageView_Account";
            this.PageView_Account.Size = new System.Drawing.Size(863, 622);
            this.PageView_Account.SubPages.Add(this.ViewPage_PersonalInfo);
            this.PageView_Account.Text = "Account";
            // 
            // ViewPage_PersonalInfo
            // 
            this.ViewPage_PersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(164)))));
            this.ViewPage_PersonalInfo.Controls.Add(this.TextBox_ProfileNewPassword);
            this.ViewPage_PersonalInfo.Controls.Add(this.TextBox_ProfileUsername);
            this.ViewPage_PersonalInfo.Controls.Add(this.TextBox_ProfileRetypeNewPassword);
            this.ViewPage_PersonalInfo.Controls.Add(this.Label_Profile);
            this.ViewPage_PersonalInfo.Controls.Add(this.TextBox_ProfileDisplayname);
            this.ViewPage_PersonalInfo.Controls.Add(this.Button_UpdateProfile);
            this.ViewPage_PersonalInfo.Controls.Add(this.TextBox_ProfilePassword);
            this.ViewPage_PersonalInfo.Image = global::Login.Properties.Resources.personal_info;
            this.ViewPage_PersonalInfo.ItemSize = new System.Drawing.SizeF(175F, 41F);
            this.ViewPage_PersonalInfo.Location = new System.Drawing.Point(236, 36);
            this.ViewPage_PersonalInfo.Name = "ViewPage_PersonalInfo";
            this.ViewPage_PersonalInfo.Size = new System.Drawing.Size(863, 622);
            this.ViewPage_PersonalInfo.Text = "Personal Information";
            // 
            // TextBox_ProfileNewPassword
            // 
            this.TextBox_ProfileNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.TextBox_ProfileNewPassword.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.TextBox_ProfileNewPassword.ForeColor = System.Drawing.Color.White;
            this.TextBox_ProfileNewPassword.Location = new System.Drawing.Point(297, 223);
            this.TextBox_ProfileNewPassword.Name = "TextBox_ProfileNewPassword";
            this.TextBox_ProfileNewPassword.NullText = "Mật khẩu mới";
            this.TextBox_ProfileNewPassword.PasswordChar = '●';
            this.TextBox_ProfileNewPassword.Size = new System.Drawing.Size(254, 30);
            this.TextBox_ProfileNewPassword.TabIndex = 4;
            this.TextBox_ProfileNewPassword.UseGenericBorderPaint = true;
            this.TextBox_ProfileNewPassword.UseSystemPasswordChar = true;
            // 
            // TextBox_ProfileUsername
            // 
            this.TextBox_ProfileUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.TextBox_ProfileUsername.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.TextBox_ProfileUsername.ForeColor = System.Drawing.Color.White;
            this.TextBox_ProfileUsername.Location = new System.Drawing.Point(297, 100);
            this.TextBox_ProfileUsername.Name = "TextBox_ProfileUsername";
            this.TextBox_ProfileUsername.NullText = "Tên đăng nhập";
            this.TextBox_ProfileUsername.ReadOnly = true;
            this.TextBox_ProfileUsername.Size = new System.Drawing.Size(254, 30);
            this.TextBox_ProfileUsername.TabIndex = 1;
            this.TextBox_ProfileUsername.UseGenericBorderPaint = true;
            // 
            // TextBox_ProfileRetypeNewPassword
            // 
            this.TextBox_ProfileRetypeNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.TextBox_ProfileRetypeNewPassword.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.TextBox_ProfileRetypeNewPassword.ForeColor = System.Drawing.Color.White;
            this.TextBox_ProfileRetypeNewPassword.Location = new System.Drawing.Point(297, 264);
            this.TextBox_ProfileRetypeNewPassword.Name = "TextBox_ProfileRetypeNewPassword";
            this.TextBox_ProfileRetypeNewPassword.NullText = "Nhập lại mật khẩu mới";
            this.TextBox_ProfileRetypeNewPassword.PasswordChar = '●';
            this.TextBox_ProfileRetypeNewPassword.Size = new System.Drawing.Size(254, 30);
            this.TextBox_ProfileRetypeNewPassword.TabIndex = 5;
            this.TextBox_ProfileRetypeNewPassword.UseGenericBorderPaint = true;
            this.TextBox_ProfileRetypeNewPassword.UseSystemPasswordChar = true;
            // 
            // Label_Profile
            // 
            this.Label_Profile.Font = new System.Drawing.Font("Source Sans Pro", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label_Profile.ForeColor = System.Drawing.Color.White;
            this.Label_Profile.Location = new System.Drawing.Point(268, 28);
            this.Label_Profile.Name = "Label_Profile";
            this.Label_Profile.Size = new System.Drawing.Size(317, 54);
            this.Label_Profile.TabIndex = 0;
            this.Label_Profile.Text = "Thông tin cá nhân";
            // 
            // TextBox_ProfileDisplayname
            // 
            this.TextBox_ProfileDisplayname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.TextBox_ProfileDisplayname.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.TextBox_ProfileDisplayname.ForeColor = System.Drawing.Color.White;
            this.TextBox_ProfileDisplayname.Location = new System.Drawing.Point(297, 141);
            this.TextBox_ProfileDisplayname.Name = "TextBox_ProfileDisplayname";
            this.TextBox_ProfileDisplayname.NullText = "Họ và tên";
            this.TextBox_ProfileDisplayname.Size = new System.Drawing.Size(254, 30);
            this.TextBox_ProfileDisplayname.TabIndex = 2;
            this.TextBox_ProfileDisplayname.UseGenericBorderPaint = true;
            // 
            // Button_UpdateProfile
            // 
            this.Button_UpdateProfile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_UpdateProfile.Image = global::Login.Properties.Resources.reset;
            this.Button_UpdateProfile.Location = new System.Drawing.Point(442, 314);
            this.Button_UpdateProfile.Name = "Button_UpdateProfile";
            this.Button_UpdateProfile.Size = new System.Drawing.Size(109, 28);
            this.Button_UpdateProfile.TabIndex = 6;
            this.Button_UpdateProfile.Text = "Cập nhật";
            this.Button_UpdateProfile.Click += new System.EventHandler(this.Button_UpdateProfile_Click);
            // 
            // TextBox_ProfilePassword
            // 
            this.TextBox_ProfilePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.TextBox_ProfilePassword.Font = new System.Drawing.Font("Source Sans Pro", 11.25F);
            this.TextBox_ProfilePassword.ForeColor = System.Drawing.Color.White;
            this.TextBox_ProfilePassword.Location = new System.Drawing.Point(297, 182);
            this.TextBox_ProfilePassword.Name = "TextBox_ProfilePassword";
            this.TextBox_ProfilePassword.NullText = "Mật khẩu cũ";
            this.TextBox_ProfilePassword.PasswordChar = '●';
            this.TextBox_ProfilePassword.Size = new System.Drawing.Size(254, 30);
            this.TextBox_ProfilePassword.TabIndex = 3;
            this.TextBox_ProfilePassword.UseGenericBorderPaint = true;
            this.TextBox_ProfilePassword.UseSystemPasswordChar = true;
            // 
            // PageView_Management
            // 
            this.PageView_Management.Image = global::Login.Properties.Resources.management;
            this.PageView_Management.ItemSize = new System.Drawing.SizeF(175F, 41F);
            this.PageView_Management.Location = new System.Drawing.Point(236, 36);
            this.PageView_Management.Name = "PageView_Management";
            this.PageView_Management.Size = new System.Drawing.Size(866, 622);
            this.PageView_Management.SubPages.Add(this.PageView_Revenue);
            this.PageView_Management.SubPages.Add(this.PageView_Menu);
            this.PageView_Management.SubPages.Add(this.PageView_Category);
            this.PageView_Management.SubPages.Add(this.PageView_Table);
            this.PageView_Management.SubPages.Add(this.PageView_Employee);
            this.PageView_Management.Text = "Management";
            // 
            // PageView_Revenue
            // 
            this.PageView_Revenue.Controls.Add(this.Panel_GridViewReceipt);
            this.PageView_Revenue.Controls.Add(this.PanelOperation_Revenue);
            this.PageView_Revenue.Image = global::Login.Properties.Resources.revenue;
            this.PageView_Revenue.ItemSize = new System.Drawing.SizeF(175F, 41F);
            this.PageView_Revenue.Location = new System.Drawing.Point(236, 36);
            this.PageView_Revenue.Name = "PageView_Revenue";
            this.PageView_Revenue.Size = new System.Drawing.Size(863, 622);
            this.PageView_Revenue.Text = "Revenue";
            // 
            // Panel_GridViewReceipt
            // 
            this.Panel_GridViewReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_GridViewReceipt.Controls.Add(this.GridView_Receipt);
            this.Panel_GridViewReceipt.Location = new System.Drawing.Point(3, 42);
            this.Panel_GridViewReceipt.Name = "Panel_GridViewReceipt";
            this.Panel_GridViewReceipt.Size = new System.Drawing.Size(857, 577);
            this.Panel_GridViewReceipt.TabIndex = 1;
            // 
            // GridView_Receipt
            // 
            this.GridView_Receipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView_Receipt.AutoScroll = true;
            this.GridView_Receipt.BackColor = System.Drawing.Color.White;
            this.GridView_Receipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridView_Receipt.Font = new System.Drawing.Font("Source Sans Pro", 9F);
            this.GridView_Receipt.ForeColor = System.Drawing.Color.Black;
            this.GridView_Receipt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GridView_Receipt.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.GridView_Receipt.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "name";
            gridViewTextBoxColumn1.HeaderText = "Tên bàn";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "name";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 164;
            gridViewDecimalColumn1.FieldName = "totalPrice";
            gridViewDecimalColumn1.HeaderText = "Tổng cộng";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "totalPrice";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn1.Width = 164;
            gridViewDateTimeColumn1.FieldName = "arrivalDate";
            gridViewDateTimeColumn1.HeaderText = "Giờ check-in";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "arrivalDate";
            gridViewDateTimeColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn1.Width = 164;
            gridViewDateTimeColumn2.FieldName = "departDate";
            gridViewDateTimeColumn2.HeaderText = "Giờ check-out";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "departDate";
            gridViewDateTimeColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn2.Width = 164;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "discount";
            gridViewDecimalColumn2.HeaderText = "Giảm giá";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "discount";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn2.Width = 165;
            this.GridView_Receipt.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewDecimalColumn2});
            this.GridView_Receipt.MasterTemplate.DataSource = this.uSERPROCGetListReceiptByDateBindingSource;
            this.GridView_Receipt.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GridView_Receipt.Name = "GridView_Receipt";
            this.GridView_Receipt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GridView_Receipt.Size = new System.Drawing.Size(851, 571);
            this.GridView_Receipt.TabIndex = 0;
            // 
            // PanelOperation_Revenue
            // 
            this.PanelOperation_Revenue.Controls.Add(this.Button_ViewReceipt);
            this.PanelOperation_Revenue.Controls.Add(this.DateTimePicker_ToDate);
            this.PanelOperation_Revenue.Controls.Add(this.DateTimePicker_FromDate);
            this.PanelOperation_Revenue.Location = new System.Drawing.Point(3, 3);
            this.PanelOperation_Revenue.Name = "PanelOperation_Revenue";
            this.PanelOperation_Revenue.Size = new System.Drawing.Size(517, 33);
            this.PanelOperation_Revenue.TabIndex = 0;
            // 
            // Button_ViewReceipt
            // 
            this.Button_ViewReceipt.Location = new System.Drawing.Point(429, 4);
            this.Button_ViewReceipt.Name = "Button_ViewReceipt";
            this.Button_ViewReceipt.Size = new System.Drawing.Size(83, 24);
            this.Button_ViewReceipt.TabIndex = 2;
            this.Button_ViewReceipt.Text = "Xem";
            this.Button_ViewReceipt.Click += new System.EventHandler(this.Button_ViewReceipt_Click);
            // 
            // DateTimePicker_ToDate
            // 
            this.DateTimePicker_ToDate.CalendarSize = new System.Drawing.Size(290, 320);
            this.DateTimePicker_ToDate.Font = new System.Drawing.Font("Source Sans Pro", 9F);
            this.DateTimePicker_ToDate.ForeColor = System.Drawing.Color.Black;
            this.DateTimePicker_ToDate.Location = new System.Drawing.Point(216, 4);
            this.DateTimePicker_ToDate.Name = "DateTimePicker_ToDate";
            this.DateTimePicker_ToDate.Size = new System.Drawing.Size(207, 25);
            this.DateTimePicker_ToDate.TabIndex = 1;
            this.DateTimePicker_ToDate.TabStop = false;
            this.DateTimePicker_ToDate.Text = "Wednesday, January 12, 2022";
            this.DateTimePicker_ToDate.Value = new System.DateTime(2022, 1, 12, 3, 48, 14, 983);
            // 
            // DateTimePicker_FromDate
            // 
            this.DateTimePicker_FromDate.CalendarSize = new System.Drawing.Size(290, 320);
            this.DateTimePicker_FromDate.Font = new System.Drawing.Font("Source Sans Pro", 9F);
            this.DateTimePicker_FromDate.ForeColor = System.Drawing.Color.Black;
            this.DateTimePicker_FromDate.Location = new System.Drawing.Point(3, 4);
            this.DateTimePicker_FromDate.Name = "DateTimePicker_FromDate";
            this.DateTimePicker_FromDate.Size = new System.Drawing.Size(207, 25);
            this.DateTimePicker_FromDate.TabIndex = 0;
            this.DateTimePicker_FromDate.TabStop = false;
            this.DateTimePicker_FromDate.Text = "Wednesday, January 12, 2022";
            this.DateTimePicker_FromDate.Value = new System.DateTime(2022, 1, 12, 3, 48, 14, 983);
            // 
            // PageView_Menu
            // 
            this.PageView_Menu.Controls.Add(this.Panel_MenuBinding);
            this.PageView_Menu.Controls.Add(this.Panel_GridViewMenu);
            this.PageView_Menu.Controls.Add(this.Panel_SearchMenu);
            this.PageView_Menu.Controls.Add(this.PanelOperation_Menu);
            this.PageView_Menu.Image = global::Login.Properties.Resources.menu;
            this.PageView_Menu.ItemSize = new System.Drawing.SizeF(175F, 41F);
            this.PageView_Menu.Location = new System.Drawing.Point(236, 36);
            this.PageView_Menu.Name = "PageView_Menu";
            this.PageView_Menu.Size = new System.Drawing.Size(863, 622);
            this.PageView_Menu.Text = "Menu";
            // 
            // Panel_MenuBinding
            // 
            this.Panel_MenuBinding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_MenuBinding.Controls.Add(this.UpDown_Price);
            this.Panel_MenuBinding.Controls.Add(this.ComboBox_Category);
            this.Panel_MenuBinding.Controls.Add(this.TextBox_IDFood);
            this.Panel_MenuBinding.Controls.Add(this.Label_FoodName);
            this.Panel_MenuBinding.Controls.Add(this.Label_Category);
            this.Panel_MenuBinding.Controls.Add(this.TextBox_FoodName);
            this.Panel_MenuBinding.Controls.Add(this.Label_Price);
            this.Panel_MenuBinding.Controls.Add(this.Label_IDFood);
            this.Panel_MenuBinding.Location = new System.Drawing.Point(563, 39);
            this.Panel_MenuBinding.Name = "Panel_MenuBinding";
            this.Panel_MenuBinding.Size = new System.Drawing.Size(297, 580);
            this.Panel_MenuBinding.TabIndex = 3;
            // 
            // UpDown_Price
            // 
            this.UpDown_Price.Location = new System.Drawing.Point(95, 103);
            this.UpDown_Price.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.UpDown_Price.Name = "UpDown_Price";
            this.UpDown_Price.Size = new System.Drawing.Size(187, 24);
            this.UpDown_Price.TabIndex = 7;
            // 
            // ComboBox_Category
            // 
            this.ComboBox_Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Category.FormattingEnabled = true;
            this.ComboBox_Category.Location = new System.Drawing.Point(95, 76);
            this.ComboBox_Category.Name = "ComboBox_Category";
            this.ComboBox_Category.Size = new System.Drawing.Size(187, 21);
            this.ComboBox_Category.TabIndex = 6;
            // 
            // TextBox_IDFood
            // 
            this.TextBox_IDFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_IDFood.Location = new System.Drawing.Point(95, 13);
            this.TextBox_IDFood.Name = "TextBox_IDFood";
            this.TextBox_IDFood.ReadOnly = true;
            this.TextBox_IDFood.Size = new System.Drawing.Size(187, 24);
            this.TextBox_IDFood.TabIndex = 3;
            this.TextBox_IDFood.TextChanged += new System.EventHandler(this.TextBox_IDFood_TextChanged);
            // 
            // Label_FoodName
            // 
            this.Label_FoodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_FoodName.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.Label_FoodName.Location = new System.Drawing.Point(13, 43);
            this.Label_FoodName.Name = "Label_FoodName";
            this.Label_FoodName.Size = new System.Drawing.Size(73, 24);
            this.Label_FoodName.TabIndex = 1;
            this.Label_FoodName.Text = "Tên món:";
            // 
            // Label_Category
            // 
            this.Label_Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Category.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.Label_Category.Location = new System.Drawing.Point(13, 73);
            this.Label_Category.Name = "Label_Category";
            this.Label_Category.Size = new System.Drawing.Size(82, 24);
            this.Label_Category.TabIndex = 2;
            this.Label_Category.Text = "Danh mục:";
            // 
            // TextBox_FoodName
            // 
            this.TextBox_FoodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_FoodName.Location = new System.Drawing.Point(95, 43);
            this.TextBox_FoodName.Name = "TextBox_FoodName";
            this.TextBox_FoodName.Size = new System.Drawing.Size(187, 24);
            this.TextBox_FoodName.TabIndex = 3;
            // 
            // Label_Price
            // 
            this.Label_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Price.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.Label_Price.Location = new System.Drawing.Point(13, 103);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(34, 24);
            this.Label_Price.TabIndex = 2;
            this.Label_Price.Text = "Giá:";
            // 
            // Label_IDFood
            // 
            this.Label_IDFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_IDFood.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.Label_IDFood.Location = new System.Drawing.Point(13, 13);
            this.Label_IDFood.Name = "Label_IDFood";
            this.Label_IDFood.Size = new System.Drawing.Size(26, 24);
            this.Label_IDFood.TabIndex = 0;
            this.Label_IDFood.Text = "ID:";
            this.Label_IDFood.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // Panel_GridViewMenu
            // 
            this.Panel_GridViewMenu.Controls.Add(this.GridView_Menu);
            this.Panel_GridViewMenu.Location = new System.Drawing.Point(3, 39);
            this.Panel_GridViewMenu.Name = "Panel_GridViewMenu";
            this.Panel_GridViewMenu.Size = new System.Drawing.Size(557, 580);
            this.Panel_GridViewMenu.TabIndex = 2;
            // 
            // GridView_Menu
            // 
            this.GridView_Menu.AutoScroll = true;
            this.GridView_Menu.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.GridView_Menu.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.GridView_Menu.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.GridView_Menu.Name = "GridView_Menu";
            this.GridView_Menu.Size = new System.Drawing.Size(551, 574);
            this.GridView_Menu.TabIndex = 0;
            // 
            // Panel_SearchMenu
            // 
            this.Panel_SearchMenu.Controls.Add(this.TextBox_SearchFoodName);
            this.Panel_SearchMenu.Controls.Add(this.Button_Search);
            this.Panel_SearchMenu.Location = new System.Drawing.Point(473, 3);
            this.Panel_SearchMenu.Name = "Panel_SearchMenu";
            this.Panel_SearchMenu.Size = new System.Drawing.Size(390, 30);
            this.Panel_SearchMenu.TabIndex = 1;
            // 
            // TextBox_SearchFoodName
            // 
            this.TextBox_SearchFoodName.Location = new System.Drawing.Point(3, 3);
            this.TextBox_SearchFoodName.Name = "TextBox_SearchFoodName";
            this.TextBox_SearchFoodName.Size = new System.Drawing.Size(268, 24);
            this.TextBox_SearchFoodName.TabIndex = 2;
            // 
            // Button_Search
            // 
            this.Button_Search.Font = new System.Drawing.Font("Source Sans Pro", 11F);
            this.Button_Search.Image = global::Login.Properties.Resources.search;
            this.Button_Search.Location = new System.Drawing.Point(277, 3);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(110, 24);
            this.Button_Search.TabIndex = 6;
            this.Button_Search.Text = "Tìm kiếm";
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // PanelOperation_Menu
            // 
            this.PanelOperation_Menu.Controls.Add(this.Button_DeleteMenu);
            this.PanelOperation_Menu.Controls.Add(this.Button_EditMenu);
            this.PanelOperation_Menu.Controls.Add(this.Button_ViewMenu);
            this.PanelOperation_Menu.Controls.Add(this.Button_AddMenu);
            this.PanelOperation_Menu.Location = new System.Drawing.Point(3, 3);
            this.PanelOperation_Menu.Name = "PanelOperation_Menu";
            this.PanelOperation_Menu.Size = new System.Drawing.Size(464, 30);
            this.PanelOperation_Menu.TabIndex = 0;
            // 
            // Button_DeleteMenu
            // 
            this.Button_DeleteMenu.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_DeleteMenu.Image = global::Login.Properties.Resources.delete;
            this.Button_DeleteMenu.Location = new System.Drawing.Point(119, 3);
            this.Button_DeleteMenu.Name = "Button_DeleteMenu";
            this.Button_DeleteMenu.Size = new System.Drawing.Size(110, 24);
            this.Button_DeleteMenu.TabIndex = 3;
            this.Button_DeleteMenu.Text = "Xóa món";
            this.Button_DeleteMenu.Click += new System.EventHandler(this.Button_DeleteMenu_Click);
            // 
            // Button_EditMenu
            // 
            this.Button_EditMenu.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_EditMenu.Image = global::Login.Properties.Resources.edit;
            this.Button_EditMenu.Location = new System.Drawing.Point(235, 3);
            this.Button_EditMenu.Name = "Button_EditMenu";
            this.Button_EditMenu.Size = new System.Drawing.Size(110, 24);
            this.Button_EditMenu.TabIndex = 4;
            this.Button_EditMenu.Text = "Sửa món";
            this.Button_EditMenu.Click += new System.EventHandler(this.Button_EditMenu_Click);
            // 
            // Button_ViewMenu
            // 
            this.Button_ViewMenu.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_ViewMenu.Image = ((System.Drawing.Image)(resources.GetObject("Button_ViewMenu.Image")));
            this.Button_ViewMenu.Location = new System.Drawing.Point(351, 3);
            this.Button_ViewMenu.Name = "Button_ViewMenu";
            this.Button_ViewMenu.Size = new System.Drawing.Size(110, 24);
            this.Button_ViewMenu.TabIndex = 5;
            this.Button_ViewMenu.Text = "Xem món";
            this.Button_ViewMenu.Click += new System.EventHandler(this.Button_ViewMenu_Click);
            // 
            // Button_AddMenu
            // 
            this.Button_AddMenu.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_AddMenu.Image = ((System.Drawing.Image)(resources.GetObject("Button_AddMenu.Image")));
            this.Button_AddMenu.Location = new System.Drawing.Point(3, 3);
            this.Button_AddMenu.Name = "Button_AddMenu";
            this.Button_AddMenu.Size = new System.Drawing.Size(110, 24);
            this.Button_AddMenu.TabIndex = 2;
            this.Button_AddMenu.Text = "Thêm món";
            this.Button_AddMenu.Click += new System.EventHandler(this.Button_AddMenu_Click);
            // 
            // PageView_Category
            // 
            this.PageView_Category.Controls.Add(this.PanelOperation_Category);
            this.PageView_Category.Controls.Add(this.Panel_CategoryBinding);
            this.PageView_Category.Controls.Add(this.Panel_GridViewCategory);
            this.PageView_Category.Image = global::Login.Properties.Resources.category;
            this.PageView_Category.ItemSize = new System.Drawing.SizeF(175F, 41F);
            this.PageView_Category.Location = new System.Drawing.Point(236, 36);
            this.PageView_Category.Name = "PageView_Category";
            this.PageView_Category.Size = new System.Drawing.Size(863, 622);
            this.PageView_Category.Text = "Category";
            // 
            // PanelOperation_Category
            // 
            this.PanelOperation_Category.Controls.Add(this.Button_DeleteCategory);
            this.PanelOperation_Category.Controls.Add(this.Button_EditCategory);
            this.PanelOperation_Category.Controls.Add(this.Button_ViewCategory);
            this.PanelOperation_Category.Controls.Add(this.Button_AddCategory);
            this.PanelOperation_Category.Location = new System.Drawing.Point(3, 3);
            this.PanelOperation_Category.Name = "PanelOperation_Category";
            this.PanelOperation_Category.Size = new System.Drawing.Size(520, 30);
            this.PanelOperation_Category.TabIndex = 8;
            // 
            // Button_DeleteCategory
            // 
            this.Button_DeleteCategory.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_DeleteCategory.Image = global::Login.Properties.Resources.delete;
            this.Button_DeleteCategory.Location = new System.Drawing.Point(133, 3);
            this.Button_DeleteCategory.Name = "Button_DeleteCategory";
            this.Button_DeleteCategory.Size = new System.Drawing.Size(124, 24);
            this.Button_DeleteCategory.TabIndex = 3;
            this.Button_DeleteCategory.Text = "      Xóa danh mục";
            this.Button_DeleteCategory.Click += new System.EventHandler(this.Button_DeleteCategory_Click);
            // 
            // Button_EditCategory
            // 
            this.Button_EditCategory.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_EditCategory.Image = global::Login.Properties.Resources.edit;
            this.Button_EditCategory.Location = new System.Drawing.Point(263, 3);
            this.Button_EditCategory.Name = "Button_EditCategory";
            this.Button_EditCategory.Size = new System.Drawing.Size(124, 24);
            this.Button_EditCategory.TabIndex = 4;
            this.Button_EditCategory.Text = "      Sửa danh mục";
            this.Button_EditCategory.Click += new System.EventHandler(this.Button_EditCategory_Click);
            // 
            // Button_ViewCategory
            // 
            this.Button_ViewCategory.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_ViewCategory.Image = ((System.Drawing.Image)(resources.GetObject("Button_ViewCategory.Image")));
            this.Button_ViewCategory.Location = new System.Drawing.Point(393, 3);
            this.Button_ViewCategory.Name = "Button_ViewCategory";
            this.Button_ViewCategory.Size = new System.Drawing.Size(124, 24);
            this.Button_ViewCategory.TabIndex = 5;
            this.Button_ViewCategory.Text = "      Xem danh mục";
            this.Button_ViewCategory.Click += new System.EventHandler(this.Button_ViewCategory_Click);
            // 
            // Button_AddCategory
            // 
            this.Button_AddCategory.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_AddCategory.Image = ((System.Drawing.Image)(resources.GetObject("Button_AddCategory.Image")));
            this.Button_AddCategory.Location = new System.Drawing.Point(3, 3);
            this.Button_AddCategory.Name = "Button_AddCategory";
            this.Button_AddCategory.Size = new System.Drawing.Size(124, 24);
            this.Button_AddCategory.TabIndex = 2;
            this.Button_AddCategory.Text = "      Thêm danh mục";
            this.Button_AddCategory.Click += new System.EventHandler(this.Button_AddCategory_Click);
            // 
            // Panel_CategoryBinding
            // 
            this.Panel_CategoryBinding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_CategoryBinding.Controls.Add(this.TextBox_IDCategory);
            this.Panel_CategoryBinding.Controls.Add(this.Label_CategoryName);
            this.Panel_CategoryBinding.Controls.Add(this.TextBox_CategoryName);
            this.Panel_CategoryBinding.Controls.Add(this.Label_IDCategory);
            this.Panel_CategoryBinding.Location = new System.Drawing.Point(538, 39);
            this.Panel_CategoryBinding.Name = "Panel_CategoryBinding";
            this.Panel_CategoryBinding.Size = new System.Drawing.Size(322, 580);
            this.Panel_CategoryBinding.TabIndex = 7;
            // 
            // TextBox_IDCategory
            // 
            this.TextBox_IDCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_IDCategory.Location = new System.Drawing.Point(126, 13);
            this.TextBox_IDCategory.Name = "TextBox_IDCategory";
            this.TextBox_IDCategory.Size = new System.Drawing.Size(181, 24);
            this.TextBox_IDCategory.TabIndex = 3;
            // 
            // Label_CategoryName
            // 
            this.Label_CategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_CategoryName.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.Label_CategoryName.Location = new System.Drawing.Point(10, 43);
            this.Label_CategoryName.Name = "Label_CategoryName";
            this.Label_CategoryName.Size = new System.Drawing.Size(110, 24);
            this.Label_CategoryName.TabIndex = 1;
            this.Label_CategoryName.Text = "Tên danh mục:";
            // 
            // TextBox_CategoryName
            // 
            this.TextBox_CategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_CategoryName.Location = new System.Drawing.Point(126, 43);
            this.TextBox_CategoryName.Name = "TextBox_CategoryName";
            this.TextBox_CategoryName.Size = new System.Drawing.Size(181, 24);
            this.TextBox_CategoryName.TabIndex = 3;
            // 
            // Label_IDCategory
            // 
            this.Label_IDCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_IDCategory.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.Label_IDCategory.Location = new System.Drawing.Point(10, 13);
            this.Label_IDCategory.Name = "Label_IDCategory";
            this.Label_IDCategory.Size = new System.Drawing.Size(26, 24);
            this.Label_IDCategory.TabIndex = 0;
            this.Label_IDCategory.Text = "ID:";
            this.Label_IDCategory.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // Panel_GridViewCategory
            // 
            this.Panel_GridViewCategory.Controls.Add(this.GridView_Category);
            this.Panel_GridViewCategory.Location = new System.Drawing.Point(3, 39);
            this.Panel_GridViewCategory.Name = "Panel_GridViewCategory";
            this.Panel_GridViewCategory.Size = new System.Drawing.Size(532, 580);
            this.Panel_GridViewCategory.TabIndex = 6;
            // 
            // GridView_Category
            // 
            this.GridView_Category.AutoScroll = true;
            this.GridView_Category.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.GridView_Category.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.GridView_Category.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.GridView_Category.Name = "GridView_Category";
            this.GridView_Category.Size = new System.Drawing.Size(526, 574);
            this.GridView_Category.TabIndex = 0;
            // 
            // PageView_Table
            // 
            this.PageView_Table.Controls.Add(this.PanelOperation_Table);
            this.PageView_Table.Controls.Add(this.Panel_TableBinding);
            this.PageView_Table.Controls.Add(this.Panel_GridViewTable);
            this.PageView_Table.Image = global::Login.Properties.Resources.table;
            this.PageView_Table.ItemSize = new System.Drawing.SizeF(175F, 41F);
            this.PageView_Table.Location = new System.Drawing.Point(236, 36);
            this.PageView_Table.Name = "PageView_Table";
            this.PageView_Table.Size = new System.Drawing.Size(863, 622);
            this.PageView_Table.Text = "Table";
            // 
            // PanelOperation_Table
            // 
            this.PanelOperation_Table.Controls.Add(this.Button_DeleteTable);
            this.PanelOperation_Table.Controls.Add(this.Button_EditTable);
            this.PanelOperation_Table.Controls.Add(this.Button_ViewTable);
            this.PanelOperation_Table.Controls.Add(this.Button_AddTable);
            this.PanelOperation_Table.Location = new System.Drawing.Point(3, 3);
            this.PanelOperation_Table.Name = "PanelOperation_Table";
            this.PanelOperation_Table.Size = new System.Drawing.Size(464, 30);
            this.PanelOperation_Table.TabIndex = 6;
            // 
            // Button_DeleteTable
            // 
            this.Button_DeleteTable.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_DeleteTable.Image = global::Login.Properties.Resources.delete;
            this.Button_DeleteTable.Location = new System.Drawing.Point(119, 3);
            this.Button_DeleteTable.Name = "Button_DeleteTable";
            this.Button_DeleteTable.Size = new System.Drawing.Size(110, 24);
            this.Button_DeleteTable.TabIndex = 3;
            this.Button_DeleteTable.Text = "Xóa bàn";
            this.Button_DeleteTable.Click += new System.EventHandler(this.Button_DeleteTable_Click);
            // 
            // Button_EditTable
            // 
            this.Button_EditTable.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_EditTable.Image = global::Login.Properties.Resources.edit;
            this.Button_EditTable.Location = new System.Drawing.Point(235, 3);
            this.Button_EditTable.Name = "Button_EditTable";
            this.Button_EditTable.Size = new System.Drawing.Size(110, 24);
            this.Button_EditTable.TabIndex = 4;
            this.Button_EditTable.Text = "Sửa bàn";
            this.Button_EditTable.Click += new System.EventHandler(this.Button_EditTable_Click);
            // 
            // Button_ViewTable
            // 
            this.Button_ViewTable.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_ViewTable.Image = ((System.Drawing.Image)(resources.GetObject("Button_ViewTable.Image")));
            this.Button_ViewTable.Location = new System.Drawing.Point(351, 3);
            this.Button_ViewTable.Name = "Button_ViewTable";
            this.Button_ViewTable.Size = new System.Drawing.Size(110, 24);
            this.Button_ViewTable.TabIndex = 5;
            this.Button_ViewTable.Text = "Xem bàn";
            this.Button_ViewTable.Click += new System.EventHandler(this.Button_ViewTable_Click);
            // 
            // Button_AddTable
            // 
            this.Button_AddTable.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_AddTable.Image = ((System.Drawing.Image)(resources.GetObject("Button_AddTable.Image")));
            this.Button_AddTable.Location = new System.Drawing.Point(3, 3);
            this.Button_AddTable.Name = "Button_AddTable";
            this.Button_AddTable.Size = new System.Drawing.Size(110, 24);
            this.Button_AddTable.TabIndex = 2;
            this.Button_AddTable.Text = "Thêm bàn";
            this.Button_AddTable.Click += new System.EventHandler(this.Button_AddTable_Click);
            // 
            // Panel_TableBinding
            // 
            this.Panel_TableBinding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_TableBinding.Controls.Add(this.ComboBox_TableStatus);
            this.Panel_TableBinding.Controls.Add(this.TextBox_IDTable);
            this.Panel_TableBinding.Controls.Add(this.Label_TableName);
            this.Panel_TableBinding.Controls.Add(this.Label_TableStatus);
            this.Panel_TableBinding.Controls.Add(this.TextBox_TableName);
            this.Panel_TableBinding.Controls.Add(this.Label_IDTable);
            this.Panel_TableBinding.Location = new System.Drawing.Point(563, 39);
            this.Panel_TableBinding.Name = "Panel_TableBinding";
            this.Panel_TableBinding.Size = new System.Drawing.Size(297, 580);
            this.Panel_TableBinding.TabIndex = 5;
            // 
            // ComboBox_TableStatus
            // 
            this.ComboBox_TableStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_TableStatus.FormattingEnabled = true;
            this.ComboBox_TableStatus.Location = new System.Drawing.Point(101, 76);
            this.ComboBox_TableStatus.Name = "ComboBox_TableStatus";
            this.ComboBox_TableStatus.Size = new System.Drawing.Size(181, 21);
            this.ComboBox_TableStatus.TabIndex = 6;
            // 
            // TextBox_IDTable
            // 
            this.TextBox_IDTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_IDTable.Location = new System.Drawing.Point(101, 13);
            this.TextBox_IDTable.Name = "TextBox_IDTable";
            this.TextBox_IDTable.Size = new System.Drawing.Size(181, 24);
            this.TextBox_IDTable.TabIndex = 3;
            // 
            // Label_TableName
            // 
            this.Label_TableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_TableName.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.Label_TableName.Location = new System.Drawing.Point(13, 43);
            this.Label_TableName.Name = "Label_TableName";
            this.Label_TableName.Size = new System.Drawing.Size(68, 24);
            this.Label_TableName.TabIndex = 1;
            this.Label_TableName.Text = "Tên bàn:";
            // 
            // Label_TableStatus
            // 
            this.Label_TableStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_TableStatus.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.Label_TableStatus.Location = new System.Drawing.Point(13, 73);
            this.Label_TableStatus.Name = "Label_TableStatus";
            this.Label_TableStatus.Size = new System.Drawing.Size(82, 24);
            this.Label_TableStatus.TabIndex = 2;
            this.Label_TableStatus.Text = "Trạng thái:";
            // 
            // TextBox_TableName
            // 
            this.TextBox_TableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_TableName.Location = new System.Drawing.Point(101, 43);
            this.TextBox_TableName.Name = "TextBox_TableName";
            this.TextBox_TableName.Size = new System.Drawing.Size(181, 24);
            this.TextBox_TableName.TabIndex = 3;
            // 
            // Label_IDTable
            // 
            this.Label_IDTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_IDTable.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.Label_IDTable.Location = new System.Drawing.Point(13, 13);
            this.Label_IDTable.Name = "Label_IDTable";
            this.Label_IDTable.Size = new System.Drawing.Size(26, 24);
            this.Label_IDTable.TabIndex = 0;
            this.Label_IDTable.Text = "ID:";
            this.Label_IDTable.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // Panel_GridViewTable
            // 
            this.Panel_GridViewTable.Controls.Add(this.GridView_Table);
            this.Panel_GridViewTable.Location = new System.Drawing.Point(3, 39);
            this.Panel_GridViewTable.Name = "Panel_GridViewTable";
            this.Panel_GridViewTable.Size = new System.Drawing.Size(557, 580);
            this.Panel_GridViewTable.TabIndex = 4;
            // 
            // GridView_Table
            // 
            this.GridView_Table.AutoScroll = true;
            this.GridView_Table.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.GridView_Table.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.GridView_Table.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.GridView_Table.Name = "GridView_Table";
            this.GridView_Table.Size = new System.Drawing.Size(551, 574);
            this.GridView_Table.TabIndex = 0;
            // 
            // PageView_Employee
            // 
            this.PageView_Employee.Controls.Add(this.PanelOperation_Employee);
            this.PageView_Employee.Controls.Add(this.Panel_EmployeeBinding);
            this.PageView_Employee.Controls.Add(this.Panel_GridViewEmployee);
            this.PageView_Employee.Image = global::Login.Properties.Resources.employee;
            this.PageView_Employee.ItemSize = new System.Drawing.SizeF(175F, 41F);
            this.PageView_Employee.Location = new System.Drawing.Point(236, 36);
            this.PageView_Employee.Name = "PageView_Employee";
            this.PageView_Employee.Size = new System.Drawing.Size(866, 622);
            this.PageView_Employee.Text = "Employee";
            // 
            // PanelOperation_Employee
            // 
            this.PanelOperation_Employee.Controls.Add(this.Button_ViewAccount);
            this.PanelOperation_Employee.Controls.Add(this.Button_EditAccount);
            this.PanelOperation_Employee.Controls.Add(this.Button_DeleteAccount);
            this.PanelOperation_Employee.Controls.Add(this.Button_AddAccount);
            this.PanelOperation_Employee.Location = new System.Drawing.Point(3, 3);
            this.PanelOperation_Employee.Name = "PanelOperation_Employee";
            this.PanelOperation_Employee.Size = new System.Drawing.Size(464, 30);
            this.PanelOperation_Employee.TabIndex = 6;
            // 
            // Button_ViewAccount
            // 
            this.Button_ViewAccount.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_ViewAccount.Image = global::Login.Properties.Resources.view;
            this.Button_ViewAccount.Location = new System.Drawing.Point(351, 3);
            this.Button_ViewAccount.Name = "Button_ViewAccount";
            this.Button_ViewAccount.Size = new System.Drawing.Size(110, 24);
            this.Button_ViewAccount.TabIndex = 5;
            this.Button_ViewAccount.Text = "Xem tài khoản";
            this.Button_ViewAccount.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_ViewAccount.Click += new System.EventHandler(this.Button_ViewAccount_Click);
            // 
            // Button_EditAccount
            // 
            this.Button_EditAccount.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_EditAccount.Image = global::Login.Properties.Resources.edit;
            this.Button_EditAccount.Location = new System.Drawing.Point(235, 3);
            this.Button_EditAccount.Name = "Button_EditAccount";
            this.Button_EditAccount.Size = new System.Drawing.Size(110, 24);
            this.Button_EditAccount.TabIndex = 4;
            this.Button_EditAccount.Text = "     Sửa tài khoản";
            this.Button_EditAccount.Click += new System.EventHandler(this.Button_EditAccount_Click);
            // 
            // Button_DeleteAccount
            // 
            this.Button_DeleteAccount.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_DeleteAccount.Image = global::Login.Properties.Resources.delete;
            this.Button_DeleteAccount.Location = new System.Drawing.Point(119, 3);
            this.Button_DeleteAccount.Name = "Button_DeleteAccount";
            this.Button_DeleteAccount.Size = new System.Drawing.Size(110, 24);
            this.Button_DeleteAccount.TabIndex = 3;
            this.Button_DeleteAccount.Text = "     Xóa tài khoản";
            this.Button_DeleteAccount.Click += new System.EventHandler(this.Button_DeleteAccount_Click);
            // 
            // Button_AddAccount
            // 
            this.Button_AddAccount.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_AddAccount.Image = ((System.Drawing.Image)(resources.GetObject("Button_AddAccount.Image")));
            this.Button_AddAccount.Location = new System.Drawing.Point(3, 3);
            this.Button_AddAccount.Name = "Button_AddAccount";
            this.Button_AddAccount.Size = new System.Drawing.Size(110, 24);
            this.Button_AddAccount.TabIndex = 2;
            this.Button_AddAccount.Text = "Thêm tài khoản";
            this.Button_AddAccount.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_AddAccount.Click += new System.EventHandler(this.Button_AddAccount_Click);
            // 
            // Panel_EmployeeBinding
            // 
            this.Panel_EmployeeBinding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_EmployeeBinding.Controls.Add(this.UpDown_AccountType);
            this.Panel_EmployeeBinding.Controls.Add(this.Button_ResetPassword);
            this.Panel_EmployeeBinding.Controls.Add(this.Label_AccountType);
            this.Panel_EmployeeBinding.Controls.Add(this.TextBox_Displayname);
            this.Panel_EmployeeBinding.Controls.Add(this.Label_Displayname);
            this.Panel_EmployeeBinding.Controls.Add(this.TextBox_Username);
            this.Panel_EmployeeBinding.Controls.Add(this.Label_Username);
            this.Panel_EmployeeBinding.Location = new System.Drawing.Point(528, 39);
            this.Panel_EmployeeBinding.Name = "Panel_EmployeeBinding";
            this.Panel_EmployeeBinding.Size = new System.Drawing.Size(335, 580);
            this.Panel_EmployeeBinding.TabIndex = 5;
            // 
            // UpDown_AccountType
            // 
            this.UpDown_AccountType.Location = new System.Drawing.Point(133, 73);
            this.UpDown_AccountType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDown_AccountType.Name = "UpDown_AccountType";
            this.UpDown_AccountType.Size = new System.Drawing.Size(187, 24);
            this.UpDown_AccountType.TabIndex = 9;
            // 
            // Button_ResetPassword
            // 
            this.Button_ResetPassword.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Button_ResetPassword.Image = ((System.Drawing.Image)(resources.GetObject("Button_ResetPassword.Image")));
            this.Button_ResetPassword.Location = new System.Drawing.Point(210, 112);
            this.Button_ResetPassword.Name = "Button_ResetPassword";
            this.Button_ResetPassword.Size = new System.Drawing.Size(110, 24);
            this.Button_ResetPassword.TabIndex = 8;
            this.Button_ResetPassword.Text = "Đặt lại mật khẩu";
            this.Button_ResetPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_ResetPassword.Click += new System.EventHandler(this.Button_ResetPassword_Click);
            // 
            // Label_AccountType
            // 
            this.Label_AccountType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_AccountType.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.Label_AccountType.Location = new System.Drawing.Point(12, 73);
            this.Label_AccountType.Name = "Label_AccountType";
            this.Label_AccountType.Size = new System.Drawing.Size(67, 24);
            this.Label_AccountType.TabIndex = 2;
            this.Label_AccountType.Text = "Chức vụ:";
            // 
            // TextBox_Displayname
            // 
            this.TextBox_Displayname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Displayname.Location = new System.Drawing.Point(133, 43);
            this.TextBox_Displayname.Name = "TextBox_Displayname";
            this.TextBox_Displayname.Size = new System.Drawing.Size(187, 24);
            this.TextBox_Displayname.TabIndex = 3;
            // 
            // Label_Displayname
            // 
            this.Label_Displayname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Displayname.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.Label_Displayname.Location = new System.Drawing.Point(12, 43);
            this.Label_Displayname.Name = "Label_Displayname";
            this.Label_Displayname.Size = new System.Drawing.Size(93, 24);
            this.Label_Displayname.TabIndex = 1;
            this.Label_Displayname.Text = "Tên hiển thị:";
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Username.Location = new System.Drawing.Point(133, 13);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.Size = new System.Drawing.Size(187, 24);
            this.TextBox_Username.TabIndex = 3;
            this.TextBox_Username.TextChanged += new System.EventHandler(this.TextBox_Username_TextChanged);
            // 
            // Label_Username
            // 
            this.Label_Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Username.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.Label_Username.Location = new System.Drawing.Point(12, 13);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(115, 24);
            this.Label_Username.TabIndex = 0;
            this.Label_Username.Text = "Tên đăng nhập:";
            this.Label_Username.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // Panel_GridViewEmployee
            // 
            this.Panel_GridViewEmployee.Controls.Add(this.GridView_Employee);
            this.Panel_GridViewEmployee.Location = new System.Drawing.Point(3, 39);
            this.Panel_GridViewEmployee.Name = "Panel_GridViewEmployee";
            this.Panel_GridViewEmployee.Size = new System.Drawing.Size(519, 580);
            this.Panel_GridViewEmployee.TabIndex = 4;
            // 
            // GridView_Employee
            // 
            this.GridView_Employee.AutoScroll = true;
            this.GridView_Employee.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.GridView_Employee.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.GridView_Employee.MasterTemplate.ViewDefinition = tableViewDefinition5;
            this.GridView_Employee.Name = "GridView_Employee";
            this.GridView_Employee.Size = new System.Drawing.Size(513, 574);
            this.GridView_Employee.TabIndex = 0;
            // 
            // RadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 659);
            this.Controls.Add(this.radPageView1);
            this.Name = "RadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Phần mềm quản lý quán cafe";
            this.Load += new System.EventHandler(this.RadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateForReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERPROCGetListReceiptByDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.PageView_Dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_ListTable)).EndInit();
            this.Panel_ListTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_FunctionDashboard)).EndInit();
            this.Panel_FunctionDashboard.ResumeLayout(false);
            this.Panel_FunctionDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_TotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_Discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_SwitchTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_CheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_TotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_ListViewDashboard)).EndInit();
            this.Panel_ListViewDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListView_Receipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelOperation_Dashboard)).EndInit();
            this.PanelOperation_Dashboard.ResumeLayout(false);
            this.PanelOperation_Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_FoodCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddFood)).EndInit();
            this.ViewPage_PersonalInfo.ResumeLayout(false);
            this.ViewPage_PersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_ProfileNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_ProfileUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_ProfileRetypeNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_Profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_ProfileDisplayname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_UpdateProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_ProfilePassword)).EndInit();
            this.PageView_Revenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_GridViewReceipt)).EndInit();
            this.Panel_GridViewReceipt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Receipt.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Receipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelOperation_Revenue)).EndInit();
            this.PanelOperation_Revenue.ResumeLayout(false);
            this.PanelOperation_Revenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ViewReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimePicker_ToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimePicker_FromDate)).EndInit();
            this.PageView_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_MenuBinding)).EndInit();
            this.Panel_MenuBinding.ResumeLayout(false);
            this.Panel_MenuBinding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_IDFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_FoodName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_FoodName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_IDFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_GridViewMenu)).EndInit();
            this.Panel_GridViewMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Menu.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_SearchMenu)).EndInit();
            this.Panel_SearchMenu.ResumeLayout(false);
            this.Panel_SearchMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_SearchFoodName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelOperation_Menu)).EndInit();
            this.PanelOperation_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_DeleteMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_EditMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddMenu)).EndInit();
            this.PageView_Category.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelOperation_Category)).EndInit();
            this.PanelOperation_Category.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_DeleteCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_EditCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ViewCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_CategoryBinding)).EndInit();
            this.Panel_CategoryBinding.ResumeLayout(false);
            this.Panel_CategoryBinding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_IDCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_CategoryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_CategoryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_IDCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_GridViewCategory)).EndInit();
            this.Panel_GridViewCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Category.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Category)).EndInit();
            this.PageView_Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelOperation_Table)).EndInit();
            this.PanelOperation_Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_DeleteTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_EditTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ViewTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_TableBinding)).EndInit();
            this.Panel_TableBinding.ResumeLayout(false);
            this.Panel_TableBinding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_IDTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_TableName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_TableStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_TableName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_IDTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_GridViewTable)).EndInit();
            this.Panel_GridViewTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Table.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Table)).EndInit();
            this.PageView_Employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelOperation_Employee)).EndInit();
            this.PanelOperation_Employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_ViewAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_EditAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_DeleteAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_EmployeeBinding)).EndInit();
            this.Panel_EmployeeBinding.ResumeLayout(false);
            this.Panel_EmployeeBinding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_AccountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ResetPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_AccountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_Displayname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_Displayname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_GridViewEmployee)).EndInit();
            this.Panel_GridViewEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Employee.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource uSERPROCGetListReceiptByDateBindingSource;
        private CoffeeShopDataSet21 coffeeShopDataSet21;
        private CoffeeShopDataSet21TableAdapters.USERPROC_GetListReceiptByDateTableAdapter uSERPROC_GetListReceiptByDateTableAdapter;
        private System.Windows.Forms.BindingSource USP_GetListBillByDateForReportBindingSource;
        private CoffeeShopDataSet21TableAdapters.USP_GetListBillByDateForReportTableAdapter USP_GetListBillByDateForReportTableAdapter;
        private Telerik.WinControls.UI.RadPageViewPage PageView_Employee;
        private Telerik.WinControls.UI.RadPanel PanelOperation_Employee;
        private Telerik.WinControls.UI.RadButton Button_ViewAccount;
        private Telerik.WinControls.UI.RadButton Button_EditAccount;
        private Telerik.WinControls.UI.RadButton Button_DeleteAccount;
        private Telerik.WinControls.UI.RadButton Button_AddAccount;
        private Telerik.WinControls.UI.RadPanel Panel_EmployeeBinding;
        private Telerik.WinControls.UI.RadSpinEditor UpDown_AccountType;
        private Telerik.WinControls.UI.RadButton Button_ResetPassword;
        private Telerik.WinControls.UI.RadLabel Label_AccountType;
        private Telerik.WinControls.UI.RadTextBox TextBox_Displayname;
        private Telerik.WinControls.UI.RadLabel Label_Displayname;
        private Telerik.WinControls.UI.RadTextBox TextBox_Username;
        private Telerik.WinControls.UI.RadLabel Label_Username;
        private Telerik.WinControls.UI.RadPanel Panel_GridViewEmployee;
        private Telerik.WinControls.UI.RadGridView GridView_Employee;
        private Telerik.WinControls.UI.RadPageViewPage PageView_Table;
        private Telerik.WinControls.UI.RadPanel PanelOperation_Table;
        private Telerik.WinControls.UI.RadButton Button_ViewTable;
        private Telerik.WinControls.UI.RadButton Button_EditTable;
        private Telerik.WinControls.UI.RadButton Button_DeleteTable;
        private Telerik.WinControls.UI.RadButton Button_AddTable;
        private Telerik.WinControls.UI.RadPanel Panel_TableBinding;
        private System.Windows.Forms.ComboBox ComboBox_TableStatus;
        private Telerik.WinControls.UI.RadTextBox TextBox_TableName;
        private Telerik.WinControls.UI.RadLabel Label_TableStatus;
        private Telerik.WinControls.UI.RadLabel Label_TableName;
        private Telerik.WinControls.UI.RadTextBox TextBox_IDTable;
        private Telerik.WinControls.UI.RadLabel Label_IDTable;
        private Telerik.WinControls.UI.RadPanel Panel_GridViewTable;
        private Telerik.WinControls.UI.RadGridView GridView_Table;
        private Telerik.WinControls.UI.RadPageViewPage PageView_Category;
        private Telerik.WinControls.UI.RadPanel PanelOperation_Category;
        private Telerik.WinControls.UI.RadButton Button_ViewCategory;
        private Telerik.WinControls.UI.RadButton Button_EditCategory;
        private Telerik.WinControls.UI.RadButton Button_DeleteCategory;
        private Telerik.WinControls.UI.RadButton Button_AddCategory;
        private Telerik.WinControls.UI.RadPanel Panel_CategoryBinding;
        private Telerik.WinControls.UI.RadTextBox TextBox_CategoryName;
        private Telerik.WinControls.UI.RadLabel Label_CategoryName;
        private Telerik.WinControls.UI.RadTextBox TextBox_IDCategory;
        private Telerik.WinControls.UI.RadLabel Label_IDCategory;
        private Telerik.WinControls.UI.RadPanel Panel_GridViewCategory;
        private Telerik.WinControls.UI.RadGridView GridView_Category;
        private Telerik.WinControls.UI.RadPageViewPage PageView_Menu;
        private Telerik.WinControls.UI.RadPanel Panel_MenuBinding;
        private Telerik.WinControls.UI.RadSpinEditor UpDown_Price;
        private System.Windows.Forms.ComboBox ComboBox_Category;
        private Telerik.WinControls.UI.RadLabel Label_Price;
        private Telerik.WinControls.UI.RadTextBox TextBox_FoodName;
        private Telerik.WinControls.UI.RadLabel Label_Category;
        private Telerik.WinControls.UI.RadLabel Label_FoodName;
        private Telerik.WinControls.UI.RadTextBox TextBox_IDFood;
        private Telerik.WinControls.UI.RadLabel Label_IDFood;
        private Telerik.WinControls.UI.RadPanel Panel_GridViewMenu;
        private Telerik.WinControls.UI.RadGridView GridView_Menu;
        private Telerik.WinControls.UI.RadPanel Panel_SearchMenu;
        private Telerik.WinControls.UI.RadTextBox TextBox_SearchFoodName;
        private Telerik.WinControls.UI.RadButton Button_Search;
        private Telerik.WinControls.UI.RadPanel PanelOperation_Menu;
        private Telerik.WinControls.UI.RadButton Button_ViewMenu;
        private Telerik.WinControls.UI.RadButton Button_EditMenu;
        private Telerik.WinControls.UI.RadButton Button_DeleteMenu;
        private Telerik.WinControls.UI.RadButton Button_AddMenu;
        private Telerik.WinControls.UI.RadPageViewPage PageView_Revenue;
        private Telerik.WinControls.UI.RadPanel Panel_GridViewReceipt;
        private Telerik.WinControls.UI.RadGridView GridView_Receipt;
        private Telerik.WinControls.UI.RadPanel PanelOperation_Revenue;
        private Telerik.WinControls.UI.RadButton Button_ViewReceipt;
        private Telerik.WinControls.UI.RadDateTimePicker DateTimePicker_ToDate;
        private Telerik.WinControls.UI.RadDateTimePicker DateTimePicker_FromDate;
        private Telerik.WinControls.UI.RadPageViewPage PageView_Management;
        private Telerik.WinControls.UI.RadPageViewPage ViewPage_PersonalInfo;
        private Telerik.WinControls.UI.RadButton Button_UpdateProfile;
        private Telerik.WinControls.UI.RadTextBox TextBox_ProfileDisplayname;
        private Telerik.WinControls.UI.RadLabel Label_Profile;
        private Telerik.WinControls.UI.RadTextBox TextBox_ProfileRetypeNewPassword;
        private Telerik.WinControls.UI.RadTextBox TextBox_ProfileUsername;
        private Telerik.WinControls.UI.RadTextBox TextBox_ProfileNewPassword;
        private Telerik.WinControls.UI.RadTextBox TextBox_ProfilePassword;
        private Telerik.WinControls.UI.RadPageViewPage PageView_Account;
        private Telerik.WinControls.UI.RadPageViewPage PageView_Dashboard;
        private Telerik.WinControls.UI.RadPanel Panel_ListTable;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout_ListTable;
        private Telerik.WinControls.UI.RadPanel Panel_FunctionDashboard;
        private Telerik.WinControls.UI.RadSpinEditor UpDown_Discount;
        private Telerik.WinControls.UI.RadLabel Label_TotalPrice;
        private Telerik.WinControls.UI.RadLabel Label_Discount;
        private Telerik.WinControls.UI.RadButton Button_SwitchTable;
        private Telerik.WinControls.UI.RadButton Button_CheckOut;
        private Telerik.WinControls.UI.RadTextBox TextBox_TotalPrice;
        private System.Windows.Forms.ComboBox ComboBox_SwitchTable;
        private Telerik.WinControls.UI.RadPanel Panel_ListViewDashboard;
        private Telerik.WinControls.UI.RadListView ListView_Receipt;
        private Telerik.WinControls.UI.RadPanel PanelOperation_Dashboard;
        private Telerik.WinControls.UI.RadSpinEditor UpDown_FoodCount;
        private Telerik.WinControls.UI.RadButton Button_AddFood;
        private System.Windows.Forms.ComboBox ComboBox_Food;
        private System.Windows.Forms.ComboBox ComboBox_Categories;
        private Telerik.WinControls.UI.RadPageView radPageView1;
    }
}
