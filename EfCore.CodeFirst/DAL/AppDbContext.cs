using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EfCore.CodeFirst.DAL;

public class AppDbContext: DbContext
{
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Initializer.Build();
        const string sqlConnection = "Server=HAKANGUL\\SQLEXPRESS01;Database=EfCoreDb;Trusted_Connection=True;";
        optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information).UseSqlServer(sqlConnection);
    }

    
}