using Cornelius.Authorization.Models;
using Cornelius.Authorization.Services.Request;

namespace Cornelius.Authorization.Services.Providers;

public interface ITokenProvider
{
    Token CreateToken(User user);
}