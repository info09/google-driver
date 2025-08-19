using GoogleDriver.API.Data;
using GoogleDriver.API.Data.Entities;
using GoogleDriver.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GoogleDriver.API.Repositories
{
    public class RootFolderRepository : IRootFolderRepository
    {
        private readonly ApplicationDbContext _context;

        public RootFolderRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(RootFolder rootFolder)
        {
            _context.RootFolders.Add(rootFolder);
        }

        public async Task<RootFolder?> GetRootFolder(Guid id)
        {
            return await _context.RootFolders.FindAsync(id);
        }

        public async Task<RootFolder?> GetRootFolderByUserId(Guid userId)
        {
            return await _context.RootFolders.FirstOrDefaultAsync(i => i.UserId == userId);
        }
    }
}
