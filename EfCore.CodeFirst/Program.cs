// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var context = new AppDbContext())
{
    // context.Products.Add(new() {Name = "Kalem", Price = 200, Stock = 7150, Barcode = 123});
    // context.Products.Add(new() {Name = "Defter", Price = 600, Stock = 650, Barcode = 456});
    // context.Products.Add(new() {Name = "Silgi", Price = 80, Stock = 4250, Barcode = 789});
    // context.Products.Add(new() {Name = "Kitap", Price = 350, Stock = 450, Barcode = 321});
    // context.Products.Add(new() {Name = "Kırmızı Kalem", Price = 220, Stock = 1350, Barcode = 654});

    string[] pr = {"Kalem", "Defter", "Kitap"};

   for (var i = 0; i < 10000; i++)
    {
        await context.Products.AddAsync(new()
        {
            Name = pr.PickRandom()+ " " + Random.Shared.Next(i, i + 2513),
            Price = Random.Shared.Next(0, i + 1000),
            Stock = Random.Shared.Next(0, i + 3410),
            DiscountPrice = Random.Shared.Next(0, i + 9410),
            Barcode = Random.Shared.Next(0, i + 1400)
        });
    }


    Console.WriteLine($"Context Id : {context.ContextId}");

    //var products = await context.Products.AsNoTracking().ToListAsync();
    // products.ForEach(p =>
    // {
    //     Console.WriteLine(p.Name);
    // });
    // context.ChangeTracker.Entries().ToList().ForEach(e =>
    // {
    //     Console.WriteLine("Test Hakan GÜL 1");
    //     if (e.Entity is Product product)
    //     {
    //         Console.WriteLine($"{product.Id} - {product.Name} - {product.Stock}");
    //     }
    //
    //     Console.WriteLine("Test Hakan GÜL 2");
    // });
    // var product = await context.Products.FirstAsync(x => x.Id == 3);
    // product.DiscountPrice = 4513;
    // await context.SaveChangesAsync();
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


    await context.SaveChangesAsync();
}