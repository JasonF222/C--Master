namespace CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

public class DishContext :DbContext
{
    public DishContext(DbContextOptions options) : base(options) { }
    public DbSet<Dish> Dishes { get; set; } = null!; 
}