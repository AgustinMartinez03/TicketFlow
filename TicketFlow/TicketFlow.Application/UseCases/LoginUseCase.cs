using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TicketFlow.Application.DTOs;
using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Exceptions;
using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Application.Interfaces.IMapper;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.UseCases
{
    public class LoginUseCase : ILoginUseCase
    {
        private readonly IUserQuery _userQuery;
        private readonly JwtSettings _jwtSettings;
        private readonly ILoginMapper _mapper;
        private readonly IAuditLogCommand _auditLogCommand;

        public LoginUseCase(IUserQuery userQuery, JwtSettings jwtSettings, ILoginMapper mapper, IAuditLogCommand auditLogCommand)
        {
            _userQuery = userQuery;
            _jwtSettings = jwtSettings;
            _mapper = mapper;
            _auditLogCommand = auditLogCommand;
        }

        public async Task<LoginResponse> ExecuteAsync(LoginRequest request)
        {
            var user = await _userQuery.GetUserByEmailAsync(request.Email);

            if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
            {
                var failedLog = new AuditLog
                {
                    UserId = user?.Id,
                    Action = "LOGIN_FAILED",
                    EntityType = "User",
                    EntityId = user?.Id.ToString() ?? "N/A",
                    Details = $"Intento fallido de inicio de sesión para el email: {request.Email}",
                    CreatedAt = DateTime.UtcNow
                };

                _auditLogCommand.InsertAuditLog(failedLog);
                await _auditLogCommand.SaveChangesAsync();

                throw new ExceptionBadRequest("Email o contraseña incorrectos.");
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: credentials);

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            var successLog = new AuditLog
            {
                UserId = user.Id,
                Action = "LOGIN_SUCCESS",
                EntityType = "User",
                EntityId = user.Id.ToString(),
                Details = "Inicio de sesión exitoso.",
                CreatedAt = DateTime.UtcNow
            };

            _auditLogCommand.InsertAuditLog(successLog);
            await _auditLogCommand.SaveChangesAsync();

            return _mapper.MapToLoginResponse(user, tokenString);
        }
    }
}