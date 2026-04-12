using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using CLEAN.CQRS.INFRASTRUCTURE.Persistence;
using CLEAN.CQRS.DOMAIN.Interfaces;
using CLEAN.CQRS.INFRASTRUCTURE.Persistence.Repositories;

namespace CLEAN.CQRS.INFRASTRUCTURE;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("MySQL");

        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString)
            )
        );

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}