namespace CarModule.Application.Queries.CarMakes.GetAll;

internal sealed class GetAllCarMakeQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetAllCarMakeQuery, IEnumerable<CarMakeResponse>>
{
    async Task<IEnumerable<CarMakeResponse>> IRequestHandler<GetAllCarMakeQuery, IEnumerable<CarMakeResponse>>
        .Handle(GetAllCarMakeQuery request, CancellationToken cancellationToken)
    {
        return await unitOfWork
            .Repository<CarMake>()
            .Entities
            .OrderBy(x => x.Name)
            .Select(x => x.ToCarMakeResponse())
            .ToListAsync(cancellationToken);
    }
}