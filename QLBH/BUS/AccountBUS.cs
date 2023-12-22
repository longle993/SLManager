using QLBH.DAO;
using QLBH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get { if (instance == null) instance = new AccountBUS(); return instance; }
            private set { instance = value; }
        }
        public bool createAccount(Account account)
        {
            return AccountDAO.Instance.createAccount(account);
        }
        public Request login(string phone, string password)
        {
            return AccountDAO.Instance.login(phone, password);
        }
        public Request getUser(string inputId)
        {
            return AccountDAO.Instance.getUser(inputId);
        }
    }
}
