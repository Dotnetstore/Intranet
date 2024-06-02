using CarModule.Domain;

namespace CarModule.Infrastructure.Contexts;

public class CarModuleContext(DbContextOptions<CarModuleContext> options) : DbContext(options)
{
    public DbSet<CarMake> CarMakes => Set<CarMake>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("CarModule");
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IDomainAssemblyMarker).Assembly);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<decimal>().HavePrecision(18, 6);
    }
}