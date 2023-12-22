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
    public partial class FormMain : Form
    {
        private Form currentChildForm;
        private string currentId;
        private Account currentUser;
        public FormMain()
        {
            InitializeComponent();
        }
        public FormMain(string currentId)
        {
            InitializeComponent();
            OpenChildForm(new FormSell());
            this.currentId = currentId;
        }

        private void btnBanHang_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = ColorTranslator.FromHtml("#31304D");
            button.ForeColor = Color.White;
        }

        private void btnBanHang_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = ColorTranslator.FromHtml("#B6BBC4");
            button.BackColor = ColorTranslator.FromHtml("#161A30");
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSell());
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormFoodManage());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInvoice());
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReport());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSetting());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Request request = AccountBUS.Instance.getUser(currentId);
            if (request.IsSuccess)
            {
                currentUser = (Account)request.Data;
                lblWelcome.Text = $"Welcome back {currentUser.Name}!";
            }
            else
            {
                MessageBox.Show(request.Message);
            }
        }
    }
}
