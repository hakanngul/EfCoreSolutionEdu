// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var context = new AppDbContext())
{
    string[] pr = {"Kalem", "Defter", "Kitap", "Çanta", "Boya Çantası", "Resim Defteri", "Uhu", "Makas"};

    for (var i = 0; i < 5000; i++)
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
    await context.SaveChangesAsync();
}