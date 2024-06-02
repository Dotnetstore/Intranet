using Ardalis.GuardClauses;
using CarModule.Domain.Common;
using CarModule.Domain.StronglyIds;
using Microsoft.EntityFrameworkCore;

namespace CarModule.Domain.Entities;

[Index(nameof(Id), IsUnique = true)]
[Index(nameof(IsDeleted), IsUnique = false)]
public class CarMake : BaseAuditableEntity
{
    public CarMakeId Id { get; private set; }

    public string Name { get; set; }

    public CarMake(
        CarMakeId id, 
        string name, 
        DateTimeOffset createdDate, 
        Guid? createdBy = null, 
        Guid? lastUpdatedBy = null, 
        DateTimeOffset? lastUpdatedDate = null, 
        bool isDeleted = false, 
        Guid? deletedBy = null, 
        DateTimeOffset? deletedDate = null, 
        bool isSystem = false, 
        bool isGdpr = false)
    {
        Id = Guard.Against.Null(id, nameof(id));
        Name = Guard.Against.NullOrWhiteSpace(name, nameof(name));
        CreatedBy = createdBy;
        CreatedDate = createdDate;
        LastUpdatedBy = lastUpdatedBy;
        LastUpdatedDate = lastUpdatedDate;
        IsDeleted = isDeleted;
        DeletedBy = deletedBy;
        DeletedDate = deletedDate;
        IsSystem = isSystem;
        IsGdpr = isGdpr;
    }
}