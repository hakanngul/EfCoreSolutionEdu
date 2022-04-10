using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EfCore.CodeFirst.DAL;

public class AppDbContext: DbContext
{
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Initializer.Build();
        const string sqlConnection = "Server=HAKANGUL\\SQLEXPRESS01;Database=EfCore;Trusted_Connection=True;Integrated Security=true;";
        optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information).UseSqlServer(sqlConnection);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent API
        modelBuilder.Entity<Product>().HasKey(x => x.Id);
        modelBuilder.Entity<Product>().Property(x=>x.Name).HasMaxLength(200)
            .IsRequired();
        base.OnModelCreating(modelBuilder);
    }

    public override int SaveChanges()
    {
        ChangeTracker.Entries().ToList().ForEach(e =>
        {
            if (e.Entity is not Product product) return;
            if(e.State == EntityState.Added)
                product.CreatedDate = DateTime.Now;
        });
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        ChangeTracker.Entries().ToList().ForEach(e =>
        {
            if (e.Entity is not Product product) return;
            if(e.State == EntityState.Added)
                product.CreatedDate = DateTime.Now;
        });
        return base.SaveChangesAsync(cancellationToken);
    }
}