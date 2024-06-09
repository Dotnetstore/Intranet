using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using UserModule.Domain.Entities;
using UserModule.Infrastructure.Contexts;
using Xunit;

namespace UserModule.Tests.Infrastructure.Contexts;

public class UserModuleContextTests
{
    [Fact]
    public void OnModelCreating_ShouldSetupUserEntityCorrectly()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<UserModuleContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        using var context = new UserModuleContext(options);

        // Act
        context.Database.EnsureCreated();

        // Assert
        context.Model.FindEntityType(typeof(User)).Should().NotBeNull();
    }
}