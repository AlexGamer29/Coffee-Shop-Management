using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Login
{

    public class DataAccess
    {
        private static DataAccess instance;
        //private string ConnectionString = "Data Source=LAPTOP-3COKBC5G;Initial Catalog=CoffeeShop;Integrated Security=True";
        //private string ConnectionString = "Data Source=LAPTOP-TJQFN4F8;Initial Catalog=CoffeeShop;Integrated Security=True";
        //private string ConnectionString = "Data Source=DESKTOP-GRVMPUG;Initial Catalog=CoffeeShop;Integrated Security=True";
        //thế tên lap vào LAPTOP-TJQFN4F8
        private string ConnectionString = "Data Source=14.243.50.116;Initial Catalog=CoffeeShop;User ID=oop;Password=admin";


        public static DataAccess Instance
        {
            get { if (instance == null) instance = new DataAccess(); return DataAccess.instance; }
            private set { DataAccess.instance = value; }
        }

        private DataAccess() { }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int excutedLines = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                excutedLines = command.ExecuteNonQuery();
                connection.Close();
            }
            return excutedLines;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object excutedLines = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                excutedLines = command.ExecuteScalar();
                connection.Close();
            }
            return excutedLines;
        }
    }
}