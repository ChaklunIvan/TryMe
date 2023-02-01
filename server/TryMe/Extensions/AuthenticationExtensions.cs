using TryMe.Domain.Constans;

namespace TryMe.Extensions
{
    public static class AuthenticationExtensions
    {
        public static IServiceCollection ConfigureCookieAuthentication(this IServiceCollection services)
        {
            services.AddAuthentication(CookieConstans.AuthenticationScheme).AddCookie(CookieConstans.AuthenticationScheme, options =>
            {
                options.Cookie.Name = CookieConstans.CookieName;
            });

            return services;
        }
    }
}
