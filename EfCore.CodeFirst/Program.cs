// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var context = new AppDbContext())
{

    var product = new Product()
    {
        Name = "Kalem",
        Price = 100,
        Kdv = 18,
        Stock = 200,
        Barcode = 123
    };
    context.Add(product);
    context.SaveChanges();
    Console.WriteLine("Kayıt Başarılı oldu!");
}