using Login.DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layout;
using Telerik.WinControls.UI;


namespace Login
{
    public class ControlRevenue : IControl
    {
        public void LoadDateTimePickerReceipt(RadDateTimePicker fromDate, RadDateTimePicker toDate)
        {
            DateTime time = DateTime.Now;
            fromDate.Value = new DateTime(time.Year, time.Month, 1);
            toDate.Value = fromDate.Value.AddMonths(1).AddDays(-1);
        }

        public void LoadListObject(BindingSource source)
        {
            throw new NotImplementedException();
        }

        public void LoadListReceiptByDate(RadGridView gridView, DateTime arrivalDate, DateTime departDate)
        {
            gridView.DataSource = ReceiptDAO.Instance.GetReceiptListByDate(arrivalDate, departDate);
        }

        public void LoadObjectIntoComboBox(ComboBox combo)
        {
            throw new NotImplementedException();
        }

        public void ObjectBinding(RadGridView gridView)
        {
            throw new NotImplementedException();
        }

        public void TotalRevenueDaily(RadGridView gridView)
        {
            GridViewSummaryItem summaryItemName = new GridViewSummaryItem("name", "Tổng hóa đơn  =  {0}", GridAggregateFunction.Count);
            GridViewSummaryItem summaryItemTotalRevenue = new GridViewSummaryItem("totalPrice", "Tổng doanh thu  =  {0}", GridAggregateFunction.Sum);
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem(new GridViewSummaryItem[] { summaryItemName, summaryItemTotalRevenue });
            gridView.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Float;
            gridView.SummaryRowsBottom.Add(summaryRowItem);
        }
    }
}
