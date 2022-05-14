// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using EfCore.CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

List<Product> GetProducts(int page, int pageSize)
{
    using (var context = new AppDbContext())
    {
        /// <summary>
        ///    Sayfalama işlemleri
        /// 1 - Take(10)
        /// 2 - Skip(2) 1 2 3 4 5 6 7 8 9 10 Skip ilk 2 sini atlar sonraki 2 taneyi alır
        /// </summary>
        // var category = new Category() {Name = "Defterler"};

        #region DataInsert

        // category.Products.Add(new Product()
        // {
        //     Name = "Defter 1", Price = 100, Stock = 7031, Barcode = 345, Url = "test1.com",
        //     ProductFeature = new ProductFeature() {Color = "Beyaz", Height = 465, Width = 345}
        // });
        // category.Products.Add(new Product()
        // {
        //     Name = "Defter 2", Price = 1600, Stock = 5031, Barcode = 567, Url = "test2.com",
        //     ProductFeature = new ProductFeature() {Color = "Mavi", Height = 465, Width = 345}
        // });
        // category.Products.Add(new Product()
        // {
        //     Name = "Defter 3", Price = 1800, Stock = 1531, Barcode = 124, Url = "test3.com",
        //     ProductFeature = new ProductFeature() {Color = "Yeiş", Height = 465, Width = 345}
        // });
        // category.Products.Add(new Product()
        // {
        //     Name = "Defter 4", Price = 1100, Stock = 1531, Barcode = 876, Url = "test4.com",
        //     ProductFeature = new ProductFeature() {Color = "Turuncu", Height = 465, Width = 345}
        // });
        // category.Products.Add(new Product()
        // {
        //     Name = "Defter 5", Price = 3100, Stock = 1031, Barcode = 567, Url = "test5.com",
        //     ProductFeature = new ProductFeature() {Color = "Mor", Height = 465, Width = 345}
        // });
        //
        // context.Add(category);
        // context.SaveChanges();

        #endregion


        Console.WriteLine("İşlem Başarılı oldu!");
    }

    return null;
}