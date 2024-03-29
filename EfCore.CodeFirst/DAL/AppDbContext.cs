﻿using System.Linq.Expressions;
using EfCore.CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EfCore.CodeFirst.DAL;

public class AppDbContext : DbContext
{
    private readonly int Barcode;

    public AppDbContext(int barcode)
    {
        Barcode = barcode;
    }

    public AppDbContext()
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductFeature> ProductFeatures { get; set; }

    private const string Sql =
        "Server=HAKANGUL\\SQLEXPRESS01;Database=EfCore;Trusted_Connection=True;Integrated Security=true;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Initializer.Build();
        optionsBuilder.UseSqlServer(Sql).LogTo(Console.WriteLine, LogLevel.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().Property(x => x.IsDeleted).HasDefaultValue(false);
        if (Barcode is not default(int))
        {
            modelBuilder.Entity<Product>().HasQueryFilter(p => !p.IsDeleted && p.Barcode == Barcode);
        }
        else
        {
            modelBuilder.Entity<Product>().HasQueryFilter(p => !p.IsDeleted);
        }

        base.OnModelCreating(modelBuilder);
    }
}