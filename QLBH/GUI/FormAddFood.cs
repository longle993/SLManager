using QLBH.BUS;
using QLBH.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.GUI
{
    public partial class FormAddFood : Form
    {
        string destinationPath = "";
        string imagePath = "";
        public FormAddFood()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn huỷ thao tác?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormAddFood_Load(object sender, EventArgs e)
        {
            cbboxType.Items.Add(FoodType.TYPERICE);
            cbboxType.Items.Add(FoodType.TYPEPIZZA);
            cbboxType.Items.Add(FoodType.TYPENOODLE);
            cbboxType.Items.Add(FoodType.TYPEPASTA);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkValidation())
            {
                Food food = new Food(GenerateID(), txtFoodName.Text, cbboxType.Text, Convert.ToDecimal(txtPrice.Text), destinationPath);
                if (FoodBUS.Instance.createFood(food,this.imagePath))
                {
                    if (MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }
        }
        private bool checkValidation()
        {
            if (string.IsNullOrEmpty(txtFoodName.Text))
            {
                MessageBox.Show("Không được để trống tên món ăn!"); return false;
            }
            else if (string.IsNullOrEmpty(cbboxType.Text))
            {
                MessageBox.Show("Không được để trống loại món ăn!"); return false;
            }
            else if (string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Không được để trống giá tiền"); return false;
            }
            else if (picFoodImage.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh món ăn!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnChoosePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            openFileDialog.Title = "Chọn hình ảnh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.imagePath = openFileDialog.FileName;

                string destinationFolder = @"D:\Long Le\QLBH\QLBH\Pictures";
                this.destinationPath = Path.Combine(destinationFolder, Path.GetFileName(imagePath));

                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }
                try
                {
                    picFoodImage.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}");
                }
            }
        }
        private string GenerateID()
        {
            DateTime now = DateTime.Now;
            string id = now.ToString("yyyyMMddHHmmssfff");
            return id;
        }
    }
}
