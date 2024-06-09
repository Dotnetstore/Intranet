using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Utilities.Entities;

namespace Utilities.EntityTypeConfigurations;

public abstract class IdentityEntityTypeConfiguration<T> : PersonEntityTypeConfiguration<T> where T : Identity
{
    public override void Configure(EntityTypeBuilder<T> builder)
    {
        base.Configure(builder);
    }
}