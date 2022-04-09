using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EfCore.CodeFirst.DAL;

public class AppDbContext: DbContext
{
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Initializer.Build();
        optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information).UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
    }

    
}