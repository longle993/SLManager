namespace QLBH
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblShowPass = new Label();
            btnLogin = new Button();
            lblRegister = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(22, 26, 48);
            label1.Location = new Point(53, 124);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 999;
            label1.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(22, 26, 48);
            label2.Location = new Point(53, 230);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 999;
            label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(22, 26, 48);
            label3.Location = new Point(128, 40);
            label3.Name = "label3";
            label3.Size = new Size(188, 38);
            label3.TabIndex = 999;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.FromArgb(22, 26, 48);
            txtUserName.Location = new Point(53, 150);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "nhập số điện thoại...";
            txtUserName.Size = new Size(334, 30);
            txtUserName.TabIndex = 1;
            txtUserName.KeyPress += txtUserName_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(22, 26, 48);
            txtPassword.Location = new Point(53, 256);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "nhập mật khẩu...";
            txtPassword.Size = new Size(334, 30);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblShowPass
            // 
            lblShowPass.AutoSize = true;
            lblShowPass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblShowPass.ForeColor = Color.FromArgb(22, 26, 48);
            lblShowPass.Location = new Point(346, 289);
            lblShowPass.Name = "lblShowPass";
            lblShowPass.Size = new Size(41, 20);
            lblShowPass.TabIndex = 999;
            lblShowPass.Text = "Hiện";
            lblShowPass.Click += lblShowPass_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(49, 48, 77);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(22, 26, 48);
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(147, 332);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(131, 50);
            btnLogin.TabIndex = 999;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Cursor = Cursors.Hand;
            lblRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegister.ForeColor = Color.FromArgb(22, 26, 48);
            lblRegister.Location = new Point(175, 400);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(66, 20);
            lblRegister.TabIndex = 999;
            lblRegister.Text = "Đăng ký";
            lblRegister.Click += lblRegister_Click;
            // 
            // FormLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 236, 229);
            ClientSize = new Size(436, 461);
            Controls.Add(lblRegister);
            Controls.Add(btnLogin);
            Controls.Add(lblShowPass);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblShowPass;
        private Button btnLogin;
        private Label lblRegister;
    }
}