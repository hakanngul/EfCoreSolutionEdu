// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

foreach (var product in GetProducts(3, 6))
{
    Console.WriteLine($"{product.Id} {product.Name} {product.Price} {product.Stock}");
}

static List<Product> GetProducts(int page, int pageSize)
{
    using (var context = new AppDbContext())
    {
        //page = 1 pageSize = 3 => ilk 3 data => skip(0) take(3) (page-1)*pageSize => (1-1)*3 = 0
        //page = 2 pageSize = 3 => ikinci 3 data => skip(3) take(3) (page-1)*pageSize => (2-1)*3 = 3
        //page = 3 pageSize = 3 => üçüncü 3 data => skip(6) take(3) (page-1)*pageSize => (3-1)*3 = 6

        return context.Products
            .OrderByDescending(x => x.Id)
            .Skip((page - 1) * pageSize)
            .Take(pageSize).ToList();
    }
}