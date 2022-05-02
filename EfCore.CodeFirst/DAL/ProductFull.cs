using Microsoft.EntityFrameworkCore;

namespace EfCore.CodeFirst.DAL;
// [Keyless]
public class ProductFull
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Height { get; set; }
}