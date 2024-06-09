using FluentAssertions;
using Xunit;

namespace UserModuleContracts.Tests;

public class CreateUserResponseTests
{
    [Fact]
    public void Id_ShouldReturnCorrectValue()
    {
        // Arrange
        var id = Guid.NewGuid();
        var response = new CreateUserResponse(id, "Doe", "John", "test@test.com");

        // Assert
        response.Id.Should().Be(id);
    }

    [Fact]
    public void LastName_ShouldReturnCorrectValue()
    {
        // Arrange
        var response = new CreateUserResponse(Guid.NewGuid(), "Doe", "John", "test@test.com");

        // Assert
        response.LastName.Should().Be("Doe");
    }

    [Fact]
    public void FirstName_ShouldReturnCorrectValue()
    {
        // Arrange
        var response = new CreateUserResponse(Guid.NewGuid(), "Doe", "John", "test@test.com");

        // Assert
        response.FirstName.Should().Be("John");
    }

    [Fact]
    public void EmailAddress_ShouldReturnCorrectValue()
    {
        // Arrange
        var response = new CreateUserResponse(Guid.NewGuid(), "Doe", "John", "test@test.com");

        // Assert
        response.EmailAddress.Should().Be("test@test.com");
    }
}