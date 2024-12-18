using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekwill_2_2024
{
    internal class Tema14
    {
        public void RunMethod()
        {
            FullTimeEmployee fte = new FullTimeEmployee("John Doe", "FT123", 3000, 5000);
            PartTimeEmployee pte = new PartTimeEmployee("Jane Doe", "PT123", 20);

            fte.CalculateAnnualSalary(); 
            pte.CalculateAnnualSalary(); 
        }
    }


    public class Employee
    {
        public string name { get; set; }
        public string id { get; set; }
        public int salary { get; set; }

        public Employee(string Name, string Id, int Salary)
        {

            this.name = Name;
            this.id = Id;
            this.salary = Salary;
        }

        public virtual void CalculateAnnualSalary()
        {

            Console.WriteLine($"Salariul Anual: {salary * 12}");

        }

    }

    public class FullTimeEmployee : Employee
    {

        public int bonus { get; set; }
        public FullTimeEmployee(string Name, string Id, int Salary , int Bonus) : base(Name, Id, Salary)
        {

            bonus = Bonus;
        }

        public override void CalculateAnnualSalary()
        {
            int annualSalary = (salary * 12) + bonus;
            Console.WriteLine($"Salariul Anual al Angajatului Full-Time + Bonus: {annualSalary}");
        }
 
    }

    public class PartTimeEmployee : Employee 
    {
        public int hourlyRate { get; set; }

        public PartTimeEmployee(string Name , string Id , int HourlyRate) : base(Name, Id, 0)
        { 
            hourlyRate = HourlyRate;
        }

        public override void CalculateAnnualSalary()
        {
            int hoursPerMonth = 160;
            int annualSalary = hourlyRate * hoursPerMonth * 12;
            Console.WriteLine($"Salariul Angajatului Part-Time: {annualSalary}");
        }

    }


}
