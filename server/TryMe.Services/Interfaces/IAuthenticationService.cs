using System.Security.Claims;
using TryMe.Domain.Requests;

namespace TryMe.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<ClaimsPrincipal> ValidateUserAsync(Credential credentials, CancellationToken cancellationToken);
    }
}
