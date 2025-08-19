using GoogleDriver.API.Repositories.Interfaces;

namespace GoogleDriver.API.SeedWorks.Interface;

public interface IUnitOfWork
{
    IRootFolderRepository RootFolderRepository { get; }
    ISharedToUserRepository SharedToUserRepository { get; }
    Task<bool> Complete();
    bool HasChanges();
}
