using Cornelius.Authorization.Models;

namespace Cornelius.Authorization.Services.Providers;

public interface IUserProvider
{
    Task CreateAsync(User user, CancellationToken cancellationToken);
    Task<User> FindAsync(string login, CancellationToken cancellationToken);
    Task UpdateAsync(User user, CancellationToken cancellationToken);
}