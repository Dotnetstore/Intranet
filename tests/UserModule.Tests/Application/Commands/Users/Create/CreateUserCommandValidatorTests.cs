using FluentAssertions;
using UserModule.Application.Commands.Users.Create;
using Xunit;

namespace UserModule.Tests.Application.Commands.Users.Create;

public class CreateUserCommandValidatorTests
{
    private readonly CreateUserCommandValidator _validator = new();

    [Fact]
    public void Should_Have_Error_When_LastName_Is_Empty()
    {
        // Arrange
        var command = new CreateUserCommand("", "John", "john.doe@test.com");

        // Act & Assert
        _validator.Validate(command).IsValid.Should().BeFalse();
    }

    [Fact]
    public void Should_Have_Error_When_FirstName_Is_Empty()
    {
        // Arrange
        var command = new CreateUserCommand("Doe", "", "john.doe@test.com");

        // Act & Assert
        _validator.Validate(command).IsValid.Should().BeFalse();
    }

    [Fact]
    public void Should_Have_Error_When_EmailAddress_Is_Empty()
    {
        // Arrange
        var command = new CreateUserCommand("Doe", "John", "");

        // Act & Assert
        _validator.Validate(command).IsValid.Should().BeFalse();
    }

    [Fact]
    public void Should_Not_Have_Error_When_All_Fields_Are_Valid()
    {
        // Arrange
        var command = new CreateUserCommand("Doe", "John", "john.doe@test.com");

        // Act & Assert
        _validator.Validate(command).IsValid.Should().BeTrue();
    }
}