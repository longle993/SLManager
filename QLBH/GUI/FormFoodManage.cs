using QLBH.BUS;
using QLBH.Controls;
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
    public partial class FormFoodManage : Form
    {
        List<Food> list = new List<Food>();
        public FormFoodManage()
        {
            InitializeComponent();
        }

        private void FormFoodManage_Load(object sender, EventArgs e)
        {
            cbboxFilter.Items.Add(FoodType.TYPERICE);
            cbboxFilter.Items.Add(FoodType.TYPEPIZZA);
            cbboxFilter.Items.Add(FoodType.TYPENOODLE);
            cbboxFilter.Items.Add(FoodType.TYPEPASTA);
            cbboxFilter.Items.Add("Tất cả");

            Request request = FoodBUS.Instance.getFood();
            if (request.IsSuccess)
            {
                list = (List<Food>)request.Data;

                loadFood(this.list);
            }
        }
        private void loadFood(List<Food> list)
        {
            flowListFood.Controls.Clear();

            list.ForEach(item =>
            {
                FoodControl foodView = new FoodControl(item.Id, item.Type, item.Name, item.Price, item.ImagePath);
                flowListFood.Controls.Add(foodView);
            });

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            FormAddFood formAddFood = new FormAddFood();
            formAddFood.ShowDialog();
            loadFood(this.list);
        }

        private void cbboxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbboxFilter.SelectedItem.ToString() == "Tất cả")
            {
                loadFood(this.list); return;
            }
            loadFood(this.list.Where(P => P.Type == cbboxFilter.SelectedItem.ToString()).ToList());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                loadFood(this.list);
                cbboxFilter.Text = "Tất cả";
                return;
            }
            switch (cbboxSearchBy.SelectedItem.ToString())
            {
                case "Tên":
                    if (cbboxFilter.SelectedItem.ToString() == "Tất cả")
                    {
                        loadFood(this.list.Where(p => p.Name.ToLower().Contains(txtSearch.Text.ToLower())).ToList()); break;
                    }
                    else
                    {
                        loadFood(this.list.Where(p => p.Name.ToLower().Contains(txtSearch.Text.ToLower()) && p.Type == cbboxFilter.SelectedItem.ToString()).ToList()); break;
                    }

                case "Loại":
                    if (cbboxFilter.SelectedItem.ToString() == "Tất cả")
                    {
                        loadFood(this.list.Where(p => p.Type.ToLower().Contains(txtSearch.Text.ToLower())).ToList()); break;
                    }
                    else
                    {
                        loadFood(this.list.Where(p => p.Type.ToLower().Contains(txtSearch.Text.ToLower()) && p.Type == cbboxFilter.SelectedItem.ToString()).ToList()); break;

                    }
            }
        }
    }
}
