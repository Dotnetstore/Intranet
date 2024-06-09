using FluentAssertions;
using FluentAssertions.Execution;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UserModule.Domain.Entities;
using UserModule.Infrastructure.Contexts;
using Xunit;

namespace UserModule.Tests.Domain.EntityTypeConfigurations;

public class UserEntityTypeConfigurationTests
{
    private DbContextOptions<UserModuleContext> _optionsBuilder = new DbContextOptionsBuilder<UserModuleContext>()
        .UseInMemoryDatabase(databaseName: "TestDatabase")
        .Options;

    [Fact]
    public void Should_Set_Id_As_Key()
    {
        using var context = new UserModuleContext(_optionsBuilder);
        var entityType = context.Model.FindEntityType(typeof(User));
        var primaryKey = entityType!.FindPrimaryKey();
            
        primaryKey!
            .Properties.Should().ContainSingle()
            .Which.Name.Should().Be(nameof(User.Id));
    }
    
    [Fact]
    public void Should_Set_Id_As_ValueGeneratedNever()
    {
        using var context = new UserModuleContext(_optionsBuilder);
        var entityType = context.Model.FindEntityType(typeof(User));
        var idProperty = entityType!.FindProperty(nameof(User.Id));
        
        idProperty!.ValueGenerated.Should().Be(ValueGenerated.Never);
    }
    
    [Fact]
    public void Should_Configure_Id_Conversion()
    {
        using var context = new UserModuleContext(_optionsBuilder);
        var entityType = context.Model.FindEntityType(typeof(User));
        var idProperty = entityType!.FindProperty(nameof(User.Id));

        using (new AssertionScope())
        {
            idProperty!.GetValueConverter().Should().NotBeNull();
            idProperty.GetValueConverter()!.ConvertToProviderExpression.Should().NotBeNull();
            idProperty.GetValueConverter()!.ConvertFromProviderExpression.Should().NotBeNull();
        }
    }
}
