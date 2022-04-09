// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var context = new AppDbContext())
{
    // var product = context.Products.First(x => x.Id == 1); Bulamazsa exception fırlatıyor
    //var product = context.Products.First(x => x.Id == 11021);
    // var product = context.Products.FirstOrDefault(x => x.Id == 4535345);
    // var product = await context.Products.SingleAsync(x => x.Id == 11021);
    // var product = await context.Products.SingleAsync(x => x.Id > 11021); Single tek bir data için çalışır fazla olmasında exception fırlatır.
    // var products = await context.Products.Where(x => x.Id > 11021 && x.Id < 11396).ToListAsync();
    // var product = await context.Products.FindAsync(11021); // id si 10 olanı bulur null istemiyorsak Single kullanmalıyız.
    var product = await context.Products.AsNoTracking().FirstAsync(x => x.Id == 11021);
    Console.WriteLine(context.Entry(product).State);
    //await context.SaveChangesAsync();
}