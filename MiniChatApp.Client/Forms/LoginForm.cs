using Microsoft.IdentityModel.Tokens;
using MiniChatApp.Repositories.Contracts;
using MiniChatApp.ViewModels.Systems;

namespace MiniChatApp.Client.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IAuthRepository _authRepository;

        public LoginForm(IAuthRepository authRepository)
        {
            InitializeComponent();
            _authRepository = authRepository;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openRegisterFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var userName = userNameTextBox.Text;
            var password = passwordTextBox.Text;

            var payload = new LoginRequest
            {
                UserName = userName,
                Password = password,
            };

            var errorMessage = _authRepository.Login(payload);

            if (!errorMessage.IsNullOrEmpty())
            {
                //TODO: Notify error
                MessageBox.Show(errorMessage);
            }
            else
            {
                //TODO: Notify login successfully -> Hidden Login form -> Show Main form
                MessageBox.Show("Login successfully!");
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }
    }
}
