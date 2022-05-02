// See https://aka.ms/new-console-template for more information

using Bogus;
using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;
using Person = EfCore.CodeFirst.DAL.Person;

Initializer.Build();
using (var context = new AppDbContext())
{
    Console.WriteLine("İşlem Başarılı oldu!");
}