using QLBH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        string filePath = ConnectionString.ConnectToFile("Account.txt");


        public static AccountDAO Instance
        {
            get { if(instance  == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
 

        public bool createAccount(Account account)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath,true))
                {
                    writer.WriteLine($"{AccountTable.ACCOUNT_ID}: {account.Id}");
                    writer.WriteLine($"{AccountTable.ACCOUNT_NAME}: {account.Name}");
                    writer.WriteLine($"{AccountTable.ACCOUNT_PHONE}: {account.Phone}");
                    writer.WriteLine($"{AccountTable.ACCOUNT_BIRTH}: {account.Birth.ToString("dd/MM/yyyy")}");
                    writer.WriteLine($"{AccountTable.ACCOUNT_PASSWORD}: {account.Password}");

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

        public Request login(string inputPhone, string inputPassword)
        {
            Request request = new Request();
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i += 5)
                {
                    string phone = lines[i + 2].Split(':')[1].Trim();
                    string password = lines[i + 4].Split(':')[1].Trim();

                    if (phone == inputPhone && password == inputPassword)
                    {
                        string id = lines[i].Split(':')[1].Trim();
                        request.IsSuccess = true;
                        request.Data = id;
                        request.Message = null;
                        return request;
                    }
                }
                Request failRequest = new Request(false, null, "Thông tin đăng nhập không hợp lệ");
                return failRequest;
            }
            catch (Exception ex)
            {
                request.IsSuccess = false;
                request.Data = null;
                request.Message = ex.Message;
                return request;
            }

            return request;
        }
        public Request getUser(string inputId)
        {
            Request request = new Request();
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i += 5)
                {
                    string id = lines[i].Split(':')[1].Trim();

                    if (inputId == id)
                    {
                        string name = lines[i + 1].Split(':')[1].Trim();
                        string phone = lines[i + 2].Split(':')[1].Trim();
                        string birth = lines[i + 3].Split(':')[1].Trim();
                        DateTime convertBirth = new DateTime();
                        convertBirth = convertBirthDay(birth, convertBirth);
                        string password = lines[i + 4].Split(':')[1].Trim();
                        Account account = new Account(id, name, convertBirth, password, phone);
                        request.IsSuccess = true;
                        request.Message = null;
                        request.Data = account;
                        return request;
                    }                    
                }
            }
            catch (Exception ex)
            {
                request.IsSuccess = false;
                request.Message = ex.Message;
                request.Data = null;
                return request;
            }
            return null;
        }
        
        private DateTime convertBirthDay(string date,DateTime convertBirth)
        {
            if (DateTime.TryParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out convertBirth))
            {
                return convertBirth;
            }
            return convertBirth;
        }
    }
}
