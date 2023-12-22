namespace QLBH.GUI
{
    partial class FormEditFood
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnChoosePic = new Button();
            picFoodImage = new PictureBox();
            cbboxType = new ComboBox();
            txtPrice = new TextBox();
            txtFoodName = new TextBox();
            btnCancel = new Button();
            btnAdd = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDel = new Button();
            panelAddFood = new Panel();
            ((System.ComponentModel.ISupportInitialize)picFoodImage).BeginInit();
            panelAddFood.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 573);
            panel1.TabIndex = 0;
            // 
            // btnChoosePic
            // 
            btnChoosePic.BackColor = Color.White;
            btnChoosePic.Cursor = Cursors.Hand;
            btnChoosePic.FlatAppearance.BorderSize = 0;
            btnChoosePic.FlatStyle = FlatStyle.Flat;
            btnChoosePic.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChoosePic.ForeColor = Color.FromArgb(49, 48, 77);
            btnChoosePic.Location = new Point(86, 371);
            btnChoosePic.Name = "btnChoosePic";
            btnChoosePic.Size = new Size(131, 37);
            btnChoosePic.TabIndex = 1021;
            btnChoosePic.Text = "Thay đổi";
            btnChoosePic.UseVisualStyleBackColor = false;
            btnChoosePic.Click += btnChoosePic_Click;
            // 
            // picFoodImage
            // 
            picFoodImage.Location = new Point(247, 340);
            picFoodImage.Name = "picFoodImage";
            picFoodImage.Size = new Size(119, 108);
            picFoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picFoodImage.TabIndex = 1020;
            picFoodImage.TabStop = false;
            // 
            // cbboxType
            // 
            cbboxType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbboxType.ForeColor = Color.FromArgb(22, 26, 48);
            cbboxType.FormattingEnabled = true;
            cbboxType.Location = new Point(168, 211);
            cbboxType.Name = "cbboxType";
            cbboxType.Size = new Size(238, 31);
            cbboxType.TabIndex = 1019;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.ForeColor = Color.FromArgb(22, 26, 48);
            txtPrice.Location = new Point(168, 280);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "nhập giá tiền...";
            txtPrice.Size = new Size(238, 30);
            txtPrice.TabIndex = 1018;
            // 
            // txtFoodName
            // 
            txtFoodName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtFoodName.ForeColor = Color.FromArgb(22, 26, 48);
            txtFoodName.Location = new Point(168, 139);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.PlaceholderText = "nhập tên món ăn...";
            txtFoodName.Size = new Size(238, 30);
            txtFoodName.TabIndex = 1017;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(182, 187, 196);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(182, 187, 196);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(22, 26, 48);
            btnCancel.Location = new Point(247, 477);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 50);
            btnCancel.TabIndex = 1016;
            btnCancel.Text = "Huỷ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(49, 48, 77);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(22, 26, 48);
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(86, 477);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 50);
            btnAdd.TabIndex = 1015;
            btnAdd.Text = "Lưu";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(22, 26, 48);
            label4.Location = new Point(46, 283);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 1014;
            label4.Text = "Giá tiền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(22, 26, 48);
            label3.Location = new Point(46, 216);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 1013;
            label3.Text = "Loại món ăn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(22, 26, 48);
            label2.Location = new Point(46, 142);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 1012;
            label2.Text = "Tên món ăn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(22, 26, 48);
            label1.Location = new Point(114, 47);
            label1.Name = "label1";
            label1.Size = new Size(252, 31);
            label1.TabIndex = 1011;
            label1.Text = "THAY ĐỔI THÔNG TIN";
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(182, 187, 196);
            btnDel.Cursor = Cursors.Hand;
            btnDel.FlatAppearance.BorderColor = Color.FromArgb(182, 187, 196);
            btnDel.FlatAppearance.BorderSize = 2;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.ForeColor = Color.FromArgb(22, 26, 48);
            btnDel.Location = new Point(393, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(71, 37);
            btnDel.TabIndex = 1023;
            btnDel.Text = "Xoá";
            btnDel.UseVisualStyleBackColor = false;
            // 
            // panelAddFood
            // 
            panelAddFood.BorderStyle = BorderStyle.FixedSingle;
            panelAddFood.Controls.Add(btnDel);
            panelAddFood.Dock = DockStyle.Fill;
            panelAddFood.Location = new Point(0, 0);
            panelAddFood.Name = "panelAddFood";
            panelAddFood.Size = new Size(469, 573);
            panelAddFood.TabIndex = 1022;
            panelAddFood.Paint += panelAddFood_Paint;
            // 
            // FormEditFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 229);
            ClientSize = new Size(469, 573);
            Controls.Add(btnChoosePic);
            Controls.Add(picFoodImage);
            Controls.Add(cbboxType);
            Controls.Add(txtPrice);
            Controls.Add(txtFoodName);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelAddFood);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditFood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditFood";
            Load += FormEditFood_Load;
            ((System.ComponentModel.ISupportInitialize)picFoodImage).EndInit();
            panelAddFood.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnChoosePic;
        private PictureBox picFoodImage;
        private ComboBox cbboxType;
        private TextBox txtPrice;
        private TextBox txtFoodName;
        private Button btnCancel;
        private Button btnAdd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDel;
        private Panel panelAddFood;
    }
}