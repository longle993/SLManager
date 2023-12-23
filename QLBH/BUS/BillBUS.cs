using QLBH.DAO;
using QLBH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.BUS
{
    public class BillBUS
    {
        private static BillBUS instance;
        public static BillBUS Instance
        {
            get { if (instance == null) instance = new BillBUS(); return instance; }
            private set { instance = value; }
        }
        public Request getBill()
        {
            return BillDAO.Instance.getBill();
        }
        public bool createBill(Bill bill)
        {
            return BillDAO.Instance.createBill(bill);
        }
    }
}
