using Vektorel.Inheritance.Abstractions;
using Vektorel.Inheritance.Enums;

namespace Vektorel.Inheritance.Models.HumanResources;

internal class HR : Employee
{
    public HR()
    {
        Department = Department.HR;
        ResponsibleFor = new List<Employee>();
    }
    public List<Employee> ResponsibleFor { get; set; }
    public byte MonthlyMeetingCount { get; set; }

    public void CheckVacations()
    {
        foreach (var emp in ResponsibleFor)
        {
            if (emp is ICalculatable person)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} izin günü hakedişi : {person.CalculateVacationDays()}");
            }
        }
    }
}
