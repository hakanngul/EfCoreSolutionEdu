using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EfCore.CodeFirst.DAL;

public class AppDbContext : DbContext
{
    //Lazy Loading işleminde bütün navigation propertylerin hepsi virtual işaretlenmeli yoksa hata fırlatır.
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductFeature> ProductFeatures { get; set; }

    // public DbSet<Student> Students { get; set; }
    // public DbSet<Teacher> Teachers { get; set; }

    private string Sql { get; } =
        "Server=HAKANGUL\\SQLEXPRESS01;Database=EfCore;Trusted_Connection=True;Integrated Security=true;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Initializer.Build();
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information)
            .UseLazyLoadingProxies()
            .UseSqlServer(Sql);
    }
}