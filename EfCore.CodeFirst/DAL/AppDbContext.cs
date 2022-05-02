using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EfCore.CodeFirst.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    // public DbSet<Category> Categories { get; set; }
    // public DbSet<ProductFeature> ProductFeatures { get; set; }
    // public DbSet<ProductFull> ProductFulls { get; set; }
    // public DbSet<Person> People { get; set; }

    private const string Sql =
        "Server=HAKANGUL\\SQLEXPRESS01;Database=EfCore;Trusted_Connection=True;Integrated Security=true;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Initializer.Build();
        optionsBuilder.UseSqlServer(Sql);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Bu ilgili sütun yani Barcode artık veri tabanına oluşmayacak.
        modelBuilder.Entity<Product>().Ignore(x => x.Barcode);
        // Bu ilgili property artık nvarchar değil varchar olarak olacak.
        modelBuilder.Entity<Product>().Property(x => x.Name).IsUnicode(false);
        //Db tarafında propertinin özellğini ve ismini değiştirme işlemi yapıyoruz.
        modelBuilder.Entity<Product>().Property(x => x.Url).HasColumnType("varchar(500)").HasColumnName("ProductUrl");
        base.OnModelCreating(modelBuilder);
    }
}