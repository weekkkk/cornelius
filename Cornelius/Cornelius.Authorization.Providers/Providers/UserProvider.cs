using Cornelius.Authorization.Models;
using Cornelius.Authorization.Services.Providers;
using Microsoft.EntityFrameworkCore;

namespace Cornelius.Authorization.Providers.Providers;

public class UserProvider: IUserProvider
{
    private readonly AuthorizationContext _authorizationContext;

    public UserProvider(AuthorizationContext authorizationContext)
    {
        _authorizationContext = authorizationContext;
    }

    public async Task<User> FindAsync(string login, CancellationToken cancellationToken)
    {
        var user = await _authorizationContext.Users
            .Include(u => u.Role)
            .FirstOrDefaultAsync(d => d.Login == login, cancellationToken: cancellationToken).ConfigureAwait(false);
        return user;

    }

    public async Task CreateAsync(User user, CancellationToken cancellationToken)
    {
        _authorizationContext.Add(user);
        await _authorizationContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
    }

    public async Task UpdateAsync(User user, CancellationToken cancellationToken)
    {
        _authorizationContext.Update(user);
        await _authorizationContext.SaveChangesAsync(cancellationToken);
    }
}