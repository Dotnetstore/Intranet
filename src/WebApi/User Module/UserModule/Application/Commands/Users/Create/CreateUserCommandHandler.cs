using ErrorOr;
using MediatR;
using UserModule.Application.Common.Interfaces;
using UserModule.Application.Common.Mappers;
using UserModule.Domain.Builders;
using UserModule.Domain.Entities;
using UserModuleContracts;

namespace UserModule.Application.Commands.Users.Create;

internal sealed class CreateUserCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<CreateUserCommand, ErrorOr<CreateUserResponse>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    
    public async Task<ErrorOr<CreateUserResponse>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var userId = Guid.NewGuid();
        
        CreateUser(request, userId);
        
        await _unitOfWork.SaveAsync(cancellationToken);
        
        return request.MapToCreateUserResponse(userId);
    }
    
    private void CreateUser(CreateUserCommand request, Guid userId)
    {
        var user = UserBuilder.Create()
            .WithId(userId)
            .WithLastName(request.LastName)
            .WithFirstName(request.FirstName)
            .WithEmailAddress(request.EmailAddress)
            .Build();
        
        _unitOfWork.Repository<User>().Create(user);
    }
}