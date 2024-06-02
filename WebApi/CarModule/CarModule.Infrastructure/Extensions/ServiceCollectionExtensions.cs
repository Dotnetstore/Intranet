using CarModule.Infrastructure.Persistence.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarModule.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCarModuleInfrastructure(
        this IServiceCollection services,
        IConfigurationManager configurationManager)
    {
        var connectionString = configurationManager.GetConnectionString("CarModuleConnectionString");
        
        ArgumentNullException.ThrowIfNull(connectionString);
        
        services.AddDbContext<CarModuleContext>(x =>
            {
                x.UseSqlServer(connectionString, q =>
                    {
                        q.MaxBatchSize(50);
                        q.EnableRetryOnFailure();
                        q.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                    })
                    .EnableSensitiveDataLogging();
                // .UseLoggerFactory(loggerFactory);
            },
            ServiceLifetime.Scoped,
            ServiceLifetime.Singleton);
        
        services
            .AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>))
            .AddScoped<IUnitOfWork, UnitOfWork>();
        
        return services;
    }
}