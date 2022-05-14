// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

using (var context = new AppDbContext())
{
    var products = context.Products.ToList();
    //Products Console.WriteLine with foreach
    Console.WriteLine(products.Count);
}