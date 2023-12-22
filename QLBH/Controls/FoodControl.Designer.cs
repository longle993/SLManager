namespace QLBH.Controls
{
    partial class FoodControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelFoodLayout = new Panel();
            btnEdit = new Button();
            lblFoodPrice = new Label();
            label3 = new Label();
            lblFoodType = new Label();
            label2 = new Label();
            label1 = new Label();
            lblFoodName = new Label();
            picFood = new PictureBox();
            panelFoodLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFood).BeginInit();
            SuspendLayout();
            // 
            // panelFoodLayout
            // 
            panelFoodLayout.Controls.Add(btnEdit);
            panelFoodLayout.Controls.Add(lblFoodPrice);
            panelFoodLayout.Controls.Add(label3);
            panelFoodLayout.Controls.Add(lblFoodType);
            panelFoodLayout.Controls.Add(label2);
            panelFoodLayout.Controls.Add(label1);
            panelFoodLayout.Controls.Add(lblFoodName);
            panelFoodLayout.Controls.Add(picFood);
            panelFoodLayout.Dock = DockStyle.Fill;
            panelFoodLayout.Location = new Point(0, 0);
            panelFoodLayout.Name = "panelFoodLayout";
            panelFoodLayout.Size = new Size(762, 149);
            panelFoodLayout.TabIndex = 0;
            panelFoodLayout.Paint += panelFoodLayout_Paint;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Image = Properties.Resources.pen_to_square_solid;
            btnEdit.Location = new Point(698, 18);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(49, 45);
            btnEdit.TabIndex = 8;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblFoodPrice
            // 
            lblFoodPrice.AutoSize = true;
            lblFoodPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFoodPrice.ForeColor = Color.FromArgb(49, 48, 77);
            lblFoodPrice.Location = new Point(280, 83);
            lblFoodPrice.Name = "lblFoodPrice";
            lblFoodPrice.Size = new Size(80, 28);
            lblFoodPrice.TabIndex = 7;
            lblFoodPrice.Text = "giá tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(22, 26, 48);
            label3.Location = new Point(225, 83);
            label3.Name = "label3";
            label3.Size = new Size(46, 28);
            label3.TabIndex = 6;
            label3.Text = "Giá:";
            // 
            // lblFoodType
            // 
            lblFoodType.AutoSize = true;
            lblFoodType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFoodType.ForeColor = Color.FromArgb(49, 48, 77);
            lblFoodType.Location = new Point(515, 35);
            lblFoodType.Name = "lblFoodType";
            lblFoodType.Size = new Size(125, 28);
            lblFoodType.TabIndex = 5;
            lblFoodType.Text = "Loại món ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(22, 26, 48);
            label2.Location = new Point(455, 35);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 4;
            label2.Text = "Loại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(22, 26, 48);
            label1.Location = new Point(225, 35);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 3;
            label1.Text = "Tên:";
            // 
            // lblFoodName
            // 
            lblFoodName.AutoSize = true;
            lblFoodName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFoodName.ForeColor = Color.FromArgb(49, 48, 77);
            lblFoodName.Location = new Point(280, 35);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(120, 28);
            lblFoodName.TabIndex = 2;
            lblFoodName.Text = "Tên món ăn";
            // 
            // picFood
            // 
            picFood.Location = new Point(34, 12);
            picFood.Name = "picFood";
            picFood.Size = new Size(120, 120);
            picFood.SizeMode = PictureBoxSizeMode.StretchImage;
            picFood.TabIndex = 1;
            picFood.TabStop = false;
            // 
            // FoodControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelFoodLayout);
            Name = "FoodControl";
            Size = new Size(762, 149);
            panelFoodLayout.ResumeLayout(false);
            panelFoodLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFoodLayout;
        private PictureBox picFood;
        private Label lblFoodName;
        private Label lblFoodPrice;
        private Label label3;
        private Label lblFoodType;
        private Label label2;
        private Label label1;
        private Button btnEdit;
    }
}
