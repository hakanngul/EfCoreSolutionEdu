using Microsoft.EntityFrameworkCore;

namespace EfCore.CodeFirst.DAL;

[Keyless]
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}