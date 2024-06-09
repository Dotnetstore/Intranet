using FluentAssertions;
using UserModule.Domain.StronglyTypedIds;
using Xunit;

namespace UserModule.Tests.Domain.StronglyTypedIds;

public class UserIdTests
{
    [Fact]
    public void UserId_ShouldInitializeCorrectly()
    {
        // Arrange
        var guid = Guid.NewGuid();

        // Act
        var userId = new UserId(guid);

        // Assert
        userId.Value.Should().Be(guid);
    }
}