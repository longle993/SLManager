using QLBH.BUS;
using QLBH.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.GUI
{
    public partial class FormInvoice : Form
    {
        private List<Bill> listBill;
        public FormInvoice()
        {
            InitializeComponent();
            listBill = new List<Bill>();
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            loadBill();
        }
        private void loadBill()
        {
            Request request = BillBUS.Instance.getBill();

            if (request.IsSuccess)
            {
                dataBill.Rows.Clear();
                listBill = (List<Bill>)request.Data;
                listBill.ForEach(bill =>
                {
                    dataBill.Rows.Add(bill.Id,bill.Date,bill.Price.ToString("N0"),bill.Discount.ToString("N0"),bill.Total.ToString("N0"));
                });
            }
        }
    }
}
