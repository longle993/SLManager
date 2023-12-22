using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DTO
{
    public class Food
    {
        string id;
        string name;
        string type;
        decimal price;
        string imagePath;

        public Food(string id, string name, string type, decimal price, string imagePath)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.price = price;
            this.imagePath = imagePath;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public decimal Price { get => price; set => price = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
    }
}
