namespace CarModule.Domain.Tests.StronglyIds;

public class CarMakeIdTests
{
    [Fact]
    public void Constructor_SetsValue()
    {
        var guid = Guid.NewGuid();
        var carMakeId = new CarMakeId(guid);

        carMakeId.Value.Should().Be(guid);
    }
}