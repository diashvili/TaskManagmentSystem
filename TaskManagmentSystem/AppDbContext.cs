using Microsoft.EntityFrameworkCore;
using TaskManagmentSystem.Models;


namespace TaskManagmentSystem;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<UserTask> Tasks { get; set; }
    public DbSet<User> Users { get; set; }

}
