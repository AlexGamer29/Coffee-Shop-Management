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
        /// <param name="idTable"></param>
        /// <returns></returns>
        public int GetUncheckReceiptIDByTableID(int idTable)
        {
            //string query = "SELECT * FROM dbo.Receipt WHERE idTable = " + idTable + " AND STATUS = 0";
            string query = "USERPROC_GetUncheckReceiptIDByTableID @idTable";
            DataTable data = DataAccess.Instance.ExecuteQuery(query, new object[] { idTable });
            if(data.Rows.Count > 0)
            {
                Receipt receipt = new Receipt(data.Rows[0]);
                return receipt.ID;
            }
            return -1;
        }
    }
}
