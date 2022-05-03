// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;

Initializer.Build();
using (var context = new AppDbContext())
{
    context.Products.Add(new()
    {
        Name = "Kalem1",Stock = 100,Url = "test", Barcode = 123,
        Price = 200,DiscountPrice = 450
        
    });
    context.SaveChanges();
    Console.WriteLine("İşlem Başarılı oldu!");
}