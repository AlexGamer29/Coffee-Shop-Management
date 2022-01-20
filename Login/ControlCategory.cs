using Login.DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Login
{
    public class ControlCategory : IElementModify, IControl
    {
        public void GridView_ElementModifyAttribute(RadGridView gridView)
        {
            gridView.Columns["id"].HeaderText = "ID";
            gridView.Columns["name"].HeaderText = "Tên bàn";
            gridView.Columns["id"].TextAlignment = ContentAlignment.MiddleCenter;
            gridView.Columns["name"].TextAlignment = ContentAlignment.MiddleLeft;
            gridView.Columns["name"].HeaderTextAlignment = ContentAlignment.MiddleLeft;
        }

        public void LoadDateTimePickerReceipt(RadDateTimePicker fromDate, RadDateTimePicker toDate)
        {
            throw new NotImplementedException();
        }

        public void LoadListObject(BindingSource source)
        {
            source.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        public void LoadListReceiptByDate(RadGridView gridView, DateTime arrivalDate, DateTime departDate)
        {
            throw new NotImplementedException();
        }

        public void LoadObjectIntoComboBox(ComboBox combo)
        {
            throw new NotImplementedException();
        }

        public void ObjectBinding(RadGridView gridView)
        {
            throw new NotImplementedException();
        }
    }
}
