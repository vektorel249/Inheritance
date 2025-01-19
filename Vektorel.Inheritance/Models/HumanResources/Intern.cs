namespace Vektorel.Inheritance.Models.HumanResources;

internal class Intern : Employee
{
    public DateOnly EndDate { get; set; }
    public double Score { get; set; }
    public bool IsAbleToWorkAfterCompletion
    {
        get
        {
            return Score > 80;
        }
    }

    public override void PrintSalaryInformation()
    {
        Console.WriteLine("Stajyerler için bir ödeme planı bulunmamaktadır");
    }
}