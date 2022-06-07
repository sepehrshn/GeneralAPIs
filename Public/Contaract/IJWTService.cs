using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public.Contaract
{
    public interface IJWTService
    {
       static string SecureKey { get; }
        string Generate(string id);
        JwtSecurityToken Verify(string jwt);
    }
}
