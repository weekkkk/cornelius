using Cornelius.Authorization.Models;
using Cornelius.Authorization.Services.Providers;
using Microsoft.EntityFrameworkCore;

namespace Cornelius.Authorization.Providers.Providers;

public class RoleProvider: IRoleProvider
{
    private readonly AuthorizationContext _authorizationContext;

    public RoleProvider(AuthorizationContext authorizationContext)
    {
        _authorizationContext = authorizationContext;
    }
    public async Task CreateAsync(Role role, CancellationToken cancellationToken)
    {
        _authorizationContext.Add(role);
        await _authorizationContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
    }

    public async Task<Role> FindAsync(string roleName, CancellationToken cancellationToken)
    {
        var role = await _authorizationContext.Roles
            .FirstOrDefaultAsync(d => d.Name == roleName, cancellationToken: cancellationToken).ConfigureAwait(false);
        return role;
    }
   
}