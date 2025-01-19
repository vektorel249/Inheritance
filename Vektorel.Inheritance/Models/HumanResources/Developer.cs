using Vektorel.Inheritance.Abstractions;
using Vektorel.Inheritance.Enums;

namespace Vektorel.Inheritance.Models.HumanResources;

internal class Developer : Employee, ICalculatable
{
    public Developer()
    {
        Department = Department.IT;
        Languages = new List<Language>();
    }
    //Encapsulation
    public List<Language> Languages { get; set; }

    public decimal CalculateBonus()
    {
        throw new NotImplementedException();
    }

    public int CalculateVacationDays()
    {
        var year = DateTime.Now.Year - StartDate.Year;
        if (year > 5)
        {
            return year * 20;
        }
        return year * 10;
    }
}
