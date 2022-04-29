using Microsoft.EntityFrameworkCore;

namespace EfCore.CodeFirst.DAL;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}