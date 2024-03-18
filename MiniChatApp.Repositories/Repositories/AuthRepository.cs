using MiniChatApp.Repositories.Contracts;
using MiniChatApp.Repositories.Data;
using MiniChatApp.Repositories.Data.Entities;
using MiniChatApp.ViewModels.Systems;

namespace MiniChatApp.Repositories.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private ApplicationDbContext _context;

        public AuthRepository()
        {
            _context = new ApplicationDbContext();
        }

        public string Login(LoginRequest request)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserName == request.UserName);

            if (user == null)
            {
                return "User does not exist";
            }

            var isValidPassword = BCrypt.Net.BCrypt.Verify(request.Password, user.Password);

            if (!isValidPassword)
            {
                return "Wrong password";
            }

            return "";
        }

        public string Register(RegisterRequest request)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserName == request.UserName);
            if (user != null)
            {
                return "User name already existed";
            }

            user = _context.Users.FirstOrDefault(user => user.Email == request.Email);
            if (user != null)
            {
                return "Email already existed";
            }

            user = new User()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = request.UserName,
                Email = request.Email,
                FullName = request.FullName
            };

            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(request.Password);
            if (hashedPassword != null)
            {
                return "Something went wrong!";
            }

            user.Password = hashedPassword;

            _context.Users.Add(user);
            _context.SaveChanges();

            return "";
        }
    }
}
