// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;

Initializer.Build();
using (var context = new AppDbContext())
{
    Console.WriteLine("İşlem Başarılı oldu!");
}