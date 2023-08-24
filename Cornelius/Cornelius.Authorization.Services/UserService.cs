using System.Net.Mime;
using Cornelius.Authorization.Models;
using Cornelius.Authorization.Services.Exception;
using Cornelius.Authorization.Services.Providers;
using Cornelius.Authorization.Services.Request;
using Cornelius.Authorization.Services.Service;

namespace Cornelius.Authorization.Services;

public class UserService:IUserService
{
    private readonly IUserProvider _userProvider;
    private readonly IRoleProvider _roleProvider;
    private readonly ITokenProvider _tokenProvider;

    public UserService(IUserProvider userProvider, IRoleProvider roleProvider, ITokenProvider tokenProvider)
    {
        _userProvider = userProvider;
        _roleProvider = roleProvider;
        _tokenProvider = tokenProvider;
    }

    public async Task RegistrationAsync(RegistrationRequest command, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command);
        if (await _userProvider.FindAsync(command.Login, cancellationToken).ConfigureAwait(false) is not null)
            throw new EntityExistException("Такой логин уже занят");
        
        var role = await _roleProvider.FindAsync(command.Role, cancellationToken);

        var user = new User(command.Login, command.Password, role);
        await _userProvider.CreateAsync(user, cancellationToken);
    }
    
    public async Task<Token> LoginAsync(LoginRequest command, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command);
        var user = await _userProvider.FindAsync(command.Login, cancellationToken).ConfigureAwait(false);
        var except = user is null;
        var exceptTwo = user.Verify(command.Password);
        if (user is null || !user.Verify(command.Password))
            throw new EntityExistException("Неверный логин или пароль");

        return _tokenProvider.CreateToken(user);
    }
    
}