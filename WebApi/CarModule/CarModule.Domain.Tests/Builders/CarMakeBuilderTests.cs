namespace CarModule.Domain.Tests.Builders;

public class CarMakeBuilderTests
{
    private const string Name = "Test Name";
    
    [Fact]
    public void WithId_SetsId()
    {
        var builder = CarMakeBuilder.Create();
        var id = Guid.NewGuid();

        builder
            .WithId(id)
            .WithName(Name);

        var carMake = builder.Build();

        carMake.Id.Value.Should().Be(id);
    }

    [Fact]
    public void WithName_SetsName()
    {
        var builder = CarMakeBuilder.Create();
        const string name = "Test Name";

        builder.WithName(name);

        var carMake = builder.Build();

        carMake.Name.Should().Be(name);
    }
    
    [Fact]
    public void WithCreatedBy_SetsCreatedBy()
    {
        var builder = CarMakeBuilder.Create();
        var createdBy = Guid.NewGuid();

        builder
            .WithCreatedBy(createdBy)
            .WithName(Name);

        var carMake = builder.Build();

        carMake.CreatedBy.Should().Be(createdBy);
    }
    
    [Fact]
    public void WithCreatedBy_SetsCreatedByToNull()
    {
        var builder = CarMakeBuilder.Create();

        builder
            .WithCreatedBy()
            .WithName(Name);

        var carMake = builder.Build();

        carMake.CreatedBy.Should().BeNull();
    }

    [Fact]
    public void WithCreatedDate_SetsCreatedDate()
    {
        var builder = CarMakeBuilder.Create();
        var date = DateTimeOffset.Now;

        builder
            .WithName(Name)
            .WithCreatedDate(date);

        var carMake = builder.Build();

        carMake.CreatedDate.Should().Be(date);
    }
    
    [Fact]
    public void WithLastUpdatedBy_SetsLastUpdatedBy()
    {
        var builder = CarMakeBuilder.Create();
        var lastUpdatedBy = Guid.NewGuid();

        builder
            .WithName(Name)
            .WithLastUpdatedBy(lastUpdatedBy);

        var carMake = builder.Build();

        carMake.LastUpdatedBy.Should().Be(lastUpdatedBy);
    }
    
    [Fact]
    public void WithLastUpdatedBy_SetsLastUpdatedByToNull()
    {
        var builder = CarMakeBuilder.Create();

        builder
            .WithName(Name)
            .WithLastUpdatedBy();

        var carMake = builder.Build();

        carMake.LastUpdatedBy.Should().BeNull();
    }

    [Fact]
    public void WithLastUpdatedDate_SetsLastUpdatedDate()
    {
        var builder = CarMakeBuilder.Create();
        var date = DateTimeOffset.Now;

        builder
            .WithName(Name)
            .WithLastUpdatedDate(date);

        var carMake = builder.Build();

        carMake.LastUpdatedDate.Should().Be(date);
    }

    [Fact]
    public void WithLastUpdatedDate_SetsLastUpdatedDateToNull()
    {
        var builder = CarMakeBuilder.Create();

        builder
            .WithName(Name)
            .WithLastUpdatedDate();

        var carMake = builder.Build();

        carMake.LastUpdatedDate.Should().BeNull();
    }

    [Fact]
    public void WithDeletedDate_SetsDeletedDate()
    {
        var builder = CarMakeBuilder.Create();
        var date = DateTimeOffset.Now;

        builder
            .WithName(Name)
            .WithDeletedDate(date);

        var carMake = builder.Build();

        carMake.DeletedDate.Should().Be(date);
    }

    [Fact]
    public void WithDeletedDate_SetsDeletedDateToNull()
    {
        var builder = CarMakeBuilder.Create();

        builder
            .WithName(Name)
            .WithDeletedDate();

        var carMake = builder.Build();

        carMake.DeletedDate.Should().BeNull();
    }
    
    [Fact]
    public void WithDeletedBy_SetsDeletedBy()
    {
        var builder = CarMakeBuilder.Create();
        var deletedBy = Guid.NewGuid();

        builder
            .WithName(Name)
            .WithDeletedBy(deletedBy);

        var carMake = builder.Build();

        carMake.DeletedBy.Should().Be(deletedBy);
    }
    
    [Fact]
    public void WithDeletedBy_SetsDeletedByToNull()
    {
        var builder = CarMakeBuilder.Create();

        builder
            .WithName(Name)
            .WithDeletedBy();

        var carMake = builder.Build();

        carMake.DeletedBy.Should().BeNull();
    }
    
    [Fact]
    public void WithIsDeleted_SetsIsDeleted()
    {
        var builder = CarMakeBuilder.Create();
        const bool isDeleted = true;

        builder
            .WithName(Name)
            .WithIsDeleted(isDeleted);

        var carMake = builder.Build();

        carMake.IsDeleted.Should().Be(isDeleted);
    }
    
    [Fact]
    public void WithIsDeleted_SetsIsDeletedToFalse()
    {
        var builder = CarMakeBuilder.Create();

        builder
            .WithName(Name)
            .WithIsDeleted();

        var carMake = builder.Build();

        carMake.IsDeleted.Should().BeFalse();
    }
    
    [Fact]
    public void WithIsSystem_SetsIsSystem()
    {
        var builder = CarMakeBuilder.Create();
        const bool isSystem = true;

        builder
            .WithName(Name)
            .WithIsSystem(isSystem);

        var carMake = builder.Build();

        carMake.IsSystem.Should().Be(isSystem);
    }
    
    [Fact]
    public void WithIsSystem_SetsIsSystemToFalse()
    {
        var builder = CarMakeBuilder.Create();

        builder
            .WithName(Name)
            .WithIsSystem();

        var carMake = builder.Build();

        carMake.IsSystem.Should().BeFalse();
    }
    
    [Fact]
    public void WithIsGdpr_SetsIsGdpr()
    {
        var builder = CarMakeBuilder.Create();
        const bool isGdpr = true;

        builder
            .WithName(Name)
            .WithIsGdpr(isGdpr);

        var carMake = builder.Build();

        carMake.IsGdpr.Should().Be(isGdpr);
    }
    
    [Fact]
    public void WithIsGdpr_SetsIsGdprToFalse()
    {
        var builder = CarMakeBuilder.Create();

        builder
            .WithName(Name)
            .WithIsGdpr();

        var carMake = builder.Build();

        carMake.IsGdpr.Should().BeFalse();
    }
}