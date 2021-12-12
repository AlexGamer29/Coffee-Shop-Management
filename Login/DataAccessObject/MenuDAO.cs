using Login.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataAccessObject
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int idTable)
        {
            List<Menu> listMenu = new List<Menu>();
            //string query = "SELECT Menu.name, ReceiptInfo.numberOfFood, Menu.price, Menu.price*ReceiptInfo.numberOfFood AS totalPrice FROM dbo.ReceiptInfo AS ReceiptInfo, dbo.Receipt AS Receipt, dbo.Menu AS Menu WHERE ReceiptInfo.idReceipt = Receipt.id AND ReceiptInfo.idMenu = Menu.id AND Receipt.STATUS = 0 AND Receipt.idTable = " + idTable;
            string query = "USERPROC_GetListMenuByTable @idTable";
            DataTable data = DataAccess.Instance.ExecuteQuery(query, new object[] { idTable });

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
