using Microsoft.IdentityModel.Tokens;
using ArtifexPay.Backbone.Domain;
using ArtifexPay.Backbone.DTO.User;
using ArtifexPay.Backbone.Enums;
using ArtifexPay.Backbone.Security;
using ArtifexPay.Backbone.Services;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ArtifexPay.Core.Security.Internals
{
    internal class JwtTokenGenerator : ITokenGenerator
    {
        public string GenerateToken(ArtifexUser User)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Constants.Key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                            new Claim(ClaimTypes.NameIdentifier, User.Id.ToString()),
                            new Claim(ClaimTypes.Name, User.Username.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString;
        }
    }
}
