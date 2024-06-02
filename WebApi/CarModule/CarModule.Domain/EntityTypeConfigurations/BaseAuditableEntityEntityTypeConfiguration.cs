using CarModule.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarModule.Domain.EntityTypeConfigurations;

public abstract class BaseAuditableEntityEntityTypeConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseAuditableEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder
            .Property(x => x.CreatedDate)
            .IsRequired();
        
        builder
            .Property(x => x.IsSystem)
            .IsRequired();
        
        builder
            .Property(x => x.IsGdpr)
            .IsRequired();
        
        builder
            .Property(x => x.IsDeleted)
            .IsRequired();
    }
}