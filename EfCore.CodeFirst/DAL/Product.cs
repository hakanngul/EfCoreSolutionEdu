using Microsoft.EntityFrameworkCore;

namespace EfCore.CodeFirst.DAL;

//[Index(nameof(Name), nameof(Price))] => Birlikte kullanımı için  yapılan örnek Ayrı ayrı için ise şöyle
[Index(nameof(Price))] //sadece Price de sorgu yaparsak çok hızlı çalışacak
[Index(nameof(Name))] //sadece name de sorgu yaparsak çok hızlı çalışacak
[Index(nameof(Url))]
[Index(nameof(Name), nameof(Url))] // Burada her 2 si içinde index yaptığımız için birlikte kullanımda çok hızlı çalışacaktır.
public class Product
{
    //Note: Bu indexleme işlemi çok maliyetli bir olay ayrı tablolar oluşturulduğu için maliyet artabilir.
    //context.Products.Where(x=>x.Name="kalem1" && price>1000)
    //indexleme işleminde sorgu olayında EfCore un hızlı çalışması ve db yi indexleme yaptığı için
    //veriyi hızlı döndürme işlemi yapmaktadır.
    //context.products.where(x=>x.name="kalem1").select(x=>new{name=x.Name, Price=x.price})
    public int Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public int Barcode { get; set; }
    public int CategoryId { get; set; }
}