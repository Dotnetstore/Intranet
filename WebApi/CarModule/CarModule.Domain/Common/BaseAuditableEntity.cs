namespace CarModule.Domain.Common;

public abstract class BaseAuditableEntity : IBaseAuditableEntity
{
    public Guid? CreatedBy { get; init; }

    public DateTimeOffset CreatedDate { get; init; }

    public Guid? LastUpdatedBy { get; set; }

    public DateTimeOffset? LastUpdatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public Guid? DeletedBy { get; set; }

    public DateTimeOffset? DeletedDate { get; set; }

    public bool IsSystem { get; init; }

    public bool IsGdpr { get; init; }
}