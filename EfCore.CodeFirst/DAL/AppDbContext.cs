using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EfCore.CodeFirst.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

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
        // modelBuilder.Entity<Product>().HasOne(x => x.ProductFeature).WithOne(x => x.Product).HasForeignKey<ProductFeature>(x => x.Id);
        // Note: Manuel olarak el ile many to many işlemi
        modelBuilder.Entity<Student>().HasMany(x => x.Teachers)
            .WithMany(x => x.Students).UsingEntity<Dictionary<string, object>>(
                "StudentTeacherManyToMany",
                x=>x.HasOne<Teacher>().WithMany().HasForeignKey("Teacher_Id").HasConstraintName("FK__TreacherId"),
                x=>x.HasOne<Student>().WithMany().HasForeignKey("Student_Id").HasConstraintName("FK__StudentId")
                
            );
        base.OnModelCreating(modelBuilder);
    }


    public override int SaveChanges()
    {
        ChangeTracker.Entries().ToList().ForEach(e =>
        {
            if (e.Entity is not Product product) return;
            if (e.State == EntityState.Added)
                product.CreatedDate = DateTime.Now;
        });
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        ChangeTracker.Entries().ToList().ForEach(e =>
        {
            if (e.Entity is not Product product) return;
            if (e.State == EntityState.Added)
                product.CreatedDate = DateTime.Now;
        });
        return base.SaveChangesAsync(cancellationToken);
    }
}