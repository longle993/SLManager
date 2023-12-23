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
            Request request = BillBUS.Instance.getBill();

            if (request.IsSuccess)
            {
                this.listBill = (List<Bill>)request.Data;
                loadBill(this.listBill);
            }
        }
        private void loadBill(List<Bill> listBill)
        {
            dataBill.Rows.Clear();
            listBill.ForEach(bill =>
            {
                dataBill.Rows.Add(bill.Id, bill.Date.ToString(), bill.Price.ToString("N0"), bill.Discount.ToString("N0"), bill.Total.ToString("N0"));
            });

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearch.Text))
            {
                loadBill(this.listBill) ; return;
            }
            loadBill(listBill.Where(p => p.Id.Contains(txtSearch.Text)).ToList());
        }

        private void cbboxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbboxFilter.SelectedItem.ToString())
            {
                case "Tất cả": loadBill(this.listBill); break;
                case "Hôm nay": loadBill(this.listBill.Where(p => p.Date.Date == DateTime.Now.Date).ToList()); break;
                case "Trong tháng": loadBill(this.listBill.Where(p => p.Date.Month == DateTime.Now.Month).ToList()); break;
                case "Trong năm": loadBill(this.listBill.Where(p => p.Date.Year == DateTime.Now.Year).ToList()); break;
            }
        }

        private void dataBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow currentRow = dataBill.Rows[e.RowIndex];
                txtmaHD.Text = currentRow.Cells[0].Value.ToString();
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtmaHD.Text))
            {
                MessageBox.Show("Không có hoá đơn được chọn!");
                return;
            }
            Bill currentBill = this.listBill.Where(p=>p.Id == txtmaHD.Text).FirstOrDefault();
            FormInvoiceDetail detail = new FormInvoiceDetail(currentBill);
            detail.ShowDialog();
        }
    }
}
