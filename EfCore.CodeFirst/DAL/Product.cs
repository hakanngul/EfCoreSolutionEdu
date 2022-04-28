using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EfCore.CodeFirst.DAL;

public class Product
{
    // Id yi otomatik arttırma özelliğini kapatıyoruz bu şekilde yaparsak
    // [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public string Name { get; set; }

    // burada tutulacak karakter toplam 18 olabilir ve virgülden sonra 2 basamak alınabilir anlamını ifade ediyor.
    [Precision(18, 2)] public decimal Price { get; set; }

    public int Stock { get; set; }
    public int Barcode { get; set; }


    public int CategoryId { get; set; }

    public virtual Category Category { get; set; }

    public virtual ProductFeature ProductFeature { get; set; }


    // public decimal PriceKdv { get; set; }
    // public int Kdv { get; set; }
    // sadece insert işleminde yapsın demek Identity, Update işleminde yapmıyor.
    // [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
    // public DateTime? CreatedDate { get; set; } = DateTime.Now;
    // // sadece insert işleminde yapsın demek Identity, Update işleminde yapmıyor.
    // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    // public int Kdv { get; set; } = 10;
    // //insert ve update işlemlerinde bu propertyi hiç bir şekilde db ye gönderme demek
    // [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    // public DateTime LastUpdateDateTime { get; set; }
}