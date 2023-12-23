namespace QLBH.GUI
{
    partial class FormInvoiceDetail
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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            lblMaHD = new Label();
            lblngayHD = new Label();
            label4 = new Label();
            lblPrice = new Label();
            label5 = new Label();
            lblDiscount = new Label();
            label6 = new Label();
            lblTotal = new Label();
            label8 = new Label();
            dataFood = new DataGridView();
            tenmon = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            dongia = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataFood).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(22, 26, 48);
            label3.Location = new Point(80, 43);
            label3.Name = "label3";
            label3.Size = new Size(271, 38);
            label3.TabIndex = 100;
            label3.Text = "CHI TIẾT HOÁ ĐƠN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(22, 26, 48);
            label1.Location = new Point(80, 120);
            label1.Name = "label1";
            label1.Size = new Size(108, 23);
            label1.TabIndex = 101;
            label1.Text = "Mã hoá đơn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(22, 26, 48);
            label2.Location = new Point(80, 165);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 102;
            label2.Text = "Ngày tạo:";
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaHD.ForeColor = Color.FromArgb(49, 48, 77);
            lblMaHD.Location = new Point(229, 120);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(64, 23);
            lblMaHD.TabIndex = 103;
            lblMaHD.Text = "#mahd";
            // 
            // lblngayHD
            // 
            lblngayHD.AutoSize = true;
            lblngayHD.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblngayHD.ForeColor = Color.FromArgb(49, 48, 77);
            lblngayHD.Location = new Point(229, 165);
            lblngayHD.Name = "lblngayHD";
            lblngayHD.Size = new Size(78, 23);
            lblngayHD.TabIndex = 104;
            lblngayHD.Text = "#ngayhd";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(22, 26, 48);
            label4.Location = new Point(80, 216);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 105;
            label4.Text = "Tạm tính:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.FromArgb(49, 48, 77);
            lblPrice.Location = new Point(229, 216);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(57, 23);
            lblPrice.TabIndex = 106;
            lblPrice.Text = "#price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(22, 26, 48);
            label5.Location = new Point(80, 265);
            label5.Name = "label5";
            label5.Size = new Size(97, 23);
            label5.TabIndex = 107;
            label5.Text = "Chiết khấu:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiscount.ForeColor = Color.FromArgb(49, 48, 77);
            lblDiscount.Location = new Point(229, 265);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(85, 23);
            lblDiscount.TabIndex = 108;
            lblDiscount.Text = "#discount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(22, 26, 48);
            label6.Location = new Point(80, 316);
            label6.Name = "label6";
            label6.Size = new Size(87, 23);
            label6.TabIndex = 109;
            label6.Text = "Tổng tiền:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.FromArgb(49, 48, 77);
            lblTotal.Location = new Point(229, 316);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(55, 23);
            lblTotal.TabIndex = 110;
            lblTotal.Text = "#total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(22, 26, 48);
            label8.Location = new Point(80, 364);
            label8.Name = "label8";
            label8.Size = new Size(134, 23);
            label8.TabIndex = 111;
            label8.Text = "Danh sách món:";
            // 
            // dataFood
            // 
            dataFood.AllowUserToAddRows = false;
            dataFood.AllowUserToDeleteRows = false;
            dataFood.AllowUserToOrderColumns = true;
            dataFood.AllowUserToResizeColumns = false;
            dataFood.AllowUserToResizeRows = false;
            dataFood.BackgroundColor = Color.FromArgb(182, 187, 196);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 26, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(240, 236, 229);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataFood.Columns.AddRange(new DataGridViewColumn[] { tenmon, type, dongia });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(22, 26, 48);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataFood.DefaultCellStyle = dataGridViewCellStyle2;
            dataFood.Dock = DockStyle.Bottom;
            dataFood.GridColor = Color.FromArgb(182, 187, 196);
            dataFood.Location = new Point(0, 401);
            dataFood.Name = "dataFood";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(22, 26, 48);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(240, 236, 229);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataFood.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataFood.RowHeadersVisible = false;
            dataFood.RowHeadersWidth = 51;
            dataFood.RowTemplate.Height = 29;
            dataFood.Size = new Size(436, 236);
            dataFood.TabIndex = 112;
            // 
            // tenmon
            // 
            tenmon.HeaderText = "Tên món ăn";
            tenmon.MinimumWidth = 6;
            tenmon.Name = "tenmon";
            tenmon.Width = 160;
            // 
            // type
            // 
            type.HeaderText = "Loại";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.Width = 125;
            // 
            // dongia
            // 
            dongia.HeaderText = "Đơn giá";
            dongia.MinimumWidth = 6;
            dongia.Name = "dongia";
            dongia.Width = 145;
            // 
            // FormInvoiceDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 229);
            ClientSize = new Size(436, 637);
            Controls.Add(dataFood);
            Controls.Add(label8);
            Controls.Add(lblTotal);
            Controls.Add(label6);
            Controls.Add(lblDiscount);
            Controls.Add(label5);
            Controls.Add(lblPrice);
            Controls.Add(label4);
            Controls.Add(lblngayHD);
            Controls.Add(lblMaHD);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            DoubleBuffered = true;
            Name = "FormInvoiceDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInvoiceDetail";
            Load += FormInvoiceDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dataFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private Label lblMaHD;
        private Label lblngayHD;
        private Label label4;
        private Label lblPrice;
        private Label label5;
        private Label lblDiscount;
        private Label label6;
        private Label lblTotal;
        private Label label8;
        private DataGridView dataFood;
        private DataGridViewTextBoxColumn tenmon;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn dongia;
    }
}