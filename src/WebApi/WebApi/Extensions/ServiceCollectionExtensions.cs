using FastEndpoints;
using FastEndpoints.Swagger;

namespace WebApi.Extensions;

internal static class ServiceCollectionExtensions
{
    internal static void AddWebApi(this IServiceCollection serviceCollection)
    {
        serviceCollection
            .AddFastEndpoints()
            .SwaggerDocument(x =>
            {
                x.DocumentSettings = s =>
                {
                    s.Title = "Dotnetstore Intranet WebApi";
                    s.Version = "v1";
                };
            });
    }
}