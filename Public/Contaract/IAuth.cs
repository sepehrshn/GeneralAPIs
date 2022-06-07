using Public.DTOs;

namespace Public.Contaract
{
    public interface IAuth
    {
        string Login(LoginDTO loginDTO);
        UserDTO GetUser(string Token);

    }
}
