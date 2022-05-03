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
        modelBuilder.Entity<Product>().HasIndex(x => x.Name).IncludeProperties(x => new {x.Price, x.Stock, x.Barcode});
        // busniess ve db için bir şart ve kısıtlama yaptırıyoruz.
        modelBuilder.Entity<Product>().HasCheckConstraint("PriceDiscountCheck" ,"[Price]>[DiscountPrice]");
        base.OnModelCreating(modelBuilder);
    }
}