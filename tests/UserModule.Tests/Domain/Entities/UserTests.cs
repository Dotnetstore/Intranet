using FluentAssertions;
using UserModule.Domain.Entities;
using UserModule.Domain.StronglyTypedIds;
using Xunit;

namespace UserModule.Tests.Domain.Entities;

public class UserTests
{
    [Fact]
    public void User_ShouldInitializeCorrectly()
    {
        // Arrange
        var id = new UserId(Guid.NewGuid());

        // Act
        var user = new User { Id = id, LastName = "Doe", FirstName = "John", EmailAddress = "test@test.com" };

        // Assert
        user.Id.Should().Be(id);
    }
}