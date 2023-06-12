using Application.Interfaces;
using Domain.Models;
using LoginWeb.JWT_services;

namespace LoginWeb.JWTService
{
    public class JWTTokenService : IJWT_services
    {
        //private readonly IConfiguration _configuration;

        private readonly IUserRepository _userRepo;
        public JWTTokenService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public bool Authen(UserCredentials user)
        {
            List<Users> usersList = (await _userRepo.GetAllAsync()).ToList();
            return usersList.Exists(x => x.Username.Equals(user.Username) && x.Password.Equals(user.Password));
        }

        public string CreateToken(UserCredentials user)
        {
            List<Users> usersList = (await _userRepo.GetAllAsync()).ToList();
            var user1 = usersList.FirstOrDefault(x => x.Username.Equals(user.Username) && x.Password.Equals(user.Password);
        }
    }
}