namespace RegisterSystem
{
    partial class RegisterForm
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
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            lblHeading = new Label();
            chbShowPassword = new CheckBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(109, 132);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(302, 28);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Въведете потребителско име";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(109, 174);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(302, 34);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(109, 276);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(302, 34);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(109, 234);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(180, 28);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Въведете парола";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(109, 398);
            txtConfirmPassword.Margin = new Padding(4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(302, 34);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(109, 350);
            lblConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(204, 28);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Потвърдете парола";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblHeading.Location = new Point(88, 50);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(350, 41);
            lblHeading.TabIndex = 6;
            lblHeading.Text = "Форма за регистрация";
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.Location = new Point(222, 439);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(189, 32);
            chbShowPassword.TabIndex = 7;
            chbShowPassword.Text = "Покажи парола";
            chbShowPassword.UseVisualStyleBackColor = true;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(109, 508);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(302, 61);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 637);
            Controls.Add(btnRegister);
            Controls.Add(chbShowPassword);
            Controls.Add(lblHeading);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "RegisterForm";
            Text = "Форма за регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private Label lblHeading;
        private CheckBox chbShowPassword;
        private Button btnRegister;
    }
}
