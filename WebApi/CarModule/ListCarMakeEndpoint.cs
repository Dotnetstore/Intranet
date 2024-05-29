using FastEndpoints;

namespace CarModule;

internal class ListCarMakeEndpoint(ICarMakeService carMakeService) : EndpointWithoutRequest<ListCarMakeResponse>
{
    public override void Configure()
    {
        Get("/api/carMakes");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken cancellationToken)
    {
        var carMakes = carMakeService.GetCarMakes();
        
        await SendAsync(new ListCarMakeResponse(carMakes.ToList()), cancellation: cancellationToken);
    }
}