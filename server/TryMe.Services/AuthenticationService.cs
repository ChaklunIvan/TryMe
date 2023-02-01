using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TryMe.Data;
using TryMe.Domain.Constans;
using TryMe.Domain.Exceptions;
using TryMe.Domain.Requests;
using TryMe.Services.Interfaces;

namespace TryMe.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly ApplicationDbContext _context;

        public AuthenticationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ClaimsPrincipal> ValidateUserAsync(Credential credentials, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == credentials.UserName, cancellationToken);
            if (user == null || !BCrypt.Net.BCrypt.Verify(credentials.Password, user.PasswordHash))
            {
                throw new InvalidUserException("User not found or incorect password");
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
            };

            var identity = new ClaimsIdentity(claims, CookieConstans.AuthenticationScheme);

            return new ClaimsPrincipal(identity);
        }
    }
}
