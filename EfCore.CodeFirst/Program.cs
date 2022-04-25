// See https://aka.ms/new-console-template for more information

using Bogus;
using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var context = new AppDbContext())
{
    // context.Persons.Add(new Manager() {FirstName = "M1", LastName = "m2", Age = 22, Grade = 1});
    // context.Employees.Add(new Employee() {FirstName = "E1", LastName = "e2", Age = 32,});
    // context.SaveChanges();
    var manager = context.Managers.ToList();
    var employees = context.Employees.ToList();
    var persons = context.Persons.ToList();
    
    persons.ForEach(p =>
    {
        switch (p)
        {
            case Manager manager:
                Console.WriteLine($"Manager => {manager.Grade} - {manager.FirstName} - {manager.LastName} - {manager.Age}");
                break;
            case Employee employee:
                Console.WriteLine($"Employee => {employee.Salary} - {employee.FirstName} - {employee.LastName} - {employee.Age}");
                break;
            default:
                break;
        }
    });
    
    
    Console.WriteLine("İşlem Başarılı oldu!");
}