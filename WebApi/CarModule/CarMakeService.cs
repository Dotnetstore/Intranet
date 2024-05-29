namespace CarModule;

internal class CarMakeService : ICarMakeService
{
    public IEnumerable<CarMakeResponse> GetCarMakes()
    {
        return new[]
        {
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Toyota"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Ford"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Chevrolet"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Honda"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Nissan"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Jeep"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Hyundai"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Dodge"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Kia"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "BMW"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Mercedes-Benz"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Ram"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "GMC"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Subaru"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Volkswagen"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Audi"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Lexus"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Mazda"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Buick"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Cadillac"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Volvo"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Lincoln"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Land Rover"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Porsche"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Jaguar"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Acura"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Infiniti"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Mini"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Mitsubishi"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Bentley"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Fiat"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Smart"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Scion"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Tesla"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Genesis"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Maserati"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Ferrari"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Lamborghini"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "McLaren"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Rolls-Royce"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Bugatti"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Koenigsegg"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Pagani"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Lotus"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Alfa Romeo"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Aston Martin"),
            new CarMakeResponse(new CarMakeId(Guid.NewGuid()), "Bentley")
        };
    }
}