﻿namespace QLBH.GUI
{
    partial class FormFoodManage
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
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            cbboxFilter = new ComboBox();
            label2 = new Label();
            cbboxSearchBy = new ComboBox();
            txtSearch = new TextBox();
            btnAddFood = new Button();
            flowListFood = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(22, 26, 48);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 0;
            label1.Text = "Danh sách món ăn";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbboxFilter);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbboxSearchBy);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnAddFood);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 130);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(22, 26, 48);
            label3.Location = new Point(604, 76);
            label3.Name = "label3";
            label3.Size = new Size(40, 23);
            label3.TabIndex = 9;
            label3.Text = "Lọc:";
            // 
            // cbboxFilter
            // 
            cbboxFilter.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbboxFilter.ForeColor = Color.FromArgb(22, 26, 48);
            cbboxFilter.FormattingEnabled = true;
            cbboxFilter.Location = new Point(650, 73);
            cbboxFilter.Name = "cbboxFilter";
            cbboxFilter.Size = new Size(114, 31);
            cbboxFilter.TabIndex = 8;
            cbboxFilter.Text = "Tất cả";
            cbboxFilter.SelectedIndexChanged += cbboxFilter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(22, 26, 48);
            label2.Location = new Point(320, 76);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 7;
            label2.Text = "Tìm kiếm theo:";
            // 
            // cbboxSearchBy
            // 
            cbboxSearchBy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbboxSearchBy.ForeColor = Color.FromArgb(22, 26, 48);
            cbboxSearchBy.FormattingEnabled = true;
            cbboxSearchBy.Items.AddRange(new object[] { "Tên", "Loại" });
            cbboxSearchBy.Location = new Point(450, 73);
            cbboxSearchBy.Name = "cbboxSearchBy";
            cbboxSearchBy.Size = new Size(114, 31);
            cbboxSearchBy.TabIndex = 6;
            cbboxSearchBy.Text = "Tên";
            cbboxSearchBy.SelectedIndexChanged += cbboxFilter_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.FromArgb(22, 26, 48);
            txtSearch.Location = new Point(12, 73);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm...";
            txtSearch.Size = new Size(286, 30);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.FromArgb(49, 48, 77);
            btnAddFood.Cursor = Cursors.Hand;
            btnAddFood.FlatStyle = FlatStyle.Flat;
            btnAddFood.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.ForeColor = Color.FromArgb(240, 236, 229);
            btnAddFood.Image = Properties.Resources.plus_solid;
            btnAddFood.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddFood.Location = new Point(205, 20);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Padding = new Padding(5, 0, 5, 0);
            btnAddFood.Size = new Size(93, 37);
            btnAddFood.TabIndex = 1;
            btnAddFood.Text = "Thêm";
            btnAddFood.TextAlign = ContentAlignment.MiddleRight;
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // flowListFood
            // 
            flowListFood.AutoScroll = true;
            flowListFood.Dock = DockStyle.Fill;
            flowListFood.Location = new Point(0, 130);
            flowListFood.Name = "flowListFood";
            flowListFood.Size = new Size(776, 434);
            flowListFood.TabIndex = 2;
            // 
            // FormFoodManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 229);
            ClientSize = new Size(776, 564);
            Controls.Add(flowListFood);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFoodManage";
            Text = "FormFoodManage";
            Load += FormFoodManage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private FlowLayoutPanel flowListFood;
        private Button btnAddFood;
        private TextBox txtSearch;
        private ComboBox cbboxSearchBy;
        private Label label2;
        private Label label3;
        private ComboBox cbboxFilter;
    }
}