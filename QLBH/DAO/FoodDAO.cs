using Microsoft.VisualBasic;
using QLBH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace QLBH.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        string filePath = @"D:\Long Le\QLBH\Food.txt";


        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return instance; }
            private set { instance = value; }
        }
        public bool createFood(Food food,string imagePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{FoodTable.FOOD_ID}: {food.Id}");
                    writer.WriteLine($"{FoodTable.FOOD_NAME}: {food.Name}");
                    writer.WriteLine($"{FoodTable.FOOD_TYPE}: {food.Type}");
                    writer.WriteLine($"{FoodTable.FOOD_PRICE}: {food.Price}");
                    writer.WriteLine($"{FoodTable.FOOD_IMAGE}: {food.ImagePath}");
                    File.Copy(imagePath, food.ImagePath, true);

                    writer.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool updateFood(Food updatedFood,string imagePath, bool isSetImg)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].StartsWith($"id: {updatedFood.Id}"))
                        {
                            writer.WriteLine($"{FoodTable.FOOD_ID}: {updatedFood.Id}");
                            writer.WriteLine($"{FoodTable.FOOD_NAME}: {updatedFood.Name}");
                            writer.WriteLine($"{FoodTable.FOOD_TYPE}: {updatedFood.Type}");
                            writer.WriteLine($"{FoodTable.FOOD_PRICE}: {updatedFood.Price}");

                            if (isSetImg)
                            {
                                writer.WriteLine($"{FoodTable.FOOD_IMAGE}: {updatedFood.ImagePath}");
                                File.Copy(imagePath, updatedFood.ImagePath, true);
                            }
                            else
                            {
                                writer.WriteLine(lines[i + 4]);
                            }

                            return true; 
                        }
                        writer.WriteLine(lines[i]);
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Request getFood()
        {
            Request request = new Request();
            List<Food> list = new List<Food>();
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i += 5)
                {
                    string id = GetValueFromLine(lines[i]);
                    string name = GetValueFromLine(lines[i + 1]);
                    string type = GetValueFromLine(lines[i + 2]);
                    string price = GetValueFromLine(lines[i + 3]);
                    decimal convertPrice = Convert.ToDecimal(price);
                    string imagePath = GetValueFromLine(lines[i + 4]);

                    Food food = new Food(id, name, type, convertPrice, imagePath);
                    list.Add(food);
                }
                if (list.Count > 0)
                {
                    request.IsSuccess = true;
                    request.Message = null;
                    request.Data = list;
                }
                else
                {
                    request.IsSuccess = false;
                    request.Message = null;
                    request.Data = null;
                }
            }
            catch (Exception ex)
            {
                request.IsSuccess = false;
                request.Message = ex.Message;
                request.Data = null;
            }
            return request;
        }
        public Request getFoodById(string foodid)
        {
            Request request = new Request();
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i += 5)
                {
                    string id = GetValueFromLine(lines[i]);
                    if (id == foodid)
                    {
                        string name = GetValueFromLine(lines[i + 1]);
                        string type = GetValueFromLine(lines[i + 2]);
                        string price = GetValueFromLine(lines[i + 3]);
                        decimal convertPrice = Convert.ToDecimal(price);
                        string imagePath = GetValueFromLine(lines[i + 4]);

                        Food food = new Food(id, name, type, convertPrice, imagePath);
                        request.IsSuccess = true;
                        request.Data = food;
                        request.Message = null;
                        return request;
                    }
                }

                request.IsSuccess = false;
                request.Message = "Không tìm thấy món ăn có ID đã cho.";
                request.Data = null;
            }
            catch (Exception ex)
            {
                request.IsSuccess = false;
                request.Message = ex.Message;
                request.Data = null;
            }
            return request;
        }
        public bool deletePhoto(string imgPath)
        {
            if (File.Exists(imgPath))
            {
                File.Delete(imgPath);
                return true;
            }
            return false;
        }
        private string GetValueFromLine(string line)
        {
            int index = line.IndexOf(':');
            if (index >= 0 && index + 1 < line.Length)
            {
                return line.Substring(index + 1).Trim();
            }
            return string.Empty;
        }
    }
}
