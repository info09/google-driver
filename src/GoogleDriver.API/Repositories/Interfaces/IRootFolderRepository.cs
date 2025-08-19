using GoogleDriver.API.Data.Entities;

namespace GoogleDriver.API.Repositories.Interfaces;

public interface IRootFolderRepository
{
    void Add(RootFolder rootFolder);
    Task<RootFolder?> GetRootFolder(Guid id);
    Task<RootFolder?> GetRootFolderByUserId(Guid userId);
}
