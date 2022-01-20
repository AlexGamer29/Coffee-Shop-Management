using Login.DataAccessObject;
using Login.DataTransferObject;
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
    public class ControlDashboard : IControl
    {
        public void LoadDateTimePickerReceipt(RadDateTimePicker fromDate, RadDateTimePicker toDate)
        {
            throw new NotImplementedException();
        }

        public void LoadListObject(BindingSource source)
        {
            throw new NotImplementedException();
        }

        public void LoadListReceiptByDate(RadGridView gridView, DateTime arrivalDate, DateTime departDate)
        {
            throw new NotImplementedException();
        }

        public void LoadObjectIntoComboBox(ComboBox combo)
        {
            List<Category> categories = CategoryDAO.Instance.GetListCategory();
            combo.DataSource = categories;
            combo.DisplayMember = "Name";
        }

        public void LoadComboBoxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        public void ObjectBinding(RadGridView gridView)
        {
            throw new NotImplementedException();
        }
    }
}
