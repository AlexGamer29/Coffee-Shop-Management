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
using Menu = Login.DataTransferObject.Menu;

namespace Login
{
    public partial class fManageTable : Form
    {
        public fManageTable()
        {
            InitializeComponent();
            LoadTable();
        }

        #region Methods
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
            List<Menu> listReceiptInfo = MenuDAO.Instance.GetListMenuByTable(id);
            foreach (Menu item in listReceiptInfo)
            {
                ListViewItem listItem = new ListViewItem(item.FoodName.ToString());
                listItem.SubItems.Add(item.Count.ToString());
                listItem.SubItems.Add(item.Price.ToString());
                listItem.SubItems.Add(item.TotalPrice.ToString());
                listview_Receipt.Items.Add(listItem);
            }
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
            fAccountProfile accountProfile = new fAccountProfile();
            accountProfile.ShowDialog();
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
