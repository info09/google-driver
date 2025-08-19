using GoogleDriver.API.Data.Entities;

namespace GoogleDriver.API.Repositories.Interfaces;

public interface ISharedToUserRepository
{
    void Add(SharedToUser entity);
    Task<SharedToUser?> GetSharedToUserById(Guid id);
    Task<SharedToUser?> GetSharedToUserByUrl(string url, string username);
}
