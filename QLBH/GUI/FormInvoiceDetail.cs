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
    public partial class FormInvoiceDetail : Form
    {
        private Bill currentBill;
        public FormInvoiceDetail()
        {
            InitializeComponent();
        }
        public FormInvoiceDetail(Bill currentBill)
        {
            InitializeComponent();
            this.currentBill = currentBill;
        }

        private void FormInvoiceDetail_Load(object sender, EventArgs e)
        {
            lblMaHD.Text = currentBill.Id;
            lblngayHD.Text = currentBill.Date.ToString();
            lblDiscount.Text = currentBill.Discount.ToString();
            lblPrice.Text = currentBill.Price.ToString();
            lblTotal.Text = currentBill.Total.ToString();
            getFoodByID();
        }
        private void getFoodByID()
        {
            this.currentBill.FoodList.ForEach(item =>
            {
                Request request = FoodBUS.Instance.getFoodById(item);
                if (request.IsSuccess)
                {
                    Food food = (Food)request.Data;
                    dataFood.Rows.Add(food.Name,food.Type,food.Price.ToString("N0"));
                }
            });
        }
    }

}
