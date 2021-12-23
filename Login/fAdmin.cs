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

        public fAdmin()
        {
            InitializeComponent();
            LoadMethods();
        }

        void LoadMethods()
        {
            dataGridView_account.DataSource = accountList;

            LoadMenu();
            //LoadAccountList();
            AddAccountBinding();
            LoadAccount();
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

        private void btn_search_Click(object sender, EventArgs e)
        {
        }

        private void btn_viewAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
    }
}
