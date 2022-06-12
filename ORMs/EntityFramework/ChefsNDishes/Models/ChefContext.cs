namespace ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

public class ChefContext : DbContext
{
    public ChefContext(DbContextOptions options) : base(options) { }
    public DbSet<Chef> Chefs { get; set; } = null!;
    public DbSet<Dish> Dishes { get; set; } = null!;
}
