using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DTO
{
    public class Bill
    {
        string id;
        DateTime date;
        List<string> foodList = new List<string>();
        decimal price;
        decimal discount;
        decimal total;

        public string Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public List<string> FoodList { get => foodList; set => foodList = value; }
        public decimal Price { get => price; set => price = value; }
        public decimal Discount { get => discount; set => discount = value; }
        public decimal Total { get => total; set => total = value; }

        public Bill(string id, DateTime date, List<string> foodList, decimal price, decimal discount, decimal total)
        {
            this.id = id;
            this.date = date;
            this.foodList = foodList;
            this.price = price;
            this.discount = discount;
            this.total = total;
        }
        public Bill() { }

    }
}
