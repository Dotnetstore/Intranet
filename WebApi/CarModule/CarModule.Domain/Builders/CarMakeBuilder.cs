using CarModule.Domain.Entities;
using CarModule.Domain.StronglyIds;

namespace CarModule.Domain.Builders;

public class CarMakeBuilder
{
    private Guid Id { get; set; }
    private string Name { get; set; } = null!;
    private Guid? CreatedBy { get; set; } = null;
    private DateTimeOffset CreatedDate { get; set; }
    private Guid? LastUpdatedBy { get; set; } = null;
    private DateTimeOffset? LastUpdatedDate { get; set; } = null;
    private bool IsDeleted { get; set; } = false;
    private Guid? DeletedBy { get; set; } = null;
    private DateTimeOffset? DeletedDate { get; set; } = null;
    private bool IsSystem { get; set; } = false;
    private bool IsGdpr { get; set; } = false;
    
    private CarMakeBuilder()
    {
    }
    
    public static CarMakeBuilder Create()
    {
        return new CarMakeBuilder();
    }
    
    public CarMakeBuilder WithId(Guid id)
    {
        Id = id;
        return this;
    }
    public CarMakeBuilder WithName(string name)
    {
        Name = name;
        return this;
    }

    public CarMakeBuilder WithCreatedBy(Guid? createdBy = null)
    {
        CreatedBy = createdBy;
        return this;
    }

    public CarMakeBuilder WithCreatedDate(DateTimeOffset createdDate)
    {
        CreatedDate = createdDate;
        return this;
    }

    public CarMakeBuilder WithLastUpdatedBy(Guid? lastUpdatedBy = null)
    {
        LastUpdatedBy = lastUpdatedBy;
        return this;
    }

    public CarMakeBuilder WithLastUpdatedDate(DateTimeOffset? lastUpdatedDate = null)
    {
        LastUpdatedDate = lastUpdatedDate;
        return this;
    }

    public CarMakeBuilder WithIsDeleted(bool isDeleted = false)
    {
        IsDeleted = isDeleted;
        return this;
    }

    public CarMakeBuilder WithDeletedBy(Guid? deletedBy = null)
    {
        DeletedBy = deletedBy;
        return this;
    }

    public CarMakeBuilder WithDeletedDate(DateTimeOffset? deletedDate = null)
    {
        DeletedDate = deletedDate;
        return this;
    }

    public CarMakeBuilder WithIsSystem(bool isSystem = false)
    {
        IsSystem = isSystem;
        return this;
    }

    public CarMakeBuilder WithIsGdpr(bool isGdpr = false)
    {
        IsGdpr = isGdpr;
        return this;
    }

    public CarMake Build()
    {
        return new CarMake(new CarMakeId(Id), Name, CreatedDate, CreatedBy, LastUpdatedBy, LastUpdatedDate, IsDeleted, DeletedBy, DeletedDate, IsSystem, IsGdpr);
    }
}