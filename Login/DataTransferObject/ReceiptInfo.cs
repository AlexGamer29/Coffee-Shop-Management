using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataTransferObject
{
    public class ReceiptInfo
    {
        private int iD;
        private int idReceipt;
        private int idMenu;
        private int numberOfFood;

        public int ID { get => iD; set => iD = value; }
        public int IdReceipt { get => idReceipt; set => idReceipt = value; }
        public int IdMenu { get => idMenu; set => idMenu = value; }
        public int NumberOfFood { get => numberOfFood; set => numberOfFood = value; }
        public static object Instance { get; internal set; }

        public ReceiptInfo(int id, int idReceipt, int idMenu, int numberOfFood)
        {
            this.ID = id;
            this.IdReceipt = idReceipt;
            this.IdMenu = idMenu;
            this.NumberOfFood = numberOfFood;
        }

        public ReceiptInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IdReceipt = (int)row["idReceipt"];
            this.IdMenu = (int)row["idMenu"];
            this.NumberOfFood = (int)row["numberOfFood"];

        }
    }
}
