namespace EfCore.CodeFirst.DAL;

public class Product
{
    public int Id { get; set; }
    public String Name { get; set; }
    public decimal Price { get; set; }
    public decimal DiscountPrice { get; set; }
    public int Stock { get; set; }
    public int Barcode { get; set; }
    public DateTime? CreatedDate { get; set; }
    // public int CategoryId { get; set; }
    // public Category Category { get; set; }
}