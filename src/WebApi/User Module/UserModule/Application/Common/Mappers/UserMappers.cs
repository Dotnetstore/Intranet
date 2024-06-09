using UserModule.Application.Commands.Users.Create;
using UserModuleContracts;

namespace UserModule.Application.Common.Mappers;

internal static class UserMappers
{
    internal static CreateUserResponse MapToCreateUserResponse(this CreateUserCommand q, Guid id)
    {
        return new CreateUserResponse(
            id, 
            q.LastName, 
            q.FirstName, 
            q.EmailAddress);
    }
}