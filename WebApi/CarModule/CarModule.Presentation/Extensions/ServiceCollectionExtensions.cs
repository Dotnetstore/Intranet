using CarModule.Application;
using CarModule.Infrastructure;
using CarModule.Infrastructure.Extensions;
using FastEndpoints;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarModule.Presentation.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCarModuleServices(
        this IServiceCollection services,
        IConfigurationManager configurationManager)
    {
        services
            .AddCarModuleInfrastructure(configurationManager)
            .AddFastEndpoints();

        services
            .AddMediatR(x =>
            {
                x.RegisterServicesFromAssemblies(
                    typeof(IApplicationAssemblyMarker).Assembly,
                    typeof(IInfrastructureAssemblyMarker).Assembly);
            });
        
        return services;
    }
}