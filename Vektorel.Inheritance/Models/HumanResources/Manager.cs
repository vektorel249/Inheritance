using Vektorel.Inheritance.Abstractions;
using Vektorel.Inheritance.Models.Common;

namespace Vektorel.Inheritance.Models.HumanResources;

//: Employee => Inheritance, ICalculatable => interface implementation
internal class Manager : Employee, ICalculatable
{
    public Manager()
    {
        Targets = new List<Target>();
        ExpenseHistory = new List<Expense>();
    }
    public List<Target> Targets { get; set; }
    public decimal DailyExpenseLimit { get; set; }
    //Encapsulation
    public List<Expense> ExpenseHistory { get; set; }

    public decimal CalculateBonus()
    {
        throw new NotImplementedException();
    }

    public int CalculateVacationDays()
    {
        var year = DateTime.Now.Year - StartDate.Year;
        if (year > 4)
        {
            return year * 25;
        }
        return year * 15;
    }

    //PolyMorphism
    public override void PrintSalaryInformation()
    {
        Console.WriteLine($"Maaş ve Bonuslar ile :{Salary * 1.20}");
    }
}
