using Login.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataAccessObject
{
    public class ReceiptInfoDAO
    {
        private static ReceiptInfoDAO instance;

        public static ReceiptInfoDAO Instance
        {
            get { if (instance == null) instance = new ReceiptInfoDAO(); return ReceiptInfoDAO.instance; }
            private set { ReceiptInfoDAO.instance = value;  }
        }

        private ReceiptInfoDAO() { }

        public List<ReceiptInfo> GetListReceiptInfo(int idTable)
        {
            List<ReceiptInfo> listReceiptInfo = new List<ReceiptInfo> ();
            //string query = "SELECT * FROM dbo.ReceiptInfo WHERE idReceipt = " + idTable;
            string query = "USERPROC_GetListReceiptInfo @idTable";
            DataTable data = DataAccess.Instance.ExecuteQuery(query, new object[] { idTable });
            foreach (DataRow item in data.Rows)
            {
                ReceiptInfo info = new ReceiptInfo(item);
                listReceiptInfo.Add(info);
            }
            return listReceiptInfo;
        }

        public void InsertReceiptInfo(int idReceipt, int idMenu, int numberOfFood)
        {
            DataAccess.Instance.ExecuteNonQuery("EXEC USERPROC_InsertReceiptInfo @idReceipt, @idMenu, @numberOfFood", new object[]{ idReceipt, idMenu, numberOfFood});
        }
    }
}
