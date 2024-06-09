using FastEndpoints;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserModule.Application.Common.Interfaces;
using UserModule.Infrastructure.Contexts;
using UserModule.Infrastructure.Persistence;

namespace UserModule.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddUserModule(
        this IServiceCollection serviceCollection,
        IConfigurationManager configurationManager)
    {
        var connectionString = configurationManager.GetConnectionString("CarModuleConnectionString");
        
        ArgumentNullException.ThrowIfNull(connectionString);
        
        serviceCollection.AddDbContext<UserModuleContext>(x =>
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
        
        serviceCollection
            .AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>))
            .AddScoped<IUnitOfWork, UnitOfWork>()
            .AddFastEndpoints()
            .AddMediatR(x =>
            {
                x.RegisterServicesFromAssembly(typeof(IUserModuleAssemblyMarker).Assembly);
            });

        return serviceCollection;
    }
}