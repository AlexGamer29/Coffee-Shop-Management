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

namespace Login
{
    public partial class fLogin : Form
    {

        SqlConnection connection = new SqlConnection();
        public fLogin()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-GRVMPUG;Initial Catalog=CoffeeShop;Integrated Security=True";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = "Data Source=DESKTOP-GRVMPUG;Initial Catalog=CoffeeShop;Integrated Security=True";
            connection.Open();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-GRVMPUG;Initial Catalog=CoffeeShop;Integrated Security=True";
            connection.Open();

            string username = txtbox_user.Text;
            string password = txtbox_password.Text;
            SqlCommand cmd = new SqlCommand("SELECT userName, password FROM Account WHERE username='" + txtbox_user.Text + "' AND password='" + txtbox_password.Text + "'", connection);
            SqlDataAdapter inputData = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            inputData.Fill(data);
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                fManageTable formManageTable = new fManageTable();
                this.Hide();
                formManageTable.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");

            }
            connection.Close();
        }

        private void txtbox_user_Click(object sender, EventArgs e)
        {
            txtbox_user.BackColor = Color.White;
            panel_user.BackColor = Color.White;
            panel_password.BackColor = SystemColors.Control;
            txtbox_password.BackColor = SystemColors.Control;
        }

        private void user_logo_Click(object sender, EventArgs e)
        {

        }

        private void password_logo_MouseDown(object sender, MouseEventArgs e)
        {
            txtbox_password.UseSystemPasswordChar = false;
        }

        private void password_logo_MouseUp(object sender, MouseEventArgs e)
        {
            txtbox_password.UseSystemPasswordChar = true;
        }
        
        private void txtbox_password_Click(object sender, EventArgs e)
        {
            txtbox_password.BackColor = Color.White;
            panel_password.BackColor = Color.White;
            txtbox_user.BackColor = SystemColors.Control;
            panel_user.BackColor = SystemColors.Control;
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
