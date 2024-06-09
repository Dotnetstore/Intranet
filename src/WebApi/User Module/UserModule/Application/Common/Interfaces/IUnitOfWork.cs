using MediatR;
using Utilities.Entities;

namespace UserModule.Application.Common.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<T> Repository<T>() where T : BaseAuditableEntity;

    Task SaveAsync(CancellationToken cancellationToken);

    void Rollback();
    
    ISender Sender { get; }
}