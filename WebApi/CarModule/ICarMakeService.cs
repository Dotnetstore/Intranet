namespace CarModule;

internal interface ICarMakeService
{
    IEnumerable<CarMakeResponse> GetCarMakes();
}