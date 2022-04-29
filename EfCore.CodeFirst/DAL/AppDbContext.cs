using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EfCore.CodeFirst.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Employee> Employees { get; set; }


    private const string Sql =
        "Server=HAKANGUL\\SQLEXPRESS01;Database=EfCore;Trusted_Connection=True;Integrated Security=true;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Initializer.Build();
        optionsBuilder.UseSqlServer(Sql);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent Owned Entity Types 
        modelBuilder.Entity<Manager>().OwnsOne(x => x.Person, p =>
        {
            p.Property(x => x.FirstName).HasColumnName("FirstName");
            p.Property(x => x.LastName).HasColumnName("LastName");
            p.Property(x => x.Age).HasColumnName("Age");
        });
        modelBuilder.Entity<Employee>().OwnsOne(x => x.Person, e =>
        {
            e.Property(x => x.FirstName).HasColumnName("FirstName");
            e.Property(x => x.LastName).HasColumnName("LastName");
            e.Property(x => x.Age).HasColumnName("Age");
        });
        base.OnModelCreating(modelBuilder);
    }
}