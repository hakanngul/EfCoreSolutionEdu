namespace EfCore.CodeFirst.DAL;

public class Category
{
    public int Id { get; set; }
    public String Name { get; set; }
    public List<Product> Products { get; set; }
}