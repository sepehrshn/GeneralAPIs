using Microsoft.IdentityModel.Tokens;
using Public.Contaract;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Public.Services
{
    public class JWTService : IJWTService
    {
        static string SecureKey => "B0EE93D6-0DE3-4FBE-8C77-60A9529CFFEB";

        public string Generate(string id)
        {
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecureKey));
            var cedentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);
            var header = new JwtHeader(cedentials);



            var payload = new JwtPayload(id.ToString(), null, null, null, DateTime.Today.AddDays(10));
            var securityToken = new JwtSecurityToken(header, payload);
            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }

        public JwtSecurityToken Verify(string jwt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(SecureKey);
            tokenHandler.ValidateToken(jwt, new TokenValidationParameters()
            {
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuerSigningKey = true,
                ValidateIssuer = false,
                ValidateAudience = false
            }, out SecurityToken validatetoken);

            return (JwtSecurityToken)validatetoken;
        }
    }
}
