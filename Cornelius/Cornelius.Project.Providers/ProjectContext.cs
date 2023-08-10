using Cornelius.Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Cornelius.Project.Providers;

public class ProjectContext:DbContext
{
    public DbSet<Project.Models.Project> Projects { get; set; }
    public DbSet<Image> Images { get; set; }
    
    public ProjectContext()
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;" +
                                 "Port=5432;" +
                                 "Database=project;" +
                                 "Username=postgres;" +
                                 "Password=37242");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }

}