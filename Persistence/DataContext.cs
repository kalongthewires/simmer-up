
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DataContext : DbContext
{
    public DbSet<Fat>? Fats { get; set; }
    public DbSet<Ingredient>? Ingredients { get; set; }

    public DataContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        new FatDataUnit(modelBuilder).SeedData();
    }
}