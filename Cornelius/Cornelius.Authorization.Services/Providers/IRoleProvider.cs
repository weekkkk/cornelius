using Cornelius.Authorization.Models;

namespace Cornelius.Authorization.Services.Providers;

public interface IRoleProvider
{
    Task CreateAsync(Role role, CancellationToken cancellationToken);
    Task<Role?> FindAsync(string roleName, CancellationToken cancellationToken);
}