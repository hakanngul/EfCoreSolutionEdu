// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;

Initializer.Build();
using (var context = new AppDbContext())
{
    var response = context.Products.Where(x => x.Name == "kalem1")
        .Select(x => new {name = x.Name, Price = x.Price, Stock = x.Stock});

    Console.WriteLine("İşlem Başarılı oldu!");
}