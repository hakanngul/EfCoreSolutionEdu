// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var context = new AppDbContext())
{
    Console.WriteLine("Program Cs Başlatıldı...");
    
    //Product = Parent
    //ProductFeature =>> Child

    // var category = context.Categories.First(x => x.Name == "Silgiler");
    var category = new Category() {Name = "Silgiler"};
    var product = new Product()
    {
        Name = "Silgi6", Price = 50, Barcode = 943, Stock = 200, Category = category,
        ProductFeature = new ProductFeature {Color = "Green", Height = 100, Width = 200}
    };

    context.Add(product);
    context.SaveChanges();
    
    Console.WriteLine("Kayıt Başarılı oldu!");
}