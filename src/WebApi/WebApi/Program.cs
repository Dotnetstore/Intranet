using FastEndpoints;
using FastEndpoints.Swagger;
using UserModule.Extensions;
using WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddUserModule(builder.Configuration)
    .AddWebApi();

var app = builder.Build();

app
    .UseFastEndpoints()
    .UseSwaggerGen();

app.Run();

namespace WebApi
{
    public partial class Program {}
}