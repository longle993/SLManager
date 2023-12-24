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
    public partial class FormConnect : Form
    {
        public FormConnect()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFilePath.Text) ) {
                MessageBox.Show("Không được để trống!"); return;
            }
            ConnectionString.connectData = txtFilePath.Text;
            Request request = FoodBUS.Instance.getFood();
            if(request.IsSuccess )
            {
                MessageBox.Show("Kết nối thành công!");
                FormLogin login = new FormLogin();
                this.Hide();
                login.ShowDialog();
                this.Show();
            }
            
        }
    }
}
