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
    public partial class MenuControl : UserControl
    {
        Food currentFood;

        public Food CurrentFood { get => currentFood; set => currentFood = value; }

        public MenuControl()
        {
            InitializeComponent();
        }
        public MenuControl(Food currentFood)
        {
            InitializeComponent();
            this.currentFood = currentFood;
            setFood();
        }
        private void setFood()
        {
            picImgFood.Image = Image.FromFile(currentFood.ImagePath);
            lblFoodname.Text = currentFood.Name;
            lblPrice.Text = currentFood.Price.ToString("N0") + " vnd";
        }

        private void panelMenuLayout_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = ColorTranslator.FromHtml("#31304D");
            ControlPaint.DrawBorder(e.Graphics, panelMenuLayout.ClientRectangle,
                                    borderColor, 2, ButtonBorderStyle.Solid,
                                    borderColor, 2, ButtonBorderStyle.Solid,
                                    borderColor, 2, ButtonBorderStyle.Solid,
                                    borderColor, 2, ButtonBorderStyle.Solid);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
