using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI;

public class ApiDbContext : DbContext
{
    public ApiDbContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "TestDB");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@microsoft.com", IsAdmin = true },
            new User { Id = 2, FirstName = "Richard", LastName = "Roe", Email = "richard.roe@microsoft.com", IsAdmin = false },
            new User { Id = 3, FirstName = "Jean", LastName = "Dupont", Email = "jean.dupont@microsoft.com", IsAdmin = false }
        );
    }

    public DbSet<User> Users { get; set; }
}
