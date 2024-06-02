namespace CarModule.Application.Queries.CarMakes.GetAllNotDeleted;

internal sealed class GetAllNotDeletedCarMakeQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetAllNotDeletedCarMakeQuery, IEnumerable<CarMakeResponse>>
{
    async Task<IEnumerable<CarMakeResponse>> IRequestHandler<GetAllNotDeletedCarMakeQuery, IEnumerable<CarMakeResponse>>
        .Handle(GetAllNotDeletedCarMakeQuery request, CancellationToken cancellationToken)
    {
        return await unitOfWork
            .Repository<CarMake>()
            .Entities
            .Where(x => !x.IsDeleted)
            .OrderBy(x => x.Name)
            .Select(x => x.ToCarMakeResponse())
            .ToListAsync(cancellationToken);
    }
}