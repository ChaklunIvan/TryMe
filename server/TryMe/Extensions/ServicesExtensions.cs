using TryMe.Services;
using TryMe.Services.Interfaces;

namespace TryMe.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<ITestService, TestService>();

            return services;
        }
    }
}
