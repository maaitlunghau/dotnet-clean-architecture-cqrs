using CLEAN.CQRS.DOMAIN.Entities;
using CLEAN.CQRS.DOMAIN.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CLEAN.CQRS.INFRASTRUCTURE.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _dbContext;
    public UserRepository(ApplicationDbContext dbContext)
        => _dbContext = dbContext;

    public async Task<IEnumerable<User>> GetAllAsync()
        => await _dbContext.Users.ToListAsync();
    public async Task<User?> GetByIdAsync(Guid id)
        => await _dbContext.Users.FindAsync(id);

    public async Task AddAsync(User user)
    {
        await _dbContext.Users.AddAsync(user);
        await _dbContext.SaveChangesAsync();
    }
    public async Task UpdateAsync(User user)
    {
        _dbContext.Users.Update(user);
        await _dbContext.SaveChangesAsync();
    }
    public async Task DeleteAsync(User user)
    {
        _dbContext.Users.Remove(user);
        await _dbContext.SaveChangesAsync();
    }
}