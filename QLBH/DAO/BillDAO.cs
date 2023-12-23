using QLBH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        string filePath = @"D:\Long Le\QLBH\Bill.txt";

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }
        public Request getBill()
        {
            Request request = new Request();
            List<Bill> list = new List<Bill>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    Bill bill = null;
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(':');
                        if (parts.Length == 2)
                        {
                            string key = parts[0].Trim();
                            string value = parts[1].Trim();

                            if (key == "id")
                            {
                                if (bill != null)
                                {
                                    list.Add(bill);
                                }
                                bill = new Bill { Id = value };
                            }
                            else if (bill != null)
                            {
                                switch (key)
                                {
                                    case "date":
                                        bill.Date = DateTime.Parse(value);
                                        break;
                                    case "foodlist":
                                        while ((line = reader.ReadLine()) != null && !string.IsNullOrEmpty(line))
                                        {
                                            bill.FoodList.Add(line.Trim());
                                        }
                                        break;
                                    case "price":
                                        bill.Price = decimal.Parse(value);
                                        break;
                                    case "discount":
                                        bill.Discount = decimal.Parse(value);
                                        break;
                                    case "total":
                                        bill.Total = decimal.Parse(value);
                                        break;
                                }
                            }
                        }
                    }

                    if (bill != null)
                    {
                        list.Add(bill); 
                    }
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

        public bool createBill(Bill bill)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{BillTable.BILL_ID}: {bill.Id}");
                    writer.WriteLine($"{BillTable.BILL_DATE}: {bill.Date.ToString()}");
                    writer.WriteLine($"{BillTable.BILL_FOODLIST}:");
                    bill.FoodList.ForEach(item =>
                    {
                        writer.WriteLine($"{item}");
                    });
                    writer.WriteLine($"{BillTable.BILL_PRICE}: {bill.Price.ToString()}");
                    writer.WriteLine($"{BillTable.BILL_DISCOUNT}: {bill.Discount.ToString()}");
                    writer.WriteLine($"{BillTable.BILL_TOTAL}: {bill.Total.ToString()}");
                    writer.Close();
                }
                return true;
            }
            catch { return false; }
            
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
