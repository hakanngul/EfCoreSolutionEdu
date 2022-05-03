// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;

// Initializer.Build();
using (var context = new AppDbContext())
{
    // context.People.AddRange(new Person()
    // {
    //     Name = "Maşide", Phone = "05417564355"
    // }, new Person()
    // {
    //     Name = "Çiçek", Phone = "05347126079"
    // });
    // context.SaveChanges();
    // var person = context.People.ToList().AsReadOnly().Where(x => FormatPhone(x.Phone) == "5417564355").ToList();
    var person = context.People.Where(x=>x.Name.StartsWith("M")).ToList()
        .Select(x => new {PersonName = x.Name, PersonPhone = FormatPhone(x.Phone)})
        .ToList();
    string FormatPhone(string phone) => phone.Substring(1, phone.Length - 1);
    Console.WriteLine(person);


    Console.WriteLine("İşlem Başarılı oldu!");
}