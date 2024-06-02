namespace CarModule.Application.Queries.CarMakes.GetAll;

public record struct GetAllCarMakeQuery : IRequest<IEnumerable<CarMakeResponse>>;