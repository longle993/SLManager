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
            loadFood();
        }
        private void loadFood()
        {
            Request request = FoodBUS.Instance.getFood();
            flowListFood.Controls.Clear();
            if (request.IsSuccess)
            {
                list = (List<Food>)request.Data;
                list.ForEach(item =>
                {
                    FoodControl foodView = new FoodControl(item.Id, item.Type, item.Name, item.Price, item.ImagePath);
                    flowListFood.Controls.Add(foodView);
                });
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            FormAddFood formAddFood = new FormAddFood();
            formAddFood.ShowDialog();
            loadFood();
        }
    }
}
