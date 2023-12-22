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

namespace QLBH
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirm.Text != txtPassword.Text)
            {
                lblError.Visible = true;
            }
            else { lblError.Visible = false; }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            if (checkValidation())
            {
                string sdt = txtUserName.Text;
                string name = txtName.Text;
                string pass = txtPassword.Text;
                string id = GenerateID();
                DateTime birth = txtBirth.Value;
                Account account = new Account(id, name, birth, pass, sdt);
                if (AccountBUS.Instance.createAccount(account))
                {
                    MessageBox.Show("Tạo tài khoản thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool checkValidation()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text == "" || control.Text == null)
                    {
                        MessageBox.Show("Không được để trống!");
                        return false;
                    }
                }
            }
            if (string.IsNullOrEmpty(txtBirth.Text))
            {
                MessageBox.Show("Không được để trống!");
                return false;
            }
            else
            {
                return true;
            }

        }
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
