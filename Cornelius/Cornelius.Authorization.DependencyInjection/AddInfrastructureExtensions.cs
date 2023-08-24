using Cornelius.Authorization.Providers;
using Cornelius.Authorization.Providers.Providers;
using Cornelius.Authorization.Services.Providers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Cornelius.Authorization.DependencyInjection;

public static partial class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection service)
    {
        service.AddDbContext<AuthorizationContext>();
        service.AddCors(o => o.AddPolicy("ReactPolicy", builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        }));
        service.AddScoped<IUserProvider, UserProvider>();
        service.AddScoped<IRoleProvider, RoleProvider>();


        return service;
    }
}