using Vektorel.Inheritance.Enums;
using Vektorel.Inheritance.Providers;

namespace Vektorel.Inheritance.Models.HumanResources;

internal abstract class Employee : Identity
{
    protected Employee()
    {
        Prefix = "EMP";
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Department Department { get; set; }
    public double Salary { get; set; }
    public DateOnly StartDate { get; init; }

    public void PrintInformation()
    {
        Console.WriteLine($"{Label} - {FirstName} {LastName}");
    }

    public virtual void PrintSalaryInformation()
    {
        Console.WriteLine($"Maaş {Salary}");
    }
}