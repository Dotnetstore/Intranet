namespace CarModule.Application.Common.Mappers;

internal static class CarMakeMappers
{
    internal static CarMakeResponse ToCarMakeResponse(this CarMake carMake)
    {
        return new CarMakeResponse
        {
            Id = carMake.Id.Value,
            Name = carMake.Name
        };
    }
}