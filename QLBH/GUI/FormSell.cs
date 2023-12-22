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
                    flowListMenu.Controls.Add(foodView);
                });
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                loadFood(); return;
            }
            List<Food> foodSearch = list.Where(p=>p.Name.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            flowListMenu.Controls.Clear();
            foodSearch.ForEach(item =>
            {
                MenuControl foodView = new MenuControl(item);
                flowListMenu.Controls.Add(foodView);
            });
        }
    }
}
