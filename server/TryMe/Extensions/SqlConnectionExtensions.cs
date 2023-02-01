using Microsoft.EntityFrameworkCore;
using TryMe.Data;

namespace TryMe.Extensions
{
    public static class SqlConnectionExtensions
    {
        public static IServiceCollection ConfigureSqliteContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(opts =>
            opts.UseLazyLoadingProxies().UseSqlite(configuration.GetConnectionString("Sqlite")));
            return services;
        }
    }
}
