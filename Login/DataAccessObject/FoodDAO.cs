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
    }
}
