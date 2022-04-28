// See https://aka.ms/new-console-template for more information

using Bogus;
using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var context = new AppDbContext())
{

    context.Employees.Add(new Employee()
    {
        FirstName = "Employee2", LastName = "eMp2", Age = 22,Salary = 3000
    });

    context.Managers.Add(new Manager()
    {
        FirstName = "Managers2", LastName = "mN2", Age = 36, Grade = 6
    });


    context.SaveChanges();
    Console.WriteLine("İşlem Başarılı oldu!");
}