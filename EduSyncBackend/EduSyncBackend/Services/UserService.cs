//using System;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
//using System.Text;
//using EduSyncBackend.Models;
//using Microsoft.Extensions.Configuration;
//using Microsoft.IdentityModel.Tokens;

//namespace EduSyncBackend.Services
//{
//    public class UserService : IUserService
//    {
//        private readonly IConfiguration _config;

//        public UserService(IConfiguration config)
//        {
//            _config = config;
//        }

//        public string HashPassword(string password)
//        {
//            return BCrypt.Net.BCrypt.HashPassword(password);
//        }

//        public bool VerifyPassword(string password, string hash)
//        {
//            return BCrypt.Net.BCrypt.Verify(password, hash);
//        }

//        public string GenerateJwtToken(User user)
//        {
//            var claims = new[]
//            {
//                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
//                new Claim(ClaimTypes.Email, user.Email),
//                new Claim(ClaimTypes.Role, user.Role),
//                new Claim("name", user.Name)
//            };

//            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
//            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

//            var token = new JwtSecurityToken(
//                issuer: _config["Jwt:Issuer"],
//                audience: _config["Jwt:Audience"],
//                claims: claims,
//                expires: DateTime.UtcNow.AddHours(1),
//                signingCredentials: creds);

//            return new JwtSecurityTokenHandler().WriteToken(token);
//        }
//    }
//}