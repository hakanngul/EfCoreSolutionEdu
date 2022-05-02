// See https://aka.ms/new-console-template for more information

using Bogus;
using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var context = new AppDbContext())
{
    var productFulls = context.ProductFulls.FromSqlRaw(
        @"SELECT p.Id , c.Name 'CategoryName', p.Name, p.Price, pf.Height FROM Products as p
        JOIN ProductFeatures pf on p.Id = pf.Id
        JOIN Categories c on p.CategoryId = c.Id").ToList();
    // var category = new Category() {Name = "Kalemler"};
    // category.Products.Add(new Product(){Name = "Kalem1", Price = 100, Stock = 200, Barcode = 123, ProductFeature = new()
    // {
    //     Color = "Red", Height = 150,Width = 300
    // }});
    // category.Products.Add(new Product(){Name = "Kalem2", Price = 100, Stock = 200, Barcode = 123, ProductFeature = new()
    // {
    //     Color = "Green", Height = 150,Width = 300
    // }});
    // category.Products.Add(new Product(){Name = "Kalem3", Price = 100, Stock = 200, Barcode = 123, ProductFeature = new()
    // {
    //     Color = "Blue", Height = 150,Width = 300
    // }});
    // await context.AddAsync(category);
    // await context.SaveChangesAsync();
    Console.WriteLine("İşlem Başarılı oldu!");
}