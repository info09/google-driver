using GoogleDriver.API.Data;
using GoogleDriver.API.Repositories;
using GoogleDriver.API.Repositories.Interfaces;
using GoogleDriver.API.SeedWorks.Interface;

namespace GoogleDriver.API.SeedWorks;

public class UnitOfWork : IUnitOfWork
{
    ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }
    public IRootFolderRepository RootFolderRepository => new RootFolderRepository(_context);

    public ISharedToUserRepository SharedToUserRepository => new SharedToUserRepository(_context);

    public async Task<bool> Complete()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public bool HasChanges()
    {
        return _context.ChangeTracker.HasChanges();
    }
}
