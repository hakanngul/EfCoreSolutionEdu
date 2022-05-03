using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EfCore.CodeFirst.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    
    private const string Sql =
        "Server=HAKANGUL\\SQLEXPRESS01;Database=EfCore;Trusted_Connection=True;Integrated Security=true;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Initializer.Build();
        optionsBuilder.UseSqlServer(Sql);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Product>().HasIndex(x => x.Name);
        // modelBuilder.Entity<Product>().HasIndex(x => new {x.Name, x.Url});
        // altta bulunan kısımda Indexi Name olarak alıyoruz fakat beraberinde diyoruz ki Price ile Stocku da ekle diyoruz.
        //    var response = context.Products.Where(x => x.Name == "kalem1").Select(x => new {name = x.Name, Price = x.Price, Stock = x.Stock});
        modelBuilder.Entity<Product>().HasIndex(x => x.Name).IncludeProperties(x=>new {x.Price, x.Stock});
        modelBuilder.Entity<Product>().Property(x => x.Price).HasPrecision(9, 2);
        base.OnModelCreating(modelBuilder);
    }
}