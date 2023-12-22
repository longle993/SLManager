namespace QLBH
{
    partial class FormRegister
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
            btnLogin = new Label();
            btnRegister = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtConfirm = new TextBox();
            label6 = new Label();
            lblError = new Label();
            txtBirth = new DateTimePicker();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.FromArgb(22, 26, 48);
            btnLogin.Location = new Point(147, 547);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(128, 20);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Đăng nhập ngay!";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(49, 48, 77);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(22, 26, 48);
            btnRegister.FlatAppearance.BorderSize = 2;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(147, 478);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(131, 50);
            btnRegister.TabIndex = 99;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += lblRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(22, 26, 48);
            txtPassword.Location = new Point(53, 332);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "nhập mật khẩu...";
            txtPassword.Size = new Size(334, 30);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.FromArgb(22, 26, 48);
            txtUserName.Location = new Point(53, 108);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "nhập sđt...";
            txtUserName.Size = new Size(334, 30);
            txtUserName.TabIndex = 1;
            txtUserName.KeyPress += txtUserName_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(22, 26, 48);
            label3.Location = new Point(147, 30);
            label3.Name = "label3";
            label3.Size = new Size(143, 38);
            label3.TabIndex = 99;
            label3.Text = "ĐĂNG KÝ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(22, 26, 48);
            label2.Location = new Point(53, 306);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 99;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(22, 26, 48);
            label1.Location = new Point(53, 82);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 99;
            label1.Text = "Số điện thoại:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.FromArgb(22, 26, 48);
            txtName.Location = new Point(53, 180);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "nhập tên...";
            txtName.Size = new Size(334, 30);
            txtName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(22, 26, 48);
            label4.Location = new Point(53, 154);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 99;
            label4.Text = "Họ và Tên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(22, 26, 48);
            label5.Location = new Point(53, 228);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 99;
            label5.Text = "Ngày sinh:";
            // 
            // txtConfirm
            // 
            txtConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirm.ForeColor = Color.FromArgb(22, 26, 48);
            txtConfirm.Location = new Point(53, 409);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PlaceholderText = "xác nhận mật khẩu...";
            txtConfirm.Size = new Size(334, 30);
            txtConfirm.TabIndex = 5;
            txtConfirm.UseSystemPasswordChar = true;
            txtConfirm.TextChanged += txtConfirm_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(22, 26, 48);
            label6.Location = new Point(53, 383);
            label6.Name = "label6";
            label6.Size = new Size(164, 23);
            label6.TabIndex = 99;
            label6.Text = "Xác nhận mật khẩu:";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(248, 442);
            lblError.Name = "lblError";
            lblError.Size = new Size(139, 17);
            lblError.TabIndex = 99;
            lblError.Text = "Mật khẩu không khớp!";
            lblError.Visible = false;
            // 
            // txtBirth
            // 
            txtBirth.CustomFormat = "dd/MM/yyyy";
            txtBirth.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBirth.Format = DateTimePickerFormat.Custom;
            txtBirth.Location = new Point(53, 254);
            txtBirth.Name = "txtBirth";
            txtBirth.Size = new Size(334, 30);
            txtBirth.TabIndex = 100;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 229);
            ClientSize = new Size(436, 584);
            Controls.Add(txtBirth);
            Controls.Add(lblError);
            Controls.Add(txtConfirm);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            Load += FormRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnLogin;
        private Button btnRegister;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtName;
        private Label label4;
        private Label label5;
        private TextBox txtConfirm;
        private Label label6;
        private Label lblError;
        private DateTimePicker txtBirth;
    }
}