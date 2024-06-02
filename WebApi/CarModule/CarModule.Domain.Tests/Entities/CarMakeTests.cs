namespace CarModule.Domain.Tests.Entities;

public class CarMakeTests
{
    [Fact]
    public void Constructor_SetsValues()
    {
        var id = new CarMakeId(Guid.NewGuid());
        const string name = "Test Name";
        var createdDate = DateTimeOffset.Now;
        var createdBy = Guid.NewGuid();
        var lastUpdatedBy = Guid.NewGuid();
        var lastUpdatedDate = DateTimeOffset.Now;
        const bool isDeleted = true;
        var deletedBy = Guid.NewGuid();
        var deletedDate = DateTimeOffset.Now;
        const bool isSystem = true;
        const bool isGdpr = true;

        var carMake = new CarMake(
            id,
            name,
            createdDate,
            createdBy,
            lastUpdatedBy,
            lastUpdatedDate,
            isDeleted,
            deletedBy,
            deletedDate,
            isSystem,
            isGdpr);

        using (new AssertionScope())
        {
            carMake.Id.Should().Be(id);
            carMake.Name.Should().Be(name);
            carMake.CreatedBy.Should().Be(createdBy);
            carMake.CreatedDate.Should().Be(createdDate);
            carMake.LastUpdatedBy.Should().Be(lastUpdatedBy);
            carMake.LastUpdatedDate.Should().Be(lastUpdatedDate);
            carMake.IsDeleted.Should().Be(isDeleted);
            carMake.DeletedBy.Should().Be(deletedBy);
            carMake.DeletedDate.Should().Be(deletedDate);
            carMake.IsSystem.Should().Be(isSystem);
            carMake.IsGdpr.Should().Be(isGdpr);
        }
    }
}