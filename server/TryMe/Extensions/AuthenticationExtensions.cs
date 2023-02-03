using Microsoft.AspNetCore.Authentication.Cookies;
using TryMe.Domain.Constans;

namespace TryMe.Extensions
{
    public static class AuthenticationExtensions
    {
        public static IServiceCollection ConfigureCookieAuthentication(this IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.Cookie.Name = CookieConstans.CookieName;
                options.Cookie.SameSite = SameSiteMode.None;
                options.Events.OnRedirectToLogin = (context) =>
                {
                    context.Response.StatusCode = 401;
                    context.Response.WriteAsync("Unauthorized");
                    return Task.CompletedTask;
                };
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
            });

            return services;
        }
    }
}
