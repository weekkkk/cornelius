
using Cornelius.Authorization.Services;
using Cornelius.Authorization.Services.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Cornelius.Authorization.DependencyInjection;

public static partial class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection service)
    {
        service.AddScoped<IUserService, UserService>();
        return service;
    }
}