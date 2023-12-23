namespace QLBH.GUI
{
    partial class FormSell
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
            panelTotal = new Panel();
            flowTotal = new FlowLayoutPanel();
            txtTotal = new TextBox();
            txtDiscount = new TextBox();
            txtTamTinh = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnReset = new Button();
            btnPay = new Button();
            lblMaHD = new Label();
            label3 = new Label();
            label2 = new Label();
            panelMenu = new Panel();
            flowListMenu = new FlowLayoutPanel();
            panel1 = new Panel();
            txtSearch = new TextBox();
            label1 = new Label();
            panelTotal.SuspendLayout();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTotal
            // 
            panelTotal.Controls.Add(flowTotal);
            panelTotal.Controls.Add(txtTotal);
            panelTotal.Controls.Add(txtDiscount);
            panelTotal.Controls.Add(txtTamTinh);
            panelTotal.Controls.Add(label6);
            panelTotal.Controls.Add(label5);
            panelTotal.Controls.Add(label4);
            panelTotal.Controls.Add(btnReset);
            panelTotal.Controls.Add(btnPay);
            panelTotal.Controls.Add(lblMaHD);
            panelTotal.Controls.Add(label3);
            panelTotal.Controls.Add(label2);
            panelTotal.Dock = DockStyle.Right;
            panelTotal.Location = new Point(465, 0);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(311, 481);
            panelTotal.TabIndex = 0;
            // 
            // flowTotal
            // 
            flowTotal.AutoScroll = true;
            flowTotal.Location = new Point(23, 111);
            flowTotal.Name = "flowTotal";
            flowTotal.Size = new Size(276, 162);
            flowTotal.TabIndex = 1026;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.White;
            txtTotal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.ForeColor = Color.Brown;
            txtTotal.Location = new Point(139, 370);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(160, 30);
            txtTotal.TabIndex = 1025;
            txtTotal.Text = "0";
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDiscount
            // 
            txtDiscount.BackColor = Color.White;
            txtDiscount.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiscount.ForeColor = Color.FromArgb(22, 26, 48);
            txtDiscount.Location = new Point(139, 330);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(160, 30);
            txtDiscount.TabIndex = 1024;
            txtDiscount.Text = "0";
            txtDiscount.TextAlign = HorizontalAlignment.Right;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            txtDiscount.KeyPress += txtDiscount_KeyPress;
            // 
            // txtTamTinh
            // 
            txtTamTinh.BackColor = Color.White;
            txtTamTinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTamTinh.ForeColor = Color.FromArgb(22, 26, 48);
            txtTamTinh.Location = new Point(139, 288);
            txtTamTinh.Name = "txtTamTinh";
            txtTamTinh.ReadOnly = true;
            txtTamTinh.Size = new Size(160, 30);
            txtTamTinh.TabIndex = 1023;
            txtTamTinh.Text = "0";
            txtTamTinh.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(22, 26, 48);
            label6.Location = new Point(23, 373);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 1020;
            label6.Text = "Thành tiền:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(22, 26, 48);
            label5.Location = new Point(23, 333);
            label5.Name = "label5";
            label5.Size = new Size(97, 23);
            label5.TabIndex = 1019;
            label5.Text = "Chiết khấu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(22, 26, 48);
            label4.Location = new Point(23, 291);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 1018;
            label4.Text = "Tạm tính:";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(182, 187, 196);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(182, 187, 196);
            btnReset.FlatAppearance.BorderSize = 2;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.FromArgb(22, 26, 48);
            btnReset.Location = new Point(168, 422);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(131, 50);
            btnReset.TabIndex = 1017;
            btnReset.Text = "Đặt lại";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(49, 48, 77);
            btnPay.Cursor = Cursors.Hand;
            btnPay.FlatAppearance.BorderColor = Color.FromArgb(22, 26, 48);
            btnPay.FlatAppearance.BorderSize = 2;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(23, 422);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(131, 50);
            btnPay.TabIndex = 1016;
            btnPay.Text = "Thanh toán";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaHD.ForeColor = Color.FromArgb(49, 48, 77);
            lblMaHD.Location = new Point(98, 68);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(64, 23);
            lblMaHD.TabIndex = 5;
            lblMaHD.Text = "#mahd";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(22, 26, 48);
            label3.Location = new Point(23, 68);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 4;
            label3.Text = "Mã HD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(22, 26, 48);
            label2.Location = new Point(23, 21);
            label2.Name = "label2";
            label2.Size = new Size(214, 28);
            label2.TabIndex = 3;
            label2.Text = "Thông tin thanh toán";
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(flowListMenu);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(465, 481);
            panelMenu.TabIndex = 1;
            // 
            // flowListMenu
            // 
            flowListMenu.AutoScroll = true;
            flowListMenu.Dock = DockStyle.Fill;
            flowListMenu.Location = new Point(0, 125);
            flowListMenu.Name = "flowListMenu";
            flowListMenu.Size = new Size(465, 356);
            flowListMenu.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 125);
            panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.FromArgb(22, 26, 48);
            txtSearch.Location = new Point(12, 66);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm...";
            txtSearch.Size = new Size(407, 30);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(22, 26, 48);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 1;
            label1.Text = "Danh sách món ăn";
            // 
            // FormSell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 229);
            ClientSize = new Size(776, 481);
            Controls.Add(panelMenu);
            Controls.Add(panelTotal);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSell";
            Text = "FormSell";
            Load += FormSell_Load;
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTotal;
        private Panel panelMenu;
        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowListMenu;
        private TextBox txtSearch;
        private Label lblMaHD;
        private Label label3;
        private Label label2;
        private Button btnPay;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnReset;
        private FlowLayoutPanel flowTotal;
        private TextBox txtTotal;
        private TextBox txtDiscount;
        private TextBox txtTamTinh;
    }
}