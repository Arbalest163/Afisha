using Afisha.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Afisha.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence
            (this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<AfishaDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddScoped<IAfishaDbContext>(provider =>
                provider.GetService<AfishaDbContext>());
            return services;
        }
    }
}
