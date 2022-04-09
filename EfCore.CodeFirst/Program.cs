// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;

Initializer.Build();
using (var _context = new AppDbContext())
{
    var product = new Product()
    {
        Name = "Kalem",
        Price = 100,
        Stock = 1500,
        DiscountPrice = 300,
        Barcode = 3453
    };
    _context.Products.Add(product);
    _context.SaveChanges();
    Console.WriteLine("İşlem Bitti");
}