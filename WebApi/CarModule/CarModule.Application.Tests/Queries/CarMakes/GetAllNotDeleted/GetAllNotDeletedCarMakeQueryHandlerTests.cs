using CarModule.Application.Queries.CarMakes.GetAllNotDeleted;

namespace CarModule.Application.Tests.Queries.CarMakes.GetAllNotDeleted;

public class GetAllNotDeletedCarMakeQueryHandlerTests
{
    private readonly IRequestHandler<GetAllNotDeletedCarMakeQuery, IEnumerable<CarMakeResponse>> _handler;
    private readonly DbContextOptions<CarModuleContext> _options;

    public GetAllNotDeletedCarMakeQueryHandlerTests()
    {
        var sender = Substitute.For<ISender>();
        _options = new DbContextOptionsBuilder<CarModuleContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
        var context = new CarModuleContext(_options);
        IUnitOfWork unitOfWork = new UnitOfWork(context, sender);
        _handler = new GetAllNotDeletedCarMakeQueryHandler(unitOfWork);
    }

    [Fact]
    public async Task Handle_ReturnsAllCarMakes()
    {
        var carMake1 = CarMakeBuilder
            .Create()
            .WithId(Guid.NewGuid())
            .WithName("Test Name 1")
            .WithIsDeleted(true)
            .Build();
        var carMake2 = CarMakeBuilder
            .Create()
            .WithId(Guid.NewGuid())
            .WithName("Test Name 2")
            .Build();

        var carMakeList = new List<CarMake>()
        {
            carMake1,
            carMake2
        };

        await using (var context = new CarModuleContext(_options))
        {
            context.CarMakes.RemoveRange(context.CarMakes);
            await context.SaveChangesAsync();
            
            await context.Set<CarMake>().AddRangeAsync(carMakeList);
            await context.SaveChangesAsync();
        }

        // Act
        var result = await _handler.Handle(new GetAllNotDeletedCarMakeQuery(), CancellationToken.None);

        // Assert
        result.Should().HaveCount(1);
    }
}