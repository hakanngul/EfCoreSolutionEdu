using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EfCore.CodeFirst.DAL;

public class Product
{
    
    public int Id { get; set; }

    //[Column(TypeName = "nvarchar(200)")]
    public string Url { get; set; }
    
    //[Unicode(false)] // varchar() olarak gelecek bize
    public string Name { get; set; }
    [Precision(18, 2)] 
    public decimal Price { get; set; }
    public int Stock { get; set; }
    //[NotMapped] // Bu ilgili sütun yani Barcode artık veri tabanına oluşmayacak.
    public int Barcode { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
    public virtual ProductFeature ProductFeature { get; set; }


}