using System.Runtime.Intrinsics.X86;
using Vektorel.Inheritance.Enums;
using Vektorel.Inheritance.Models.HumanResources;
using Vektorel.Inheritance.Models.Mobility;

namespace Vektorel.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Developer sinan = new Developer();
            Developer sena = new Developer();
            Developer hasan = new Developer();

            Developer d1 = new()
            {
                IdentityNumber = 1,
                FirstName = "Mehmet",
                LastName = "Korkmaz",
                Salary = 1000,
                StartDate = new DateOnly(2016, 5, 12)
            };
          
            d1.Languages.Add(Language.CSharp);
            //if (d1.Languages != null)
            //{
            //    d1.Languages.Add(Language.CSharp);
            //}
            d1.Languages.Add(Language.JavaScript);

            d1.PrintInformation();
            d1.PrintSalaryInformation();

            var totalVacation = d1.CalculateVacationDays();


            HR h1 = new()
            {
                IdentityNumber = 4,
                FirstName = "Hale",
                LastName = "Yürekten",
                Salary = 900,
                StartDate = new DateOnly(2019, 8, 29)
            };

            h1.PrintInformation();
            h1.PrintSalaryInformation();

            Manager m1 = new()
            {
                IdentityNumber = 2,
                FirstName = "Ahmet",
                LastName = "Yılmaz",
                DailyExpenseLimit = 1200,
                Salary = 1200,
                Department = Department.Finance,
                StartDate = new DateOnly(2015, 1, 5)
            };
            m1.PrintInformation();
            m1.PrintSalaryInformation();

            

            Intern i1 = new()
            {
                FirstName = "Asel",
                LastName = "Yıldırım",
                StartDate = new DateOnly(2024, 7, 1),
                EndDate = new DateOnly(2024, 8, 4),
                Department = Department.IT,
                IdentityNumber = 3,
                Score = 82
            };
            i1.PrintInformation();
            i1.PrintSalaryInformation();

            //Developer d2;

            //-----
            h1.ResponsibleFor.Add(d1);
            //h1.ResponsibleFor.Add(d2);
            h1.ResponsibleFor.Add(i1);
            h1.ResponsibleFor.Add(m1);

            h1.CheckVacations();

            Bike b1 = new()
            {
                IdentityNumber = 1,
                HasBattery = true,
                Brand = "Bianchi",
                ModelYear = 2024,
                SeatCount = SeatCount.Single,
                TransmissionCount = 21,
            };

            //b1 burada Employee tipi ile bir bağıntısı olmadığında kullanılamaz
            //h1.ResponsibleFor.Add(b1);

            Sum(3, 5); // int verdik değerleri ama parametre long
        }

        static void Sum(long a, long b)
        {
            var c = a + b;
        }
    }
}


//ARAŞTIRIN
// Tightly Coupled
// Loosely Coupled