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

        public List<ReceiptInfo> GetListReceiptInfo(int id)
        {
            List<ReceiptInfo> listReceiptInfo = new List<ReceiptInfo> ();
            string query = "SELECT * FROM dbo.ReceiptInfo WHERE idReceipt = " + id;
            DataTable data = DataAccess.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ReceiptInfo info = new ReceiptInfo(item);
                listReceiptInfo.Add(info);
            }
            return listReceiptInfo;
        }
    }
}
