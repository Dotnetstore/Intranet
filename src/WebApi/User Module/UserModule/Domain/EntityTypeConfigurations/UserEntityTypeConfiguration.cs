using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserModule.Domain.Entities;
using UserModule.Domain.StronglyTypedIds;
using Utilities.EntityTypeConfigurations;

namespace UserModule.Domain.EntityTypeConfigurations;

public sealed class UserEntityTypeConfiguration : IdentityEntityTypeConfiguration<User>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);
        
        builder
            .HasKey(x => x.Id);
        
        builder
            .Property(x => x.Id)
            .ValueGeneratedNever()
            .HasConversion(
                x => x.Value,
                x => new UserId(x));
    }
}