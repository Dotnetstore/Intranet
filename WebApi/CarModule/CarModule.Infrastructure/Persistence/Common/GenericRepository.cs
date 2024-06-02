namespace CarModule.Infrastructure.Persistence.Common;

public sealed class GenericRepository<T>(CarModuleContext context) : IGenericRepository<T>
    where T : BaseAuditableEntity
{
    public IQueryable<T> Entities => context.Set<T>();

    async Task<List<T>> IGenericRepository<T>.GetAllAsync()
    {
        return await context
            .Set<T>()
            .ToListAsync();
    }

    void IGenericRepository<T>.Create(T entity)
    {
        context.Add(entity);
    }

    void IGenericRepository<T>.Update(T entity, Guid? userId)
    {
        entity.LastUpdatedBy = userId;
        entity.LastUpdatedDate = DateTimeOffset.Now;
        context.Update(entity);
    }

    void IGenericRepository<T>.Delete(T entity, Guid? userId)
    {
        entity.IsDeleted = true;
        entity.DeletedDate = DateTimeOffset.Now;
        entity.DeletedBy = userId;
        context.Update(entity);
    }
}