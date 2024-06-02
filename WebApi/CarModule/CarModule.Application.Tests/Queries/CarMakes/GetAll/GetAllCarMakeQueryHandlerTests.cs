using CarModule.Application.Queries.CarMakes.GetAll;

namespace CarModule.Application.Tests.Queries.CarMakes.GetAll;

public class GetAllCarMakeQueryHandlerTests
{
    private readonly IRequestHandler<GetAllCarMakeQuery, IEnumerable<CarMakeResponse>> _handler;
    private readonly DbContextOptions<CarModuleContext> _options;

    public GetAllCarMakeQueryHandlerTests()
    {
        var sender = Substitute.For<ISender>();
        _options = new DbContextOptionsBuilder<CarModuleContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
        var context = new CarModuleContext(_options);
        IUnitOfWork unitOfWork = new UnitOfWork(context, sender);
        _handler = new GetAllCarMakeQueryHandler(unitOfWork);
    }

    [Fact]
    public async Task Handle_ReturnsAllCarMakes()
    {
        var carMake1 = CarMakeBuilder
            .Create()
            .WithId(Guid.NewGuid())
            .WithName("Test Name 1")
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
        var result = await _handler.Handle(new GetAllCarMakeQuery(), CancellationToken.None);

        // Assert
        result.Should().HaveCount(2);
    }
}