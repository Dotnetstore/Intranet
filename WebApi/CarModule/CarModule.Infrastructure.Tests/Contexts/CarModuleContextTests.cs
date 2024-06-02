using CarModule.Domain.Builders;
using CarModule.Infrastructure.Contexts;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace CarModule.Infrastructure.Tests.Contexts;

public class CarModuleContextTests
{
    private readonly DbContextOptions<CarModuleContext> _options = new DbContextOptionsBuilder<CarModuleContext>()
        .UseInMemoryDatabase(databaseName: "TestDatabase")
        .Options;

    [Fact]
    public async Task CarMakes_AddsAndRetrievesCorrectly()
    {
        var carMake = CarMakeBuilder
            .Create()
            .WithId(Guid.NewGuid())
            .WithName("Test Name")
            .WithCreatedDate(DateTimeOffset.Now)
            .Build();

        await using (var context = new CarModuleContext(_options))
        {
            context.CarMakes.RemoveRange(context.CarMakes);
            await context.SaveChangesAsync();
            
            await context.CarMakes.AddAsync(carMake);
            await context.SaveChangesAsync();
        }

        await using (var context = new CarModuleContext(_options))
        {
            var retrievedCarMake = await context.CarMakes.FindAsync(carMake.Id);
            retrievedCarMake.Should().BeEquivalentTo(carMake);
        }
    }
}