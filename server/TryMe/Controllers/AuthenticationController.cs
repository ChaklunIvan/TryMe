using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
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
        public async Task<ActionResult<bool>> LoginAsync([FromBody] Credential credentials, CancellationToken cancellationToken)
        {
            var claimPrincipal = await _authenticationService.ValidateUserAsync(credentials, cancellationToken);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal, new AuthenticationProperties
            {
                IsPersistent = true,
                AllowRefresh = true,
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
            });

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<bool>> IsAuthenticated()
        {
            bool? isAuthenticated = false;

            await Task.Run(() =>
            {
                isAuthenticated = HttpContext.User.Identity?.IsAuthenticated;
            });

            return Ok(isAuthenticated);
        }
    }
}
