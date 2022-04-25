// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var context = new AppDbContext())
{
    //Lazy Loading => Geç Yüklenme İşlemi de denilebilir.
    //Category e bağlı alt entity de sorgu olması durumunda Lazy veya Exxplicit Loading kullanılmalı.

    var category = await context.Categories.FirstOrDefaultAsync();
    Console.WriteLine("Category Çekildi ");
    var products = category.Products;

    foreach (var product in products)
    {
        var productFeature = product.ProductFeature;
    }
    
    Console.WriteLine("İşlem Başarılı oldu!");
}