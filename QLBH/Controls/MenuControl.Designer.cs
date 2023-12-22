namespace QLBH.Controls
{
    partial class MenuControl
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
            picImgFood = new PictureBox();
            lblFoodname = new Label();
            lblPrice = new Label();
            btnAdd = new Button();
            panelMenuLayout = new Panel();
            ((System.ComponentModel.ISupportInitialize)picImgFood).BeginInit();
            SuspendLayout();
            // 
            // picImgFood
            // 
            picImgFood.Location = new Point(24, 22);
            picImgFood.Name = "picImgFood";
            picImgFood.Size = new Size(100, 100);
            picImgFood.SizeMode = PictureBoxSizeMode.StretchImage;
            picImgFood.TabIndex = 0;
            picImgFood.TabStop = false;
            // 
            // lblFoodname
            // 
            lblFoodname.AutoSize = true;
            lblFoodname.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblFoodname.ForeColor = Color.FromArgb(22, 26, 48);
            lblFoodname.Location = new Point(156, 36);
            lblFoodname.Name = "lblFoodname";
            lblFoodname.Size = new Size(76, 23);
            lblFoodname.TabIndex = 1001;
            lblFoodname.Text = "Tên món";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.FromArgb(22, 26, 48);
            lblPrice.Location = new Point(156, 83);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(69, 23);
            lblPrice.TabIndex = 1002;
            lblPrice.Text = "Giá tiền";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(22, 26, 48);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = Properties.Resources.plus_solid;
            btnAdd.Location = new Point(361, 48);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(49, 45);
            btnAdd.TabIndex = 1003;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelMenuLayout
            // 
            panelMenuLayout.Dock = DockStyle.Fill;
            panelMenuLayout.Location = new Point(0, 0);
            panelMenuLayout.Name = "panelMenuLayout";
            panelMenuLayout.Size = new Size(430, 150);
            panelMenuLayout.TabIndex = 1004;
            panelMenuLayout.Paint += panelMenuLayout_Paint;
            // 
            // MenuControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAdd);
            Controls.Add(lblPrice);
            Controls.Add(lblFoodname);
            Controls.Add(picImgFood);
            Controls.Add(panelMenuLayout);
            DoubleBuffered = true;
            Name = "MenuControl";
            Size = new Size(430, 150);
            ((System.ComponentModel.ISupportInitialize)picImgFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picImgFood;
        private Label lblFoodname;
        private Label lblPrice;
        public Button btnAdd;
        private Panel panelMenuLayout;
    }
}
