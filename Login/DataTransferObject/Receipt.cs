using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataTransferObject
{
    public class Receipt
    {
        private int iD;
        private DateTime? arrivalDate;
        private DateTime? departDate;
        private int status;

        public int ID { get => iD; set => iD = value; }
        public DateTime? ArrivalDate { get => arrivalDate; set => arrivalDate = value; }
        public DateTime? DepartDate { get => departDate; set => departDate = value; }
        public int Status { get => status; set => status = value; }

        public int Discount { get => Discount; set => Discount = value; }
        public Receipt(int id, DateTime? arrivalDate, DateTime? departDate, int status, int discount)
        {
            this.ID = id;
            this.ArrivalDate = arrivalDate;
            this.DepartDate = departDate;
            this.Status = status;
            this.Discount = discount;
        }

        public Receipt(DataRow row)
        {
            this.ID = (int) row["id"];
            this.ArrivalDate = (DateTime?) row["arrivalDate"];
            var departDateTemp = row["departDate"];
            if (departDateTemp.ToString() != "")
                this.DepartDate = (DateTime?)departDateTemp;
            this.Status = (int)row["status"];
            if (Discount.ToString() != "")
            {
                Discount = (int)Discount;
            }
        }
    }
}
