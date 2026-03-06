namespace RegisterSystem
{
    partial class LoginForm
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
            btnRegister = new Button();
            chbShowPassword = new CheckBox();
            lblHeading = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(138, 419);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(302, 61);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Вход";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.Location = new Point(251, 337);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(189, 32);
            chbShowPassword.TabIndex = 16;
            chbShowPassword.Text = "Покажи парола";
            chbShowPassword.UseVisualStyleBackColor = true;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblHeading.Location = new Point(178, 80);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(236, 41);
            lblHeading.TabIndex = 15;
            lblHeading.Text = "Форма за вход";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(138, 296);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(302, 34);
            txtPassword.TabIndex = 12;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(138, 254);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(180, 28);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Въведете парола";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(138, 216);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(302, 34);
            txtUsername.TabIndex = 10;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(138, 152);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(302, 28);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Въведете потребителско име";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 536);
            Controls.Add(btnRegister);
            Controls.Add(chbShowPassword);
            Controls.Add(lblHeading);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private CheckBox chbShowPassword;
        private Label lblHeading;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
    }
}