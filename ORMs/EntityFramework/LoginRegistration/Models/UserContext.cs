namespace LoginRegistration.Models;
using Microsoft.EntityFrameworkCore;

public class UserContext : DbContext
{
    public UserContext(DbContextOptions options) : base(options) { }
    public DbSet<User> Users { get; set; } = null!;
}