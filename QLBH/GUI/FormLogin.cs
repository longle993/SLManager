using QLBH.BUS;
using QLBH.DTO;
using QLBH.GUI;

namespace QLBH
{
    public partial class FormLogin : Form
    {
        private bool isShow = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void lblShowPass_Click(object sender, EventArgs e)
        {
            if (isShow)
            {
                lblShowPass.Text = "Ẩn";
                txtPassword.UseSystemPasswordChar = false;
                isShow = false;
            }
            else
            {
                lblShowPass.Text = "Hiện";
                txtPassword.UseSystemPasswordChar = true;
                isShow = true;
            }
        }
        private bool checkValidation()
        {
            if (txtUserName.Text == "" || txtUserName.Text == null)
            {
                MessageBox.Show("Tài khoản không được để trống!");
                return false;
            }
            else if (txtPassword.Text == "" || txtPassword.Text == null)
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkValidation())
            {
                Request request = AccountBUS.Instance.login(txtUserName.Text,txtPassword.Text);
                if (request.IsSuccess)
                {
                    FormMain form = new FormMain((string)request.Data);
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không hợp lệ!");
                }
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            this.Hide();
            formRegister.ShowDialog();
            this.Show();
            
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}