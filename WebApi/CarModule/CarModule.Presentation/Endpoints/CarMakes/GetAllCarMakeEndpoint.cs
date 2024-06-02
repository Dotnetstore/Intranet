using CarModule.Application.Queries.CarMakes.GetAll;
using CarModule.Contracts;
using FastEndpoints;
using MediatR;

namespace CarModule.Presentation.Endpoints.CarMakes;

public class GetAllCarMakeEndpoint(ISender sender) : EndpointWithoutRequest<IEnumerable<CarMakeResponse>>
{
    public override void Configure()
    {
        Get("/api/carMakes");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken cancellationToken)
    {
        var query = new GetAllCarMakeQuery();
        
        var result = await sender.Send(query, cancellationToken);
        
        await SendAsync(result, cancellation: cancellationToken);
    }
}