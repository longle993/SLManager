using QLBH.DAO;
using QLBH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.BUS
{
    public class FoodBUS
    {
        private static FoodBUS instance;
        public static FoodBUS Instance
        {
            get { if (instance == null) instance = new FoodBUS(); return instance; }
            private set { instance = value; }
        }
        public bool createFood(Food food,string imagePath)
        {
            return FoodDAO.Instance.createFood(food,imagePath);
        }
        public bool updateFood(Food updatedFood,string imagePath, bool isSetImg)
        {
            return FoodDAO.Instance.updateFood(updatedFood,imagePath, isSetImg);
        }
        public Request getFood()
        {
            return FoodDAO.Instance.getFood();
        }
        public Request getFoodById(string foodid)
        {
            return FoodDAO.Instance.getFoodById(foodid);
        }
    }
}
