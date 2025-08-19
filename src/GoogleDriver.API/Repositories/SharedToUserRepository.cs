using GoogleDriver.API.Data;
using GoogleDriver.API.Data.Entities;
using GoogleDriver.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GoogleDriver.API.Repositories
{
    public class SharedToUserRepository : ISharedToUserRepository
    {
        private readonly ApplicationDbContext _context;

        public SharedToUserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(SharedToUser entity)
        {
            _context.SharedToUsers.Add(entity);
        }

        public async Task<SharedToUser?> GetSharedToUserById(Guid id)
        {
            return await _context.SharedToUsers.FindAsync(id);
        }

        public async Task<SharedToUser?> GetSharedToUserByUrl(string url, string username)
        {
            return await _context.SharedToUsers.FirstOrDefaultAsync(x => (x.Url == url && x.SharedUserName == username) || (x.Url == url && x.OwnerUserName == username));
        }
    }
}
