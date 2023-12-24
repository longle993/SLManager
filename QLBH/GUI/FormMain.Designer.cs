namespace QLBH.GUI
{
    partial class FormMain
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
            panel4 = new Panel();
            btnLogout = new Button();
            btnHoaDon = new Button();
            btnFood = new Button();
            btnBanHang = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panelMain = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            lblWelcome = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panelMain.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 26, 48);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 564);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnLogout);
            panel4.Controls.Add(btnHoaDon);
            panel4.Controls.Add(btnFood);
            panel4.Controls.Add(btnBanHang);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 125);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 439);
            panel4.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(49, 48, 77);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.FromArgb(182, 187, 196);
            btnLogout.Image = Properties.Resources.right_from_bracket_solid;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 366);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 10, 0);
            btnLogout.Size = new Size(250, 73);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            btnLogout.MouseEnter += btnBanHang_MouseEnter;
            btnLogout.MouseLeave += btnBanHang_MouseLeave;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.FlatAppearance.BorderColor = Color.FromArgb(49, 48, 77);
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHoaDon.ForeColor = Color.FromArgb(182, 187, 196);
            btnHoaDon.Image = Properties.Resources.shopping_list;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(0, 146);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(10, 0, 10, 0);
            btnHoaDon.Size = new Size(250, 73);
            btnHoaDon.TabIndex = 2;
            btnHoaDon.Text = "Hoá đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            btnHoaDon.MouseEnter += btnBanHang_MouseEnter;
            btnHoaDon.MouseLeave += btnBanHang_MouseLeave;
            // 
            // btnFood
            // 
            btnFood.Dock = DockStyle.Top;
            btnFood.FlatAppearance.BorderColor = Color.FromArgb(49, 48, 77);
            btnFood.FlatStyle = FlatStyle.Flat;
            btnFood.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFood.ForeColor = Color.FromArgb(182, 187, 196);
            btnFood.Image = Properties.Resources.utensils_solid__1_;
            btnFood.ImageAlign = ContentAlignment.MiddleLeft;
            btnFood.Location = new Point(0, 73);
            btnFood.Name = "btnFood";
            btnFood.Padding = new Padding(10, 0, 10, 0);
            btnFood.Size = new Size(250, 73);
            btnFood.TabIndex = 1;
            btnFood.Text = "Món ăn";
            btnFood.UseVisualStyleBackColor = true;
            btnFood.Click += btnFood_Click;
            btnFood.MouseEnter += btnBanHang_MouseEnter;
            btnFood.MouseLeave += btnBanHang_MouseLeave;
            // 
            // btnBanHang
            // 
            btnBanHang.Dock = DockStyle.Top;
            btnBanHang.FlatAppearance.BorderColor = Color.FromArgb(49, 48, 77);
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBanHang.ForeColor = Color.FromArgb(182, 187, 196);
            btnBanHang.Image = Properties.Resources.cart1;
            btnBanHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnBanHang.Location = new Point(0, 0);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Padding = new Padding(10, 0, 10, 0);
            btnBanHang.Size = new Size(250, 73);
            btnBanHang.TabIndex = 0;
            btnBanHang.Text = "Bán hàng";
            btnBanHang.UseVisualStyleBackColor = true;
            btnBanHang.Click += btnBanHang_Click;
            btnBanHang.MouseEnter += btnBanHang_MouseEnter;
            btnBanHang.MouseLeave += btnBanHang_MouseLeave;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(240, 236, 229);
            label1.Location = new Point(26, 45);
            label1.Name = "label1";
            label1.Size = new Size(197, 38);
            label1.TabIndex = 2;
            label1.Text = "SL MANAGER";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(240, 236, 229);
            panelMain.Controls.Add(panel2);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(776, 564);
            panelMain.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblWelcome);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 83);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(640, 28);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 1;
            label2.Text = "13/12/2023";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.FromArgb(22, 26, 48);
            lblWelcome.Location = new Point(36, 21);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(169, 31);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome back";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 564);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            FormClosed += FormMain_FormClosed;
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelMain.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelMain;
        private Panel panel2;
        private Label label2;
        private Label lblWelcome;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Button btnBanHang;
        private Button btnHoaDon;
        private Button btnFood;
        private Button btnLogout;
    }
}