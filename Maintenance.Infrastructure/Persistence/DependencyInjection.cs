using Maintenance.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Maintenance.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<MaintenanceDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("MaintenanceConnection")));

        return services;
    }
}