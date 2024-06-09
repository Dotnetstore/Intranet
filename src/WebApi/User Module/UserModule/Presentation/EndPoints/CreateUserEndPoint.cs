using ErrorOr;
using FastEndpoints;
using MediatR;
using Microsoft.AspNetCore.Http;
using UserModule.Application.Commands.Users.Create;
using UserModuleContracts;

namespace UserModule.Presentation.EndPoints;

public class CreateUserEndPoint : Endpoint<CreateUserRequest, CreateUserResponse>
{
    public ISender Sender { get; set; } = null!;
    
    public override void Configure()
    {
        Post("/api/user/create");
        Options(x =>
        {
            x.WithTags("User");
        });
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateUserRequest req, CancellationToken ct)
    {
        var query = new CreateUserCommand(req.LastName, req.FirstName, req.EmailAddress);
        
        var result = await Sender.Send(query, ct);

        if (result.IsError)
        {
            if (result.FirstError == Error.Failure())
                await SendResultAsync(TypedResults.BadRequest(result.FirstError.Description));
            if (result.FirstError == Error.Conflict())
                await SendResultAsync(TypedResults.BadRequest(result.FirstError.Description));
            if (result.FirstError == Error.Validation())
                await SendResultAsync(TypedResults.BadRequest(result.FirstError.Description));
            
            await SendResultAsync(TypedResults.Problem(result.FirstError.Description));
        }
        
        await SendResultAsync(TypedResults.Ok(result));
    }
}