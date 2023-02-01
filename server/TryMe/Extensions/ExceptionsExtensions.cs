using Hellang.Middleware.ProblemDetails;
using Microsoft.AspNetCore.Mvc;
using TryMe.Domain.Exceptions;

namespace TryMe.Extensions
{
    public static class ExceptionsExtensions
    {
        public static IServiceCollection ConfigureProblemDetails(this IServiceCollection services, IHostEnvironment environment)
        {
            services.AddProblemDetails(options =>
            {
                options.IncludeExceptionDetails = (_, _) => environment.IsDevelopment();

                options.Map<InvalidUserException>(ex => new ProblemDetails
                {
                    Title = "Failed to validate user",
                    Status = StatusCodes.Status401Unauthorized,
                    Detail = ex.Message,
                });
            });

            return services;
        }
    }
}
