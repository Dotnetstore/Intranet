using FluentAssertions;
using FluentAssertions.Execution;
using UserModule.Application.Commands.Users.Create;
using UserModule.Application.Common.Mappers;
using Xunit;

namespace UserModule.Tests.Application.Common.Mappers;

public class UserMappersTests
{
    [Fact]
    public void MapToCreateUserResponse_ShouldReturnCorrectResponse()
    {
        // Arrange
        var id = Guid.NewGuid();
        var command = new CreateUserCommand
        {
            LastName = "Doe",
            FirstName = "John",
            EmailAddress = "test@test.com"
        };

        // Act
        var response = command.MapToCreateUserResponse(id);

        // Assert
        using (new AssertionScope())
        {
            response.Id.Should().Be(id);
            response.LastName.Should().Be(command.LastName);
            response.FirstName.Should().Be(command.FirstName);
            response.EmailAddress.Should().Be(command.EmailAddress);
        }
    }
}