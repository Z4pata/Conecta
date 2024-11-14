using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Conecta.Models;
using Microsoft.IdentityModel.Tokens;

namespace Conecta.Config
{
    public class JWT
    {
        public static string GenerateJwtToken(User user)
        {



            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Role, user?.Role?.Name ?? "user")
            };

            var jwtKey = Environment.GetEnvironmentVariable("JWT_KEY") ?? throw new InvalidOperationException("JWT Key Not found");
            var jwtIssuer = Environment.GetEnvironmentVariable("JWT_ISSUER") ?? throw new InvalidOperationException("Issuer Not found");
            var jwtExpiresIn = Environment.GetEnvironmentVariable("JWT_EXPIRES_IN");

            // Validar que las variables existen
            if (string.IsNullOrEmpty(jwtKey) || string.IsNullOrEmpty(jwtIssuer))
            {
                throw new InvalidOperationException("JWT configuration values are missing.");
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: jwtIssuer,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(jwtExpiresIn)),
                signingCredentials: credentials
            );



            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}