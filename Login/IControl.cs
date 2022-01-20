using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Login
{
    public interface IControl
    {
        void LoadListObject(BindingSource source);
        void ObjectBinding(RadGridView gridView);
        void LoadObjectIntoComboBox(ComboBox combo);
        void LoadDateTimePickerReceipt(RadDateTimePicker fromDate, RadDateTimePicker toDate);
        void LoadListReceiptByDate(RadGridView gridView, DateTime arrivalDate, DateTime departDate);
    }
}
