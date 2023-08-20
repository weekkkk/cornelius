using Cornelius.Authorization.Models;
using Microsoft.EntityFrameworkCore;

namespace Cornelius.Authorization.Providers;

public class AuthorizationContext:DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    
    public AuthorizationContext()
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;" +
                                 "Port=5432;" +
                                 "Database=authorization;" +
                                 "Username=postgres;" +
                                 "Password=37242");
    }
}