using QLBH.BUS;
using QLBH.Controls;
using QLBH.DTO;
using System;
using System.Collections;
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
    public partial class FormSell : Form
    {
        List<Food> list;
        public FormSell()
        {
            InitializeComponent();
            lblMaHD.Text = GenerateID().ToString();
        }

        private void FormSell_Load(object sender, EventArgs e)
        {
            loadFood();
        }
        private void loadFood()
        {
            Request request = FoodBUS.Instance.getFood();
            flowListMenu.Controls.Clear();
            if (request.IsSuccess)
            {
                list = (List<Food>)request.Data;
                list.ForEach(item =>
                {
                    MenuControl foodView = new MenuControl(item);
                    foodView.btnAdd.Click += BtnAdd_Click;
                    flowListMenu.Controls.Add(foodView);
                });
            }
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            Button currentBtn = (Button)sender;
            Food food = list.Where(p => p.Id == currentBtn.Tag).SingleOrDefault();
            if (food != null)
            {
                addToListPay(food);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                loadFood(); return;
            }
            List<Food> foodSearch = list.Where(p => p.Name.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            flowListMenu.Controls.Clear();
            foodSearch.ForEach(item =>
            {
                MenuControl foodView = new MenuControl(item);
                foodView.btnAdd.Click += BtnAdd_Click;
                flowListMenu.Controls.Add(foodView);
            });
        }
        private void addToListPay(Food food)
        {
            FoodAdded control = new FoodAdded(food);
            control.btnRemove.Click += BtnRemove_Click;
            flowTotal.Controls.Add(control);

            payTheBill();
        }

        private void BtnRemove_Click(object? sender, EventArgs e)
        {
            foreach (Control control in flowTotal.Controls)
            {
                FoodAdded foodAddedSender = (FoodAdded)control;
                Button currentBtn = (Button)sender;
                if (foodAddedSender.btnRemove.Tag == currentBtn) ;
                flowTotal.Controls.Remove(foodAddedSender);
                break;
            }
            payTheBill();
        }
        private void payTheBill()
        {
            if (!string.IsNullOrEmpty(txtDiscount.Text))
            {
                decimal total = 0;
                foreach (Control control in flowTotal.Controls)
                {
                    FoodAdded food = (FoodAdded)control;
                    total += food.CurrentFood.Price;
                }
                txtTamTinh.Text = total.ToString("N0");
                decimal discount = Convert.ToDecimal(txtDiscount.Text);
                if (total >= discount)
                {
                    txtTotal.Text = (total - discount).ToString("N0");
                }
                else
                {
                    txtTotal.Text = total.ToString("N0");
                    txtDiscount.Text = "0";
                    MessageBox.Show("Số tiền chiết khấu không thể lớn hơn tổng tiền tạm tính!");
                }
            }

        }

        private void flowListMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            payTheBill();
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private string GenerateID()
        {
            DateTime now = DateTime.Now;
            string id = now.ToString("yyyyMMddHHmmssfff");
            return id;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtTotal.Text) > 0)
            {
                Bill bill = new Bill();
                bill.Id = lblMaHD.Text;
                bill.Date = DateTime.Now;
                bill.Discount = Convert.ToDecimal(txtDiscount.Text);
                bill.Price = Convert.ToDecimal(txtTamTinh.Text);
                bill.Total = Convert.ToDecimal(txtTotal.Text);
                foreach (Control item in flowTotal.Controls)
                {
                    FoodAdded control = (FoodAdded)item;
                    bill.FoodList.Add(control.CurrentFood.Id);
                }
                if (BillBUS.Instance.createBill(bill))
                {
                    MessageBox.Show("Thanh toán thành công!");
                    Reset();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }
            else
            {
                MessageBox.Show("Không có hoá đơn cần tính toán!");
            }
        }
        private void Reset()
        {
            flowTotal.Controls.Clear();
            lblMaHD.Text = GenerateID();
            txtDiscount.Text = "0";
            txtTamTinh.Text = "0";
            txtTotal.Text = "0";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
