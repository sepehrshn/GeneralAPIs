using Public.Contaract;
using Public.DTOs;

namespace Public.Services
{
    public class AuthRepository : IAuth
    {
        public UserDTO GetUser(string Token)
        {
            throw new System.NotImplementedException();
        }

        public string Login(LoginDTO loginDTO)
        {
            throw new System.NotImplementedException();
        }
    }
}
