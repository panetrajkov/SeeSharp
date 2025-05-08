using EmployeeProgram.Classes;

namespace EmployeeProgram.Models
{
    public class Manager : Employee
    {     
        public string Department { get; set; } = string.Empty;
        public int ManagedEmployees { get; set; } = 0;
        public int Bonus { get; set; } = 0;

        public Manager(string firstName, string lastName, int age, int baseSalary, string department, int managedEmployees, int bonus) : base(firstName, lastName, age, baseSalary)
        {
            Department = department;
            ManagedEmployees = managedEmployees;
            Bonus = bonus;
        }

        public Manager()
        {
        }        

        public override int CalculateSalary()
        {
            return BaseSalary + Bonus;
        }

        public override string DisplayInfo()
        {
            return $"{GetFullName()} is a manager in the {Department} department, and is managing {ManagedEmployees} employees. \nHe also makes {CalculateSalary()}.";
        }
    }
}
