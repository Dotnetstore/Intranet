using Microsoft.EntityFrameworkCore;
using UserModule.Domain.Entities;

namespace UserModule.Infrastructure.Contexts;

public class UserModuleContext(DbContextOptions<UserModuleContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("User");
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IUserModuleAssemblyMarker).Assembly);
    }
}