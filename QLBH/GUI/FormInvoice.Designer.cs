﻿namespace QLBH.GUI
{
    partial class FormInvoice
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnDetail = new Button();
            txtmaHD = new TextBox();
            cbboxFilter = new ComboBox();
            txtSearch = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataBill = new DataGridView();
            mahd = new DataGridViewTextBoxColumn();
            ngayhd = new DataGridViewTextBoxColumn();
            tamtinh = new DataGridViewTextBoxColumn();
            chietkhau = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataBill).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDetail);
            panel1.Controls.Add(txtmaHD);
            panel1.Controls.Add(cbboxFilter);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 130);
            panel1.TabIndex = 2;
            // 
            // btnDetail
            // 
            btnDetail.BackColor = Color.FromArgb(49, 48, 77);
            btnDetail.Cursor = Cursors.Hand;
            btnDetail.FlatAppearance.BorderColor = Color.FromArgb(22, 26, 48);
            btnDetail.FlatAppearance.BorderSize = 2;
            btnDetail.FlatStyle = FlatStyle.Flat;
            btnDetail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDetail.ForeColor = Color.White;
            btnDetail.Location = new Point(613, 80);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(131, 39);
            btnDetail.TabIndex = 1000;
            btnDetail.Text = "Xem chi tiết";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // txtmaHD
            // 
            txtmaHD.BackColor = Color.White;
            txtmaHD.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtmaHD.ForeColor = Color.FromArgb(22, 26, 48);
            txtmaHD.Location = new Point(378, 85);
            txtmaHD.Name = "txtmaHD";
            txtmaHD.PlaceholderText = "Mã hoá đơn";
            txtmaHD.ReadOnly = true;
            txtmaHD.Size = new Size(219, 30);
            txtmaHD.TabIndex = 6;
            // 
            // cbboxFilter
            // 
            cbboxFilter.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbboxFilter.ForeColor = Color.FromArgb(22, 26, 48);
            cbboxFilter.FormattingEnabled = true;
            cbboxFilter.Items.AddRange(new object[] { "Hôm nay", "Trong tháng", "Trong năm", "Tất cả" });
            cbboxFilter.Location = new Point(243, 84);
            cbboxFilter.Name = "cbboxFilter";
            cbboxFilter.Size = new Size(114, 31);
            cbboxFilter.TabIndex = 5;
            cbboxFilter.Text = "Tất cả";
            cbboxFilter.SelectedIndexChanged += cbboxFilter_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.FromArgb(22, 26, 48);
            txtSearch.Location = new Point(12, 84);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm...";
            txtSearch.Size = new Size(225, 30);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(22, 26, 48);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 0;
            label1.Text = "Danh sách hoá đơn";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataBill);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 434);
            panel2.TabIndex = 3;
            // 
            // dataBill
            // 
            dataBill.AllowUserToAddRows = false;
            dataBill.AllowUserToDeleteRows = false;
            dataBill.AllowUserToOrderColumns = true;
            dataBill.AllowUserToResizeColumns = false;
            dataBill.AllowUserToResizeRows = false;
            dataBill.BackgroundColor = Color.FromArgb(182, 187, 196);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 26, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(240, 236, 229);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBill.Columns.AddRange(new DataGridViewColumn[] { mahd, ngayhd, tamtinh, chietkhau, total });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(22, 26, 48);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataBill.DefaultCellStyle = dataGridViewCellStyle2;
            dataBill.Dock = DockStyle.Fill;
            dataBill.GridColor = Color.FromArgb(182, 187, 196);
            dataBill.Location = new Point(0, 0);
            dataBill.Name = "dataBill";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(22, 26, 48);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(240, 236, 229);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataBill.RowHeadersVisible = false;
            dataBill.RowHeadersWidth = 51;
            dataBill.RowTemplate.Height = 29;
            dataBill.Size = new Size(776, 434);
            dataBill.TabIndex = 0;
            dataBill.CellContentClick += dataBill_CellContentClick;
            // 
            // mahd
            // 
            mahd.HeaderText = "Mã hoá đơn";
            mahd.MinimumWidth = 6;
            mahd.Name = "mahd";
            mahd.Width = 150;
            // 
            // ngayhd
            // 
            ngayhd.HeaderText = "Ngày hoá đơn";
            ngayhd.MinimumWidth = 6;
            ngayhd.Name = "ngayhd";
            ngayhd.Width = 150;
            // 
            // tamtinh
            // 
            tamtinh.HeaderText = "Tạm tính";
            tamtinh.MinimumWidth = 6;
            tamtinh.Name = "tamtinh";
            tamtinh.Width = 150;
            // 
            // chietkhau
            // 
            chietkhau.HeaderText = "Chiết khấu";
            chietkhau.MinimumWidth = 6;
            chietkhau.Name = "chietkhau";
            chietkhau.Width = 150;
            // 
            // total
            // 
            total.HeaderText = "Tổng tiền";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.Width = 170;
            // 
            // FormInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 229);
            ClientSize = new Size(776, 564);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInvoice";
            Text = "FormInvoice";
            Load += FormInvoice_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataBill).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dataBill;
        private DataGridViewTextBoxColumn mahd;
        private DataGridViewTextBoxColumn ngayhd;
        private DataGridViewTextBoxColumn tamtinh;
        private DataGridViewTextBoxColumn chietkhau;
        private DataGridViewTextBoxColumn total;
        private ComboBox cbboxFilter;
        private TextBox txtSearch;
        private TextBox txtmaHD;
        private Button btnDetail;
    }
}