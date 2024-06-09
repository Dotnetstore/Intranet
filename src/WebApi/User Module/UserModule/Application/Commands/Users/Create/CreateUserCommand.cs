using ErrorOr;
using MediatR;
using UserModuleContracts;

namespace UserModule.Application.Commands.Users.Create;

public record struct CreateUserCommand(
    string LastName,
    string FirstName,
    string EmailAddress) : IRequest<ErrorOr<CreateUserResponse>>;