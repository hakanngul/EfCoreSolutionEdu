// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var context = new AppDbContext())
{
    // var category = new Category()
    // {
    //     Name = "Kalemler", Products = new List<Product>()
    //     {
    //         new(){Name = "Kalem1", Price = 100, Stock = 250, Barcode = 123},
    //         new(){Name = "Kalem2", Price = 100, Stock = 250, Barcode = 123},
    //         new(){Name = "Kalem3", Price = 100, Stock = 250, Barcode = 123},
    //     }
    // };
    // context.Add(category);
    var category = context.Categories.First();
    context.Remove(category);
    context.SaveChanges();
    Console.WriteLine("Kayıt Başarılı oldu!");
}