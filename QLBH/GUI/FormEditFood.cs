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
    public partial class FormEditFood : Form
    {
        Food senderFood;
        string imagePath;
        string destinationPath;
        bool isSetImg = false;
        public FormEditFood()
        {
            InitializeComponent();
        }
        public FormEditFood(Food senderFood)
        {
            InitializeComponent();
            this.senderFood = senderFood;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn huỷ thao tác?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void loadFood()
        {
            txtFoodName.Text = senderFood.Name;
            txtPrice.Text = senderFood.Price.ToString();
            cbboxType.Text = senderFood.Type;
            picFoodImage.Image = Image.FromFile(senderFood.ImagePath);
        }

        private void panelAddFood_Paint(object sender, PaintEventArgs e)
        {
            loadFood();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn lưu thay đổi?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                checkImg();
                Food updateFood = new Food(senderFood.Id, txtFoodName.Text, cbboxType.Text, Convert.ToDecimal(txtPrice.Text), this.destinationPath);
                if (FoodBUS.Instance.updateFood(updateFood, imagePath, isSetImg))
                {
                    this.Close();
                }
                else { MessageBox.Show("Có lỗi xảy ra!"); }
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

                string destinationFolder = ConnectionString.ConnectToPicture();
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

        private void FormEditFood_Load(object sender, EventArgs e)
        {
            cbboxType.Items.Add(FoodType.TYPERICE);
            cbboxType.Items.Add(FoodType.TYPEPIZZA);
            cbboxType.Items.Add(FoodType.TYPENOODLE);
            cbboxType.Items.Add(FoodType.TYPEPASTA);
        }
        private void checkImg()
        {
            if(string.IsNullOrEmpty(destinationPath))
            {
                isSetImg = false;
            }
            else
            {
                isSetImg = true;
            }
        }
    }
}
