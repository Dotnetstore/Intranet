using CarModule.Application.Queries.CarMakes.GetAll;

namespace CarModule.Application.Tests.Queries.CarMakes.GetAll;

public class GetAllCarMakeQueryTests
{
    [Fact]
    public void Should_contain_correct_properties()
    {
        var query = new GetAllCarMakeQuery();
        
        query.Should().NotBeNull();
    }
}