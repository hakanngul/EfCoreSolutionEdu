using Microsoft.EntityFrameworkCore;

namespace EfCore.CodeFirst.DAL;

public class Employee: BasePerson
{
    [Precision(18,2)]
    public decimal Salary { get; set; }
}