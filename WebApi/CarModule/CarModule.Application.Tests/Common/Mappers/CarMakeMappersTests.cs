using CarModule.Application.Common.Mappers;
using FluentAssertions.Execution;

namespace CarModule.Application.Tests.Common.Mappers;

public class CarMakeMappersTests
{
    [Fact]
    public void ToCarMakeResponse_MapsCorrectly()
    {
        var id = Guid.NewGuid();

        var carMake = CarMakeBuilder
            .Create()
            .WithId(id)
            .WithName("Test Name")
            .WithCreatedDate(DateTimeOffset.Now)
            .Build();

        var response = carMake.ToCarMakeResponse();

        using (new AssertionScope())
        {
            response.Id.Should().Be(id);
            response.Name.Should().Be("Test Name");
        }
    }
}