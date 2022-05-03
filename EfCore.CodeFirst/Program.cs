﻿// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;

using (var context = new AppDbContext())
{
    // var category = new Category() {Name = "Kalemler"};
    // category.Products.Add(new()
    // {
    //     Name = "Kurşun Kalem", Price = 100, Stock = 100, Barcode = 123, Url = "Kursunx.jpg",
    //     ProductFeature = new ProductFeature() {Color = "Red", Height = 150, Width = 300}
    // });
    // category.Products.Add(new()
    // {
    //     Name = "Tükenmez Kalem", Price = 600, Stock = 230, Barcode = 567, Url = "tukenmezx.jpg",
    //     ProductFeature = new ProductFeature() {Color = "Green", Height = 250, Width = 350}
    // });
    // category.Products.Add(new()
    // {
    //     Name = "Boya Kalemi", Price = 100, Stock = 100, Barcode = 542, Url = "boyax.jpg",
    //     ProductFeature = new ProductFeature() {Color = "Blue", Height = 150, Width = 300}
    // });
    // category.Products.Add(new()
    // {
    //     Name = "Süs Kalemi", Price = 100, Stock = 100, Barcode = 123, Url = "susx.jpg",
    //     ProductFeature = new ProductFeature() {Color = "Yellow", Height = 150, Width = 300}
    // });
    // context.Categories.Add(category);
    // context.SaveChanges();

    var result = context.Categories.Join(context.Products, x => x.Id, y => y.CategoryId, (c, p) => new
    {
        CategoryName = c.Name,
        ProductName = p.Name,
        ProductPrice = p.Price
    }).ToList();
    Console.WriteLine("İşlem Başarılı oldu!");
}