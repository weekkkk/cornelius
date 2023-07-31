

using Cornelius.Product.Models;
using Microsoft.EntityFrameworkCore;

namespace Cornelius.Product.Providers;

public class ProductContext:DbContext
{
    public DbSet<Models.Product> Products { get; set; }
    public DbSet<Image> Images { get; set; }
    
    public ProductContext()
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;" +
                                 "Port=5432;" +
                                 "Database=product;" +
                                 "Username=postgres;" +
                                 "Password=37242");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }

}