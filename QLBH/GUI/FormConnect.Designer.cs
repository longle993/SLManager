namespace QLBH.GUI
{
    partial class FormConnect
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
            txtFilePath = new TextBox();
            label1 = new Label();
            label3 = new Label();
            btnConnect = new Button();
            SuspendLayout();
            // 
            // txtFilePath
            // 
            txtFilePath.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtFilePath.ForeColor = Color.FromArgb(22, 26, 48);
            txtFilePath.Location = new Point(107, 130);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.PlaceholderText = "nhập đường dẫn đến file QLBH...";
            txtFilePath.Size = new Size(334, 30);
            txtFilePath.TabIndex = 1000;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(22, 26, 48);
            label1.Location = new Point(107, 104);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 1001;
            label1.Text = "Đường dẫn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(22, 26, 48);
            label3.Location = new Point(159, 29);
            label3.Name = "label3";
            label3.Size = new Size(243, 38);
            label3.TabIndex = 1002;
            label3.Text = "KẾT NỐI DỮ LIỆU";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(49, 48, 77);
            btnConnect.Cursor = Cursors.Hand;
            btnConnect.FlatAppearance.BorderColor = Color.FromArgb(22, 26, 48);
            btnConnect.FlatAppearance.BorderSize = 2;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(214, 194);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(131, 50);
            btnConnect.TabIndex = 1003;
            btnConnect.Text = "Kết nối";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // FormConnect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 229);
            ClientSize = new Size(560, 271);
            Controls.Add(btnConnect);
            Controls.Add(label3);
            Controls.Add(txtFilePath);
            Controls.Add(label1);
            Name = "FormConnect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConnect";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilePath;
        private Label label1;
        private Label label3;
        private Button btnConnect;
    }
}