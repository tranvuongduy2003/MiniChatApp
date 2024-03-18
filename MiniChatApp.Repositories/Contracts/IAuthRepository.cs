using MiniChatApp.ViewModels.Systems;

namespace MiniChatApp.Repositories.Contracts
{
    public interface IAuthRepository
    {
        string Login(LoginRequest request);
        string Register(RegisterRequest request);
    }
}
