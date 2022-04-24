// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var context = new AppDbContext())
{
    // var category = new Category()
    // {
    //     Name = "Kalemler"
    // };
    // var category = context.Categories.First();
    //
    // category.Products.Add(new Product() {Name = "Kalem1", Price = 100, Stock = 1200, Barcode = 456, ProductFeature = new ProductFeature()
    // {
    //     Color = "Red",Height = 100,Width = 200
    // }});
    // category.Products.Add(new Product() {Name = "Kalem2", Price = 1500, Stock = 2500, Barcode = 789, ProductFeature = new ProductFeature()
    // {
    //     Color = "Blue",Height = 100,Width = 200
    // }});
    // category.Products.Add(new Product() {Name = "Kalem3", Price = 400, Stock =3300, Barcode = 567, ProductFeature = new ProductFeature()
    // {
    //     Color = "Green",Height = 100,Width = 200
    // }});
    // await context.AddAsync(category);


    //Eager Loading Categoriyi çekerken buna bağlı productlarıda çekmek için kullanıyoruz ve aşşağıdaki şekilde
    //Eager Loading JS deki then işleminide ifade etmektedir.
    //İç içe geçmiş bir yapıyı yani Entityden entitye sıçrama yapabiliyoruz
    // var categoryWithProducts = context.Categories.Include(x => x.Products)
    //     .ThenInclude(x => x.ProductFeature).First();
    //
    // categoryWithProducts.Products.ForEach(product =>
    // {
    //     Console.WriteLine($"{categoryWithProducts.Name} => {product.Name} => {product.ProductFeature.Color}");
    //     
    // });
    //Categoryden productFeature a gittik bu sefer de productFeature dan categorye gideibliyoruz
    // var productFeature = context.ProductFeatures.Include(x => x.Product)
    //     .ThenInclude(x => x.Category).First();
    
    //bu sefer product üzerinden hem productFeature a hemde category e gidebiliyoruz
    // var product = context.Products.Include(x => x.ProductFeature)
    //     .Include(x => x.Category).First();

    //await context.SaveChangesAsync();
    Console.WriteLine("İşlem Başarılı oldu!");
}