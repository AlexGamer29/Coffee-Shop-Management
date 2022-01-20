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
    public class EmployeeControl : IElementModify, IControl
    {
        public void GridView_ElementModifyAttribute(RadGridView gridView)
        {
            gridView.Columns["username"].HeaderText = "Tên đăng nhập";
            gridView.Columns["displayname"].HeaderText = "Họ và tên";
            gridView.Columns["accountType"].HeaderText = "Trạng thái";
            gridView.Columns["username"].TextAlignment = ContentAlignment.MiddleLeft;
            gridView.Columns["displayname"].TextAlignment = ContentAlignment.MiddleLeft;
            gridView.Columns["accountType"].TextAlignment = ContentAlignment.MiddleCenter;
            gridView.Columns["username"].HeaderTextAlignment = ContentAlignment.MiddleLeft;
            gridView.Columns["displayname"].HeaderTextAlignment = ContentAlignment.MiddleLeft;
        }

        public void LoadDateTimePickerReceipt(RadDateTimePicker fromDate, RadDateTimePicker toDate)
        {
            throw new NotImplementedException();
        }

        public void LoadListObject(BindingSource source)
        {
            source.DataSource = AccountDAO.Instance.GetListAccount();
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
