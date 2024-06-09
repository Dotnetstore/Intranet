using MediatR;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestHelper.FakeData;
using UserModule.Application.Common.Interfaces;
using UserModule.Infrastructure.Contexts;
using UserModule.Infrastructure.Persistence;
using WebApi;

namespace TestHelper.TestBases;

public abstract class TestBaseUserModuleContext : IDisposable
{
    private bool _disposed;
    private DbContextOptions<UserModuleContext> _options = null!;
    protected UserModuleContext Context = null!;
    private string _connectionString = null!;
    protected readonly IUnitOfWork UnitOfWork;
    protected CancellationToken CancellationToken = new CancellationTokenSource().Token;

    public TestBaseUserModuleContext()
    {
        using var application = new WebApplicationFactory<Program>();
        var sender = application.Services.GetRequiredService<ISender>();
        
        InitializeDatabase();
        
        UnitOfWork = new UnitOfWork(Context, sender);
    }
    
    private void InitializeDatabase()
    {
        _connectionString = GetUniqueConnectionString();

        _options = new DbContextOptionsBuilder<UserModuleContext>()
            .UseSqlServer(_connectionString)
            .Options;

        Context = new UserModuleContext(_options);
        Context.Database.EnsureCreated();
        SeedData();
    }
    
    private static string GetUniqueConnectionString()
    {
        var builder = new SqlConnectionStringBuilder
        {
            DataSource = "localhost",
            InitialCatalog = $"TestDatabase_{Guid.NewGuid()}",
            IntegratedSecurity = true,
            TrustServerCertificate = true,
            MultipleActiveResultSets = true
        };

        return builder.ConnectionString;
    }
    
    private void SeedData()
    {
        UserFakeDataBuilder.Generate(Context);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }

        if (disposing)
        {
            Context.Database.EnsureDeleted();
            Context.Dispose();
        }

        _disposed = true;
    }
}