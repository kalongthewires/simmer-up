namespace Persistence;

using Domain;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Fat>? Fats { get; set; }
    public DbSet<Ingredient>? Ingredients { get; set; }
}