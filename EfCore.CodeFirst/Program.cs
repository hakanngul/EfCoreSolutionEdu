// See https://aka.ms/new-console-template for more information

using Bogus;
using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var context = new AppDbContext())
{

    
    Console.WriteLine("İşlem Başarılı oldu!");
}