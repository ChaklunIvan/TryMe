using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;
using TryMe.Domain.Constans;
using TryMe.Domain.Requests;

namespace TryMe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly Services.Interfaces.IAuthenticationService _authenticationService;

        public AuthenticationController(Services.Interfaces.IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost]
        public async Task<ActionResult> LoginAsync([FromBody] Credential credentials, CancellationToken cancellationToken)
        {
            var claimPrincipal = await _authenticationService.ValidateUserAsync(credentials, cancellationToken);

            await HttpContext.SignInAsync(CookieConstans.AuthenticationScheme, claimPrincipal);

            return Ok();
        }
    }
}
