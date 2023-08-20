using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Cornelius.Authorization.Models;
using Cornelius.Authorization.Services.Providers;
using Cornelius.Authorization.Services.Request;
using Cornelius.Authorization.Services.Services;
using Microsoft.IdentityModel.Tokens;

namespace Cornelius.Authorization.Providers.Providers;

public class TokenProvider : ITokenProvider
{
    private readonly IAuthOptions _authOptions;

    public TokenProvider(IAuthOptions authOptions)
    {
        _authOptions = authOptions;
    }

    public Token CreateToken(User user)
    {
        ArgumentNullException.ThrowIfNull(user);
        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenKey = Encoding.UTF8.GetBytes(_authOptions.Key);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Sid, Convert.ToString(user.Id))
            }),
            Expires = null,
            SigningCredentials =
                new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return new Token { Value = tokenHandler.WriteToken(token) };
    }
}