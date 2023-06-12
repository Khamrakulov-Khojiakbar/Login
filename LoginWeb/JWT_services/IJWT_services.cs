using Application.Interfaces;
using Domain.Models;

namespace LoginWeb.JWT_services
{
    public interface IJWT_services
    {
        public bool Authen(UserCredentials user);
        public string CreateToken(UserCredentials user);
    }
}
