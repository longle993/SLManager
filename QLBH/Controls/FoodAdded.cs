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

namespace QLBH.Controls
{
    public partial class FoodAdded : UserControl
    {
        private Food currentFood;

        public FoodAdded()
        {
            InitializeComponent();
        }
        public FoodAdded(Food currentFood)
        {
            InitializeComponent();
            this.currentFood = currentFood;
            setFood();
            btnRemove.Tag = currentFood.Id;
        }

        public Food CurrentFood { get => currentFood; set => currentFood = value; }

        private void setFood()
        {
            if (currentFood != null)
            {
                lblFoodName.Text = currentFood.Name;
                lblPrice.Text = currentFood.Price.ToString("N0");
            }
        }
    }
}
