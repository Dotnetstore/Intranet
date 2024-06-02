namespace CarModule.Application.Tests.Queries.CarMakes.GetAllNotDeleted;

public class GetAllNotDeletedCarMakeQueryTests
{
    [Fact]
    public void Should_contain_correct_properties()
    {
        var query = new GetAllNotDeletedCarMakeQueryTests();

        query.Should().NotBeNull();
    }
}