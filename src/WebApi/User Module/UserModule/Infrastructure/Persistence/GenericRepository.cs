using Microsoft.EntityFrameworkCore;
using UserModule.Application.Common.Interfaces;
using UserModule.Infrastructure.Contexts;
using Utilities.Entities;

namespace UserModule.Infrastructure.Persistence;

public sealed class GenericRepository<T>(UserModuleContext context) : IGenericRepository<T>
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
        context.Update(entity);
    }

    void IGenericRepository<T>.Delete(T entity, Guid? userId)
    {
        context.Update(entity);
    }
}