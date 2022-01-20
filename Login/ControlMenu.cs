using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layout;
using Telerik.WinControls.UI;
using Login.DataAccessObject;
using Login.DataTransferObject;

namespace Login
{
    public class ControlMenu : IElementModify, IControl
    {
        public void GridView_ElementModifyAttribute(RadGridView gridView)
        {
            gridView.Columns["id"].HeaderText = "ID";
            gridView.Columns["name"].HeaderText = "Tên món";
            gridView.Columns["IdCategories"].HeaderText = "Mã danh mục";
            gridView.Columns["Price"].HeaderText = "Giá món";
            gridView.Columns["ID"].TextAlignment = ContentAlignment.MiddleCenter;
            gridView.Columns["name"].TextAlignment = ContentAlignment.MiddleLeft;
            gridView.Columns["IdCategories"].TextAlignment = ContentAlignment.MiddleCenter;
            gridView.Columns["Price"].TextAlignment = ContentAlignment.MiddleCenter;
        }

        public void LoadDateTimePickerReceipt(RadDateTimePicker fromDate, RadDateTimePicker toDate)
        {
            throw new NotImplementedException();
        }

        public void LoadListObject(BindingSource source)
        {
            source.DataSource = FoodDAO.Instance.GetListFood();
        }

        public void LoadListReceiptByDate(RadGridView gridView, DateTime arrivalDate, DateTime departDate)
        {
            throw new NotImplementedException();
        }

        public void LoadObjectIntoComboBox(ComboBox combo)
        {
            combo.DataSource = CategoryDAO.Instance.GetListCategory();
            combo.DisplayMember = "Name";
        }

        public void ObjectBinding(RadGridView gridView)
        {
            throw new NotImplementedException();
        }

        public List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }
    }
}
