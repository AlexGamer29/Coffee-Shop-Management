using Login.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataAccessObject
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static int TableWidth = 140;
        public static int TableHeight = 140;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        private TableDAO() { }

        public void SwitchTable(int id1, int id2)
        {
            DataAccess.Instance.ExecuteQuery("USERPROC_SwitchTable @idTable1 , @idTable2", new object[] { id1, id2 });
        }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataAccess.Instance.ExecuteQuery("USERPROC_GetTableList");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public bool AddTable(string name, string tableStatus)
        {
            string query = string.Format("INSERT dbo.CoffeeTable ( name, tableStatus ) VALUES (N'{0}', N'{1}')", name, tableStatus);
            int result = DataAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateTable(string name, string tableStatus, int idTable)
        {
            string query = string.Format("UPDATE dbo.CoffeeTable SET name = N'{0}', tableStatus = N'{1}' WHERE id = {2}", name, tableStatus, idTable);
            int result = DataAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteTable(int idTable)
        {
            string query = string.Format("DELETE dbo.CoffeeTable WHERE id = {0}", idTable);
            int result = DataAccess.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
