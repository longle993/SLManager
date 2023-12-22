using QLBH.BUS;
using QLBH.DTO;
using QLBH.GUI;
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
    public partial class FoodControl : UserControl
    {
        string foodid;
        string foodtype;
        string foodname;
        decimal foodprice;
        string filePath;
        public FoodControl(string foodid, string foodtype, string foodname, decimal foodprice, string filePath)
        {
            InitializeComponent();
            this.foodid = foodid;
            this.foodtype = foodtype;
            this.foodname = foodname;
            this.foodprice = foodprice;
            this.filePath = filePath;
            setFood();
        }

        public string Foodtype { get => foodtype; set => foodtype = value; }
        public string Foodname { get => foodname; set => foodname = value; }
        public decimal Foodprice { get => foodprice; set => foodprice = value; }
        public string FilePath { get => filePath; set => filePath = value; }

        private void panelFoodLayout_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = ColorTranslator.FromHtml("#31304D");
            ControlPaint.DrawBorder(e.Graphics, panelFoodLayout.ClientRectangle,
                                    borderColor, 2, ButtonBorderStyle.Solid,
                                    borderColor, 2, ButtonBorderStyle.Solid,
                                    borderColor, 2, ButtonBorderStyle.Solid,
                                    borderColor, 2, ButtonBorderStyle.Solid);
        }

        private void setFood()
        {
            lblFoodName.Text = foodname;
            lblFoodPrice.Text = foodprice.ToString("N0") + " vnd";
            lblFoodType.Text = foodtype;
            using (Image img = Image.FromFile(filePath))
            {
                picFood.Image = new Bitmap(img);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Food senderFood = new Food(foodid, foodname, foodtype, foodprice, filePath);
            FormEditFood editFood = new FormEditFood(senderFood);
            editFood.ShowDialog();
            updateFood();
        }

        private void updateFood()
        {
            Request request = FoodBUS.Instance.getFoodById(foodid);
            if (request.IsSuccess)
            {
                Food updateFood = (Food)request.Data;
                lblFoodName.Text = updateFood.Name;
                lblFoodPrice.Text = updateFood.Price.ToString("N0") + " vnd";
                lblFoodType.Text = updateFood.Type;
                picFood.Image = Image.FromFile(updateFood.ImagePath);
            }
        }

    }
}
