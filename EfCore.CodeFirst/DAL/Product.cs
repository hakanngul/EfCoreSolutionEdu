using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EfCore.CodeFirst.DAL;

//[Table("ProductTb", Schema = "products")]
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal DiscountPrice { get; set; }
    public int Stock { get; set; }
    public int Barcode { get; set; }
    public DateTime? CreatedDate { get; set; }

}