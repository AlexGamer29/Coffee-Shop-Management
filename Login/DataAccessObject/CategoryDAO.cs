using Login.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataAccessObject
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "USERPROC_GetListCategory";

            DataTable data = DataAccess.Instance.ExecuteQuery(query);

            foreach (DataRow dr in data.Rows)
            {
                Category category = new Category(dr);
                list.Add(category);
            }
            return list;
        }
        public Category GetCategoryByID(int id)
        {
            Category category = null;
            string query = "USERPROC_GetCategoryByID @id";

            DataTable data = DataAccess.Instance.ExecuteQuery(query, new object[] { id });

            foreach (DataRow dr in data.Rows)
            {
                category = new Category(dr);
                return category;
            }
            return category;
        }

        public bool AddCategory(string name)
        {
            string query = string.Format("INSERT dbo.Categories ( name ) VALUES (N'{0}')", name);
            int result = DataAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCategory(string name, int idCategory)
        {
            string query = string.Format("UPDATE dbo.Categories SET name = N'{0}' WHERE id = {1}", name, idCategory);
            int result = DataAccess.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteCategory(int idCategory)
        {
            string query = string.Format("DELETE dbo.Categories WHERE id = {0}", idCategory);
            int result = DataAccess.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
