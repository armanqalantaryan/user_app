using Microsoft.EntityFrameworkCore;
using user_app.Components;

namespace user_app.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            
        }
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<User> Users { get; set; }
}