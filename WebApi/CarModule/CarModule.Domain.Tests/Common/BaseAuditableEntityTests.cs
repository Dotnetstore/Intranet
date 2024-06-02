namespace CarModule.Domain.Tests.Common;

public class BaseAuditableEntityTests
{
    [Fact]
    public void Properties_SetAndGetValues()
    {
        var date = DateTimeOffset.Now;
        var guid = Guid.NewGuid();
        
        var entity = new TestClassForBaseAuditableEntityTests
        {
            CreatedBy = guid,
            CreatedDate = date,
            LastUpdatedBy = guid,
            LastUpdatedDate = date,
            IsDeleted = true,
            DeletedBy = guid,
            DeletedDate = date,
            IsSystem = true,
            IsGdpr = true
        };

        using (new AssertionScope())
        {
            entity.CreatedBy.Should().Be(guid);
            entity.CreatedDate.Should().Be(date);
            entity.LastUpdatedBy.Should().Be(guid);
            entity.LastUpdatedDate.Should().Be(date);
            entity.IsDeleted.Should().BeTrue();
            entity.DeletedBy.Should().Be(guid);
            entity.DeletedDate.Should().Be(date);
            entity.IsSystem.Should().BeTrue();
            entity.IsGdpr.Should().BeTrue();
        }
    }
}

internal class TestClassForBaseAuditableEntityTests : BaseAuditableEntity
{
}