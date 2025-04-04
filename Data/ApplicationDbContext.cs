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
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity => 
        {
            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()");
        
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("NOW()");
        
            entity.Property(e => e.DeletedAt)
                .IsRequired(false);
        
            entity.HasIndex(e => e.Email)
                .IsUnique();
        });
    }

    public DbSet<User> Users { get; set; }
}