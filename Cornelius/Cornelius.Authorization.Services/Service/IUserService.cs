using Cornelius.Authorization.Services.Request;

namespace Cornelius.Authorization.Services.Service;

public interface IUserService
{
    Task RegistrationAsync(RegistrationRequest command, CancellationToken cancellationToken);
    Task<Token> LoginAsync(LoginRequest loginRequest, CancellationToken cancellationToken);
    
}