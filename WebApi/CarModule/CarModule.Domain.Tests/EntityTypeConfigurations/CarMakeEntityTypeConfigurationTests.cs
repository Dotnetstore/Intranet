namespace CarModule.Domain.Tests.EntityTypeConfigurations;

public class CarMakeEntityTypeConfigurationTests
{
    private class TestDbContext(DbContextOptions<TestDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarMakeEntityTypeConfiguration());
        }
    }

    [Fact]
    public void Configure_SetsPropertiesAsRequired()
    {
        var options = new DbContextOptionsBuilder<TestDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        using var context = new TestDbContext(options);
        var modelBuilder = new ModelBuilder(new Microsoft.EntityFrameworkCore.Metadata.Conventions.ConventionSet());

        modelBuilder.ApplyConfiguration(new CarMakeEntityTypeConfiguration());

        var entityType = modelBuilder.Model.FindEntityType(typeof(CarMake));

        entityType!.FindProperty(nameof(CarMake.Id))!.IsNullable.Should().BeFalse();
        entityType.FindProperty(nameof(CarMake.Name))!.IsNullable.Should().BeFalse();
    }
}