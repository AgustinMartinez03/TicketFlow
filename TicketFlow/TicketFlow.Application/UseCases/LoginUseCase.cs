using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using TicketFlow.Application.DTOs;
using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Exceptions;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.Application.UseCases
{
    public class LoginUseCase : ILoginUseCase
    {
        private readonly IUserQuery _userQuery;
        private readonly JwtSettings _jwtSettings; // 👈 Usamos JwtSettings en lugar de IConfiguration

        public LoginUseCase(IUserQuery userQuery, JwtSettings jwtSettings) // 👈 Inyección limpia
        {
            _userQuery = userQuery;
            _jwtSettings = jwtSettings;
        }

        public async Task<LoginResponse> ExecuteAsync(LoginRequest request)
        {
            var user = await _userQuery.GetUserByEmailAsync(request.Email);

            if (user == null || user.PasswordHash != request.Password)
            {
                throw new ExceptionBadRequest("Email o contraseña incorrectos.");
            }

            // 1. Usamos la propiedad Key de nuestro objeto JwtSettings
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role)
            };

            // 2. Usamos Issuer y Audience desde el objeto JwtSettings
            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: credentials);

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return new LoginResponse
            {
                Token = tokenString,
                Name = user.Name,
                Role = user.Role
            };
        }
    }
}