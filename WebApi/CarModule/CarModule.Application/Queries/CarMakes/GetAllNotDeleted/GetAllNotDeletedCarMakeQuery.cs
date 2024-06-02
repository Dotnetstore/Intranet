namespace CarModule.Application.Queries.CarMakes.GetAllNotDeleted;

public record struct GetAllNotDeletedCarMakeQuery : IRequest<IEnumerable<CarMakeResponse>>;