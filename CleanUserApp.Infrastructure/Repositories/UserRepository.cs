using CleanUserApp.Application.Interfaces;
using CleanUserApp.Domain.Entities;
using CleanUserApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanUserApp.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.AsNoTracking().ToListAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _context.Users.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user.Id;
        }
    }
}