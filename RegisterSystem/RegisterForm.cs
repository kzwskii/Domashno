using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RegisterSystem.Repository;
using RegisterSystem.Models;
using System.Linq;

namespace RegisterSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (RegisterEventHelpers.CheckAllFields(
                    txtUsername.Text, 
                    txtPassword.Text, 
                    txtConfirmPassword.Text))
            {
                MessageBox.Show(
                    "All fields must have a value!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show(
                    "Passwords must match!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (txtPassword.TextLength < 8 ||
                txtConfirmPassword.TextLength < 8)
            {
                MessageBox.Show(
                    "Password must have at least 8 chars",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }
            try
            {
                var repo = new UserRepository();
                var exists = repo.GetAll().Any(u => u.Username == txtUsername.Text);
                if (exists)
                {
                    MessageBox.Show("User already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var user = new User
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };

                repo.Add(user);

                MessageBox.Show("Registration is successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var loginForm = new LoginForm();
                loginForm.FormClosed += (s, args) => this.Close();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error upon registration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
