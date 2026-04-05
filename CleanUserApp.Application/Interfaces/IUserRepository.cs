using CleanUserApp.Domain.Entities;

namespace CleanUserApp.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User?> GetByIdAsync(int id);
        Task<int> AddAsync(User user);
    }
}