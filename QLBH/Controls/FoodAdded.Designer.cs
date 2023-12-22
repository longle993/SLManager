namespace QLBH.Controls
{
    partial class FoodAdded
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
            btnRemove = new Button();
            lblPrice = new Label();
            lblFoodName = new Label();
            panelFoodLayout.SuspendLayout();
            SuspendLayout();
            // 
            // panelFoodLayout
            // 
            panelFoodLayout.Controls.Add(btnRemove);
            panelFoodLayout.Controls.Add(lblPrice);
            panelFoodLayout.Controls.Add(lblFoodName);
            panelFoodLayout.Dock = DockStyle.Fill;
            panelFoodLayout.Location = new Point(0, 0);
            panelFoodLayout.Name = "panelFoodLayout";
            panelFoodLayout.Size = new Size(260, 80);
            panelFoodLayout.TabIndex = 1;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(22, 26, 48);
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Image = Properties.Resources.minus_solid;
            btnRemove.Location = new Point(194, 21);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(40, 40);
            btnRemove.TabIndex = 1004;
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.FromArgb(49, 48, 77);
            lblPrice.Location = new Point(34, 38);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(66, 23);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "100.000";
            lblPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFoodName
            // 
            lblFoodName.AutoSize = true;
            lblFoodName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFoodName.ForeColor = Color.FromArgb(22, 26, 48);
            lblFoodName.Location = new Point(26, 15);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(74, 23);
            lblFoodName.TabIndex = 4;
            lblFoodName.Text = "#monan";
            // 
            // FoodAdded
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelFoodLayout);
            Name = "FoodAdded";
            Size = new Size(260, 80);
            panelFoodLayout.ResumeLayout(false);
            panelFoodLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFoodLayout;
        private Label lblPrice;
        private Label lblFoodName;
        public Button btnRemove;
    }
}
