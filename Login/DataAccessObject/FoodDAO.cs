using Login.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataAccessObject
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        private object id;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();
            string query = "SELECT * FROM Menu WHERE idCategories = " + id;
            // Nhớ thêm store proc sql

            DataTable data = DataAccess.Instance.ExecuteQuery(query);

            foreach (DataRow dr in data.Rows)
            {
                Food food = new Food(dr);
                list.Add(food);

            }
            return list;
        }

        public List<Food> GetListFood()
        {
            List<Food> listFood = new List<Food>();
            //string query = "SELECT Menu.name, ReceiptInfo.numberOfFood, Menu.price, Menu.price*ReceiptInfo.numberOfFood AS totalPrice FROM dbo.ReceiptInfo AS ReceiptInfo, dbo.Receipt AS Receipt, dbo.Menu AS Menu WHERE ReceiptInfo.idReceipt = Receipt.id AND ReceiptInfo.idMenu = Menu.id AND Receipt.STATUS = 0 AND Receipt.idTable = " + idTable;
            string query = "SELECT * FROM Menu";
            //Thieu procedure
            DataTable data = DataAccess.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food menu = new Food(item);
                listFood.Add(menu);
            }
            return listFood;
        }

        public bool InsertFood(string name, int id, float price)
        {
           string query = string.Format("INSERT dbo.Menu ( name, idCategories, price ) VALUES (N'{0}', {1}, {2})", name, id, price);
           int result = DataAccess.Instance.ExecuteNonQuery(query);
           return result > 0;
        }
        public bool UpdateFood(string name, int idFood, float price, int id)
        {
            string query = string.Format("UPDATE dbo.Menu SET name = N'{0}', idCategories = {1}, price = {2} WHERE id = {3}", name, idFood , price, id);
            int result = DataAccess.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteFood(int idFood)
        {
            ReceiptInfoDAO.Instance.DeleteReceiptInfoByFoodID(idFood);
            string query = string.Format("DELETE Food WHERE id ={0}", idFood);
            int result = DataAccess.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        //internal bool DeleteFood(int id)
        //{
         //   throw new NotImplementedException();
        //}
    }
}
