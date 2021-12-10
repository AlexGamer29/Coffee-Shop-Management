namespace Login
{
    partial class fManageTable
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_listReceipt = new System.Windows.Forms.Panel();
            this.listview_Receipt = new System.Windows.Forms.ListView();
            this.columnHeader_idFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_numberOfFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_totalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_listButton = new System.Windows.Forms.Panel();
            this.label_totalPrice = new System.Windows.Forms.Label();
            this.txtbox_totalPrice = new System.Windows.Forms.TextBox();
            this.comboBox_switchTable = new System.Windows.Forms.ComboBox();
            this.btn_switchTable = new System.Windows.Forms.Button();
            this.amount_discount = new System.Windows.Forms.NumericUpDown();
            this.btn_discount = new System.Windows.Forms.Button();
            this.btn_checkOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_addMenu = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.combobox_categories = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel_listTable = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.panel_listReceipt.SuspendLayout();
            this.panel_listButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount_discount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel_listReceipt
            // 
            this.panel_listReceipt.AccessibleName = "";
            this.panel_listReceipt.Controls.Add(this.listview_Receipt);
            this.panel_listReceipt.Location = new System.Drawing.Point(600, 104);
            this.panel_listReceipt.Name = "panel_listReceipt";
            this.panel_listReceipt.Size = new System.Drawing.Size(448, 477);
            this.panel_listReceipt.TabIndex = 2;
            // 
            // listview_Receipt
            // 
            this.listview_Receipt.AccessibleName = "";
            this.listview_Receipt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_idFood,
            this.columnHeader_numberOfFood,
            this.columnHeader_price,
            this.columnHeader_totalPrice});
            this.listview_Receipt.GridLines = true;
            this.listview_Receipt.HideSelection = false;
            this.listview_Receipt.Location = new System.Drawing.Point(3, 3);
            this.listview_Receipt.Name = "listview_Receipt";
            this.listview_Receipt.Size = new System.Drawing.Size(442, 471);
            this.listview_Receipt.TabIndex = 0;
            this.listview_Receipt.UseCompatibleStateImageBehavior = false;
            this.listview_Receipt.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_idFood
            // 
            this.columnHeader_idFood.Text = "Tên món";
            this.columnHeader_idFood.Width = 138;
            // 
            // columnHeader_numberOfFood
            // 
            this.columnHeader_numberOfFood.Text = "Số lượng";
            // 
            // columnHeader_price
            // 
            this.columnHeader_price.Text = "Đơn giá";
            this.columnHeader_price.Width = 96;
            // 
            // columnHeader_totalPrice
            // 
            this.columnHeader_totalPrice.Text = "Thành tiền";
            this.columnHeader_totalPrice.Width = 144;
            // 
            // panel_listButton
            // 
            this.panel_listButton.AccessibleName = "";
            this.panel_listButton.Controls.Add(this.label_totalPrice);
            this.panel_listButton.Controls.Add(this.txtbox_totalPrice);
            this.panel_listButton.Controls.Add(this.comboBox_switchTable);
            this.panel_listButton.Controls.Add(this.btn_switchTable);
            this.panel_listButton.Controls.Add(this.amount_discount);
            this.panel_listButton.Controls.Add(this.btn_discount);
            this.panel_listButton.Controls.Add(this.btn_checkOut);
            this.panel_listButton.Location = new System.Drawing.Point(600, 584);
            this.panel_listButton.Name = "panel_listButton";
            this.panel_listButton.Size = new System.Drawing.Size(448, 58);
            this.panel_listButton.TabIndex = 3;
            // 
            // label_totalPrice
            // 
            this.label_totalPrice.AutoSize = true;
            this.label_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_totalPrice.Location = new System.Drawing.Point(252, 9);
            this.label_totalPrice.Name = "label_totalPrice";
            this.label_totalPrice.Size = new System.Drawing.Size(52, 13);
            this.label_totalPrice.TabIndex = 10;
            this.label_totalPrice.Text = "Tổng tiền";
            this.label_totalPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbox_totalPrice
            // 
            this.txtbox_totalPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtbox_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbox_totalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtbox_totalPrice.Location = new System.Drawing.Point(227, 28);
            this.txtbox_totalPrice.Name = "txtbox_totalPrice";
            this.txtbox_totalPrice.ReadOnly = true;
            this.txtbox_totalPrice.Size = new System.Drawing.Size(106, 21);
            this.txtbox_totalPrice.TabIndex = 9;
            this.txtbox_totalPrice.Text = "0";
            this.txtbox_totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_switchTable
            // 
            this.comboBox_switchTable.FormattingEnabled = true;
            this.comboBox_switchTable.Location = new System.Drawing.Point(3, 32);
            this.comboBox_switchTable.Name = "comboBox_switchTable";
            this.comboBox_switchTable.Size = new System.Drawing.Size(106, 21);
            this.comboBox_switchTable.TabIndex = 5;
            // 
            // btn_switchTable
            // 
            this.btn_switchTable.Location = new System.Drawing.Point(3, 3);
            this.btn_switchTable.Name = "btn_switchTable";
            this.btn_switchTable.Size = new System.Drawing.Size(106, 24);
            this.btn_switchTable.TabIndex = 8;
            this.btn_switchTable.Text = "Chuyển bàn";
            this.btn_switchTable.UseVisualStyleBackColor = true;
            this.btn_switchTable.Click += new System.EventHandler(this.button1_Click);
            // 
            // amount_discount
            // 
            this.amount_discount.Location = new System.Drawing.Point(115, 33);
            this.amount_discount.Name = "amount_discount";
            this.amount_discount.Size = new System.Drawing.Size(106, 20);
            this.amount_discount.TabIndex = 7;
            this.amount_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_discount
            // 
            this.btn_discount.Location = new System.Drawing.Point(115, 3);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.Size = new System.Drawing.Size(106, 24);
            this.btn_discount.TabIndex = 6;
            this.btn_discount.Text = "Giảm giá";
            this.btn_discount.UseVisualStyleBackColor = true;
            // 
            // btn_checkOut
            // 
            this.btn_checkOut.Location = new System.Drawing.Point(339, 3);
            this.btn_checkOut.Name = "btn_checkOut";
            this.btn_checkOut.Size = new System.Drawing.Size(106, 52);
            this.btn_checkOut.TabIndex = 5;
            this.btn_checkOut.Text = "Thanh toán";
            this.btn_checkOut.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.btn_addMenu);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.combobox_categories);
            this.panel4.Location = new System.Drawing.Point(600, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 55);
            this.panel4.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(364, 19);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_addMenu
            // 
            this.btn_addMenu.Location = new System.Drawing.Point(252, 3);
            this.btn_addMenu.Name = "btn_addMenu";
            this.btn_addMenu.Size = new System.Drawing.Size(106, 48);
            this.btn_addMenu.TabIndex = 3;
            this.btn_addMenu.Text = "Thêm món";
            this.btn_addMenu.UseVisualStyleBackColor = true;
            this.btn_addMenu.Click += new System.EventHandler(this.btn_addMenu_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // combobox_categories
            // 
            this.combobox_categories.FormattingEnabled = true;
            this.combobox_categories.Location = new System.Drawing.Point(3, 3);
            this.combobox_categories.Name = "combobox_categories";
            this.combobox_categories.Size = new System.Drawing.Size(243, 21);
            this.combobox_categories.TabIndex = 1;
            // 
            // flowLayoutPanel_listTable
            // 
            this.flowLayoutPanel_listTable.Location = new System.Drawing.Point(6, 46);
            this.flowLayoutPanel_listTable.Name = "flowLayoutPanel_listTable";
            this.flowLayoutPanel_listTable.Size = new System.Drawing.Size(591, 596);
            this.flowLayoutPanel_listTable.TabIndex = 5;
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_close.Image = global::Login.Properties.Resources.close;
            this.pictureBox_close.Location = new System.Drawing.Point(1031, 0);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_close.TabIndex = 6;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // fManageTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1055, 649);
            this.Controls.Add(this.pictureBox_close);
            this.Controls.Add(this.flowLayoutPanel_listTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_listButton);
            this.Controls.Add(this.panel_listReceipt);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "fManageTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fManageTable_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel_listReceipt.ResumeLayout(false);
            this.panel_listButton.ResumeLayout(false);
            this.panel_listButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount_discount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel_listReceipt;
        private System.Windows.Forms.ListView listview_Receipt;
        private System.Windows.Forms.Panel panel_listButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox combobox_categories;
        private System.Windows.Forms.Button btn_addMenu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_switchTable;
        private System.Windows.Forms.NumericUpDown amount_discount;
        private System.Windows.Forms.Button btn_discount;
        private System.Windows.Forms.Button btn_checkOut;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_listTable;
        private System.Windows.Forms.ComboBox comboBox_switchTable;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.ColumnHeader columnHeader_idFood;
        private System.Windows.Forms.ColumnHeader columnHeader_numberOfFood;
        private System.Windows.Forms.ColumnHeader columnHeader_price;
        private System.Windows.Forms.ColumnHeader columnHeader_totalPrice;
        private System.Windows.Forms.Label label_totalPrice;
        private System.Windows.Forms.TextBox txtbox_totalPrice;
    }
}