using Microsoft.EntityFrameworkCore;

namespace EfCore.CodeFirst.DAL;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    [Precision(9, 2)] public decimal Price { get; set; }

    [Precision(9, 2)] public decimal DiscountPrice { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int Stock { get; set; }

    public int Barcode { get; set; }
}