// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var context = new AppDbContext())
{
    var product = await context.Products.FirstAsync(x => x.Id == 3);
    product.DiscountPrice = 4513;
    await context.SaveChangesAsync();
    // var product = await _context.Products.FirstAsync();
    // var products = _context.Products.Where(product1 => product1.Id == 3);
    // var products = await _context.Products.AsNoTracking().ToListAsync();
    // products.ForEach(p =>
    // {
    //     Console.WriteLine($"{p.Name} - {p.Price}");
    // });

    // Console.WriteLine($"State Önce => {_context.Entry(product).State}");
    // Console.WriteLine($"State Sonra => {_context.Entry(product).State}");
    // await _context.SaveChangesAsync();
    // Console.WriteLine($"State SonHali => {_context.Entry(product).State}");
    // Console.WriteLine(product);
    // var newProduct = new Product()
    // {
    //     Name = "Telefon",
    //     Price = 4000,
    //     Stock = 100,
    //     Barcode = 333
    // };
    // await _context.AddAsync(newProduct);

    // var products = await _context.Products.ToListAsync();
    // products.ForEach(p =>
    // {
    //     var state = _context.Entry(p).State;
    //     Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.Stock} - {p.DiscountPrice}");
    //     Console.WriteLine($"State => {state}");
    // });
}