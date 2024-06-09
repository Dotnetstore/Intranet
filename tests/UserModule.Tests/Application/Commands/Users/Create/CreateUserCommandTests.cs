using FluentAssertions;
using UserModule.Application.Commands.Users.Create;
using Xunit;

namespace UserModule.Tests.Application.Commands.Users.Create;

public class CreateUserCommandTests
{
    [Fact]
    public void CreateUserCommand_ShouldInitializeCorrectly()
    {
        // Arrange
        const string lastName = "Doe";
        const string firstName = "John";
        const string emailAddress = "john.doe@test.com";

        // Act
        var command = new CreateUserCommand(lastName, firstName, emailAddress);

        // Assert
        command.LastName.Should().Be(lastName);
        command.FirstName.Should().Be(firstName);
        command.EmailAddress.Should().Be(emailAddress);
    }
}