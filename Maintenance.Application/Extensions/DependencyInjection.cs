using Maintenance.Application.Interfaces.Services;
using Maintenance.Application.Services;
using Microsoft.Extensions.DependencyInjection;


namespace Maintenance.Application.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection services)
        {
            services.AddScoped<IEquipmentService, EquipmentService>();

            return services;
        }
    }
}
