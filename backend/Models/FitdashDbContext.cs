using Microsoft.EntityFrameworkCore;

namespace Fitdash.Models;

public class FitdashDbContext : DbContext
{
    public FitdashDbContext(DbContextOptions<FitdashDbContext> options)
        : base(options) { }

    public DbSet<GroceryItem> Groceries => Set<GroceryItem>();
}