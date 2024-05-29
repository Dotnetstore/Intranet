using Microsoft.Extensions.DependencyInjection;

namespace CarModule;

public static class CarModuleServiceCollectionExtensions
{
    public static IServiceCollection AddCarModuleServices(this IServiceCollection services)
    {
        services.AddScoped<ICarMakeService, CarMakeService>();
        return services;
    }
}