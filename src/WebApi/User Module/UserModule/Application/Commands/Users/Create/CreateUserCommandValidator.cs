using FluentValidation;
using Utilities.Constants;

namespace UserModule.Application.Commands.Users.Create;

public sealed class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.LastName)
            .NotEmpty()
            .MinimumLength(1)
            .MaximumLength(DataSchemaConstants.DefaultNameLength);

        RuleFor(x => x.FirstName)
            .NotEmpty()
            .MinimumLength(1)
            .MaximumLength(DataSchemaConstants.DefaultNameLength);

        RuleFor(x => x.EmailAddress)
            .NotEmpty()
            .EmailAddress()
            .MinimumLength(6)
            .MaximumLength(DataSchemaConstants.EmailAddressLength);
    }
}