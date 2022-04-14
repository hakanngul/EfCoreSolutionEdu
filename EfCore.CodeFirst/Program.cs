// See https://aka.ms/new-console-template for more information

using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var context = new AppDbContext())
{
    Console.WriteLine("Program Cs Başlatıldı...");

    // var student = new Student() { Name = "Ahmet", Age = 25};
    // student.Teachers.Add(new (){Name = "Ahmet Öğretmen"});
    // student.Teachers.Add(new(){Name = "Mehmet Öğretmen"});
    // context.Add(student);
    // var teacher = new Teacher()
    // {
    //     Name = "Hasan Öğretmen", Students = new()
    //     {
    //         new Student(){Name = "Ali", Age = 23},
    //         new Student(){Name = "Veli", Age = 22}
    //     }
    // };
    // context.Add(teacher);

    var teacher = context.Teachers.First(x => x.Name == "Hasan Öğretmen");
    teacher.Students.Add(new Student() {Name = "Burcu", Age = 21});
    teacher.Students.Add(new Student(){Name = "Selin", Age = 23});

    context.SaveChanges();
    Console.WriteLine("Kayıt Başarılı oldu!");
}