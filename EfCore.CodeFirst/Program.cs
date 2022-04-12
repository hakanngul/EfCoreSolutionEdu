// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var context = new AppDbContext())
{
    // var category = new Category() {Name = "Çantalar"};
    // var product = new Product() {Name = "Defter1", Price = 150, Stock = 400, Barcode = 5436, Category = category};

    var category = await context.Categories.FirstAsync(x => x.Name == "Çantalar");
    var product = new Product() { Name = "Çanta3", Price = 4500, Stock = 10, Barcode = 34536, CategoryId = category.Id};



    context.Add(product);
    context.SaveChanges();
    Console.WriteLine("Kayıt Başarılı oldu!");
}