using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Utilities.Constants;
using Utilities.Entities;

namespace Utilities.EntityTypeConfigurations;

public abstract class PersonEntityTypeConfiguration<T> : BaseAuditableEntityEntityTypeConfiguration<T> where T : Person
{
    public override void Configure(EntityTypeBuilder<T> builder)
    {
        base.Configure(builder);
        
        builder.Property(p => p.FirstName)
            .HasMaxLength(DataSchemaConstants.DefaultNameLength)
            .IsRequired()
            .IsUnicode(false);
        
        builder
            .Property(p => p.LastName)
            .HasMaxLength(DataSchemaConstants.DefaultNameLength)
            .IsRequired()
            .IsUnicode(false);
        
        builder
            .Property(p => p.EmailAddress)
            .HasMaxLength(DataSchemaConstants.EmailAddressLength)
            .IsRequired()
            .IsUnicode(false);
    }
}