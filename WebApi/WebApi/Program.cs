using WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAppServices(builder.Configuration);

var app = builder.Build();

app.AddMiddleware();
app.UpdateDatabase();

app.Run();

public partial class Program { }