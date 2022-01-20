using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using Login.DataAccessObject;

namespace Login
{
    public class ControlTable : IElementModify, IControl
    {
        public void GridView_ElementModifyAttribute(RadGridView gridView)
        {
            gridView.Columns["id"].HeaderText = "ID";
            gridView.Columns["name"].HeaderText = "Tên bàn";
            gridView.Columns["tableStatus"].HeaderText = "Trạng thái";
            gridView.Columns["id"].TextAlignment = ContentAlignment.MiddleCenter;
            gridView.Columns["name"].TextAlignment = ContentAlignment.MiddleLeft;
            gridView.Columns["tableStatus"].TextAlignment = ContentAlignment.MiddleLeft;
            gridView.Columns["name"].HeaderTextAlignment = ContentAlignment.MiddleLeft;
            gridView.Columns["tableStatus"].HeaderTextAlignment = ContentAlignment.MiddleLeft;
        }

        public void LoadDateTimePickerReceipt(RadDateTimePicker fromDate, RadDateTimePicker toDate)
        {
            throw new NotImplementedException();
        }

        public void LoadListObject(BindingSource source)
        {
            source.DataSource = TableDAO.Instance.LoadTableList();
        }

        public void LoadListReceiptByDate(RadGridView gridView, DateTime arrivalDate, DateTime departDate)
        {
            throw new NotImplementedException();
        }

        public void LoadObjectIntoComboBox(ComboBox combo)
        {
            combo.DataSource = TableDAO.Instance.LoadTableList();
            combo.DisplayMember = "tableStatus";
        }

        public void ObjectBinding(RadGridView gridView)
        {
            throw new NotImplementedException();
        }
    }
}
