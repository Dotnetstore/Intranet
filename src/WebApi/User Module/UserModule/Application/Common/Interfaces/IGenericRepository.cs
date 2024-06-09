using Utilities.Entities.Interfaces;

namespace UserModule.Application.Common.Interfaces;

public interface IGenericRepository<T> where T : class, IBaseAuditableEntity
{
    IQueryable<T> Entities { get; }

    Task<List<T>> GetAllAsync();

    void Create(T entity);

    void Update(T entity, Guid? userId = null);

    void Delete(T entity, Guid? userId = null);
}