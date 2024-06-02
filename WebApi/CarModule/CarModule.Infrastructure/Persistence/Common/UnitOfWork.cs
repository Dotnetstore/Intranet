using System.Collections;

namespace CarModule.Infrastructure.Persistence.Common;

public class UnitOfWork(CarModuleContext context, ISender sender) : IUnitOfWork
{
    private readonly CarModuleContext _context = context ?? throw new ArgumentNullException(nameof(context));
    private readonly Hashtable _repositories = new();
    private bool _isDisposed;

    IGenericRepository<T> IUnitOfWork.Repository<T>()
    {
        var type = typeof(T).Name;

        if (!_repositories.ContainsKey(type))
        {
            var repositoryType = typeof(GenericRepository<>);

            var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);

            _repositories.Add(type, repositoryInstance);
        }

        return (IGenericRepository<T>) _repositories[type]!;
    }
    
    async Task IUnitOfWork.SaveAsync(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }

    void IUnitOfWork.Rollback()
    {
        _context.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
    }

    public ISender Sender { get; } = sender;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_isDisposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
        
        _isDisposed = true;
    }
}