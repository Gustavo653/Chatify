using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Chatify.Service.Interface;
using Chatify.Domain.Identity;

namespace Chatify.Service
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _config;
        public readonly SymmetricSecurityKey _key;

        public TokenService(IConfiguration config)
        {
            _config = config;
            _key = GetSecurityKey(config["TokenKey"]!);
        }

        private SymmetricSecurityKey GetSecurityKey(string key)
        {
            if (string.IsNullOrEmpty(key) || key.Length < 64)
            {
                byte[] keyBytes = new byte[64];
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(keyBytes);
                }
                key = Convert.ToBase64String(keyBytes);
                _config["TokenKey"] = key;
            }

            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
        }

        public async Task<string> CreateToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Email, user.Email!),
            };

            claims.AddRange(user.UserRoles.Select(role => new Claim(ClaimTypes.Role, role.Role.Name!)));

            var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescription);

            return tokenHandler.WriteToken(token);
        }
    }
}
