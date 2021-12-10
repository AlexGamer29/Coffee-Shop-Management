using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataTransferObject
{
    public class Menu
    {
        private string name;
        private int numberOfFood;
        private float price;
        private float totalPrice;

        public string FoodName { get => name; set => name = value; }
        public int Count { get => numberOfFood; set => numberOfFood = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }

        public Menu(string name, int numberOfFood, float price, float totalPrice = 0)
        {
            this.FoodName = name;
            this.Count = numberOfFood;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.FoodName = row["name"].ToString();
            this.Count = (int)row["numberOfFood"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }
    }
}
