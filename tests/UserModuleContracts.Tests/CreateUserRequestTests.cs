using FluentAssertions;
using Xunit;

namespace UserModuleContracts.Tests;

public class CreateUserRequestTests
{
    [Fact]
    public void LastName_ShouldReturnCorrectValue()
    {
        // Arrange
        var request = new CreateUserRequest("Doe", "John", "test@test.com");

        // Assert
        request.LastName.Should().Be("Doe");
    }

    [Fact]
    public void FirstName_ShouldReturnCorrectValue()
    {
        // Arrange
        var request = new CreateUserRequest("Doe", "John", "test@test.com");

        // Assert
        request.FirstName.Should().Be("John");
    }

    [Fact]
    public void EmailAddress_ShouldReturnCorrectValue()
    {
        // Arrange
        var request = new CreateUserRequest("Doe", "John", "test@test.com");

        // Assert
        request.EmailAddress.Should().Be("test@test.com");
    }
}