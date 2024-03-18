using Microsoft.Extensions.DependencyInjection;

namespace MiniChatApp.Client.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openLoginFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>())
            {
                loginForm.Show();
            }
        }
    }
}
