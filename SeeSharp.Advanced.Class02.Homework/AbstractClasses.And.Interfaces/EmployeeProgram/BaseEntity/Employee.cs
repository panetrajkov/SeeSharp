namespace EmployeeProgram.Classes
{
    public abstract class Employee
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; } = 0;
        public int BaseSalary { get; set; } = 0;


        public Employee(string firstName, string lastName, int age, int baseSalary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            BaseSalary = baseSalary;
        }

        public Employee()
        {

        }

        public abstract int CalculateSalary();
        public abstract string DisplayInfo();

        public string GetFullName()
        {
            return $"{FirstName} {LastName}, ({Age})";
        }
    }
}
