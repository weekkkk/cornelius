using System.Net.Mime;
using Cornelius.Authorization.Models;
using Cornelius.Authorization.Services.Exception;
using Cornelius.Authorization.Services.Providers;
using Cornelius.Authorization.Services.Request;
using Cornelius.Authorization.Services.Services;

namespace Cornelius.Authorization.Services;

public class UserService:IUserService
{
    private readonly IUserProvider _userProvider;
    private readonly IRoleProvider _roleProvider;

    public UserService(IUserProvider userProvider, IRoleProvider roleProvider)
    {
        _userProvider = userProvider;
        _roleProvider = roleProvider;
    }

    public async Task RegistrationAsync(RegistrationRequest command, CancellationToken cancellationToken)
    {
        if (await _userProvider.FindAsync(command.Login, cancellationToken).ConfigureAwait(false) != null)
            throw new EntityExistException("Такой пользователь существует");
        Role? role = null;
        if (command.Role != null)
            role = await _roleProvider.FindAsync(command.Role, cancellationToken);

        var user = new User(command.Login, command.Password, role);
        await _userProvider.CreateAsync(user, cancellationToken);
    }

    

    
}