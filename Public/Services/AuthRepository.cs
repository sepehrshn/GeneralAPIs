using Public.Contaract;
using Public.DTOs;

namespace Public.Services
{
    public class AuthRepository : IAuth
    {

        private readonly IJWTService jWTService;
        public AuthRepository(IJWTService jWTService)
        {
            this.jWTService = jWTService;
        }
        public UserDTO GetUser(string Token)
        {
            throw new System.NotImplementedException();
        }

        public string Login(LoginDTO loginDTO)
        {
            string find_user_query = $@"select UserName,PassWord from ClientAdmins where UserName like N'{loginDTO.UserName}' and PassWord like '{loginDTO.PassWord}'";
            LoginDTO user = DataService<LoginDTO>.GetObject(find_user_query);
            if (user == null)
            {
                return null;
            }
            return jWTService.Generate(user.UserName);
        }
    }
}
