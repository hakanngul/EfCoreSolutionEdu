// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using EfCore.CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

using (var context = new AppDbContext())
{
    var products = context.ProductFulls.Where(x=>x.Width>400).ToList();
    Console.WriteLine("İşlem Başarılı oldu!");
}