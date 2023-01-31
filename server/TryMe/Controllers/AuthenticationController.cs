using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;
using TryMe.Domain.Requests;

namespace TryMe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> LoginAsync([FromBody] Credential credentials)
        {
            if (credentials.UserName == "admin" && credentials.Password == "password")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "admin"),
                };

                var identity = new ClaimsIdentity(claims, "CookieAuthentication");

                var claimPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("CookieAuthentication", claimPrincipal);
            }

            return Ok();
        }
    }
}
