using CarModule.Infrastructure.Contexts;
using CarModule.Presentation.Extensions;
using FastEndpoints;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Extensions;

internal static class StartupExtensions
{
    internal static void AddAppServices(this IServiceCollection serviceCollection,
        IConfigurationManager configurationManager)
    {
        serviceCollection
            .AddFastEndpoints()
            .AddEndpointsApiExplorer()
            .AddSwaggerGen()
            .AddCarModuleServices(configurationManager);
    }
    
    internal static void AddMiddleware(this WebApplication webApplication)
    {
        if (webApplication.Environment.IsDevelopment())
        {
            webApplication
                .UseSwagger()
                .UseSwaggerUI();
        }

        webApplication.UseFastEndpoints();
    }
    
    internal static void UpdateDatabase(this WebApplication webApplication)
    {
        MigrateCarModule(webApplication);
    }

    private static void MigrateCarModule(WebApplication webApplication)
    {
        using var scope = webApplication.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<CarModuleContext>();
        var pendingMigrations = context.Database.GetPendingMigrations();
        if (pendingMigrations.Any())
            context.Database.Migrate();
    }
}