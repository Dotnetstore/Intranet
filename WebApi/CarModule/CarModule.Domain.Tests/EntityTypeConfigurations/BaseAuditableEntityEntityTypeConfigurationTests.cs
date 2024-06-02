namespace CarModule.Domain.Tests.EntityTypeConfigurations;

public class BaseAuditableEntityEntityTypeConfigurationTests
{
    private class TestEntity : BaseAuditableEntity { }

    private class TestEntityConfiguration : BaseAuditableEntityEntityTypeConfiguration<TestEntity> { }

    [Fact]
    public void Configure_SetsPropertiesAsRequired()
    {
        var options = new DbContextOptionsBuilder<DbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        using var context = new DbContext(options);
        var modelBuilder = new ModelBuilder(new Microsoft.EntityFrameworkCore.Metadata.Conventions.ConventionSet());

        var entityConfiguration = new TestEntityConfiguration();
        entityConfiguration.Configure(modelBuilder.Entity<TestEntity>());

        var entityType = modelBuilder.Model.FindEntityType(typeof(TestEntity));

        entityType!.FindProperty(nameof(BaseAuditableEntity.CreatedDate))!.IsNullable.Should().BeFalse();
        entityType.FindProperty(nameof(BaseAuditableEntity.IsSystem))!.IsNullable.Should().BeFalse();
        entityType.FindProperty(nameof(BaseAuditableEntity.IsGdpr))!.IsNullable.Should().BeFalse();
        entityType.FindProperty(nameof(BaseAuditableEntity.IsDeleted))!.IsNullable.Should().BeFalse();
    }
}