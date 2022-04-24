// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var context = new AppDbContext())
{
    //Expilict Loading işleminde bağlı olan product veya diğer bağlı entrylerin yüklenme işlemini sonra yapabiliyoruz.
    // var category = context.Categories.FirstOrDefault();

    // if (true)
    // {
        // Product ile category arasında collection ilişki bulunuyor.
        // var products = context.Products.Where(x => x.CategoryId == category.Id);
        // burada if doğru olduğunda category e producları yükleme yapıyoruz.
        // context.Entry(category).Collection(x => x!.Products).Load();
        // category?.Products.ForEach(x => { Console.WriteLine(x.Name); });
    // }
    var product = context.Products.FirstOrDefault();
    if (true)
    {
        // context.ProductFeatures.Where(x => x.Id == product.Id).First();
        //Product ile ProductFeature arasında referans üzerinden erişim yapabiliyoruz.
        //çünkü referans ilişkisi bulunuyor.
        context.Entry(product).Reference(x=>x.ProductFeature).Load();
    }
    
    Console.WriteLine("İşlem Başarılı oldu!");
}