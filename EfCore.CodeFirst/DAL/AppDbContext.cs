using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EfCore.CodeFirst.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    // public DbSet<Category> Categories { get; set; }
    // public DbSet<ProductFeature> ProductFeatures { get; set; }
    // public DbSet<Student> Students { get; set; }
    // public DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Initializer.Build();
        const string sqlConnection =
            "Server=HAKANGUL\\SQLEXPRESS01;Database=EfCore;Trusted_Connection=True;Integrated Security=true;";
        optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
            .UseSqlServer(sqlConnection);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().Property(x => x.PriceKdv).HasComputedColumnSql("[Price] * [Kdv]");
        // modelBuilder.Entity<Product>().Property(x => x.PriceKdv).ValueGeneratedOnAdd(); // identity
        // modelBuilder.Entity<Product>().Property(x => x.PriceKdv).ValueGeneratedOnAddOrUpdate(); // computed
        // modelBuilder.Entity<Product>().Property(x => x.PriceKdv).ValueGeneratedNever(); // None
        base.OnModelCreating(modelBuilder);
    }
}