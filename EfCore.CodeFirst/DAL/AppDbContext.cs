using EfCore.CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EfCore.CodeFirst.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductFeature> ProductFeatures { get; set; }
    public DbSet<ProductEssantial> ProductEssantials { get; set; }

    private const string Sql =
        "Server=HAKANGUL\\SQLEXPRESS01;Database=EfCore;Trusted_Connection=True;Integrated Security=true;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Initializer.Build();
        optionsBuilder.UseSqlServer(Sql).LogTo(Console.WriteLine, LogLevel.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductEssantial>().HasNoKey().ToSqlQuery($"Select Name,Price From Products");
        base.OnModelCreating(modelBuilder);
    }
}