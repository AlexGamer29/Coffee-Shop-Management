using Login.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataAccessObject
{
    public class ReceiptDAO
    {
        private static ReceiptDAO instance;

        public static ReceiptDAO Instance
        {
            get { if (instance == null) instance = new ReceiptDAO(); return ReceiptDAO.instance; }
            private set { ReceiptDAO.instance = value; }
        }

        private ReceiptDAO() { }

        /// <summary>
        /// Return receipt.ID if query is success or return -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUncheckReceiptIDByTableID(int id)
        {
            string query = "SELECT * FROM dbo.Receipt WHERE idTable = " + id +" AND STATUS = 0";
            DataTable data = DataAccess.Instance.ExecuteQuery(query);
            if(data.Rows.Count > 0)
            {
                Receipt receipt = new Receipt(data.Rows[0]);
                return receipt.ID;
            }
            return -1;
        }
    }
}
