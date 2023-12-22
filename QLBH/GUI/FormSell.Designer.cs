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
            panelMenu = new Panel();
            flowListMenu = new FlowLayoutPanel();
            panel1 = new Panel();
            txtSearch = new TextBox();
            label1 = new Label();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTotal
            // 
            panelTotal.Dock = DockStyle.Right;
            panelTotal.Location = new Point(465, 0);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(311, 564);
            panelTotal.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(flowListMenu);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(465, 564);
            panelMenu.TabIndex = 1;
            // 
            // flowListMenu
            // 
            flowListMenu.AutoScroll = true;
            flowListMenu.Dock = DockStyle.Fill;
            flowListMenu.Location = new Point(0, 125);
            flowListMenu.Name = "flowListMenu";
            flowListMenu.Size = new Size(465, 439);
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
            ClientSize = new Size(776, 564);
            Controls.Add(panelMenu);
            Controls.Add(panelTotal);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSell";
            Text = "FormSell";
            Load += FormSell_Load;
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
    }
}