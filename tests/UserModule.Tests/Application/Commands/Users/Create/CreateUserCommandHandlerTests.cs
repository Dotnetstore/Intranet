using MediatR;
using TestHelper.TestBases;
using UserModule.Application.Commands.Users.Create;
using UserModuleContracts;
using Xunit;
using ErrorOr;
using FluentAssertions;

namespace UserModule.Tests.Application.Commands.Users.Create;

public class CreateUserCommandHandlerTests : TestBaseUserModuleContext
{
    private readonly IRequestHandler<CreateUserCommand, ErrorOr<CreateUserResponse>> _handler;

    public CreateUserCommandHandlerTests()
    {
        _handler = new CreateUserCommandHandler(UnitOfWork);
    }

    [Fact]
    public async Task Handle_ShouldCreateUser_WhenCommandIsValid()
    {
        // Arrange
        var command = new CreateUserCommand("Doe", "John", "john.doe@test.com");

        // Act
        var result = await _handler.Handle(command, CancellationToken);

        // Assert
        Context.Users.Should().HaveCount(2);
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
    }
}