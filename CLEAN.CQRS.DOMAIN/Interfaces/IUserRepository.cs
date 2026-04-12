using CLEAN.CQRS.DOMAIN.Entities;

namespace CLEAN.CQRS.DOMAIN.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllAsync();

    Task<User?> GetByIdAsync(Guid id);

    Task AddAsync(User user);

    Task UpdateAsync(User user);

    Task DeleteAsync(User user);
}
