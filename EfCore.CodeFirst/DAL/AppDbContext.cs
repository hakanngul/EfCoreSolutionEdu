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
}