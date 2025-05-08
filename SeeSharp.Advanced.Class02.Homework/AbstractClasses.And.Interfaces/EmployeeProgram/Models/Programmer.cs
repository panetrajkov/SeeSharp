using EmployeeProgram.Classes;

namespace EmployeeProgram.Models
{
    public class Programmer : Employee
    {
        public List<string> ProgrammingLanguages { get; set; } = new List<string>();
        public string MainLanguage { get; set; } = string.Empty;
        public int BaseSalary { get; set; } = 0;
        public int LanguageBonus { get; set; } = 0;

        public Programmer(string firstName, string lastName, int age, int baseSalary, int languageBonus, string mainLanguage, List<string> programmingLanguages)
     : base(firstName, lastName, age, baseSalary)
        {
            LanguageBonus = languageBonus;
            MainLanguage = mainLanguage;
            ProgrammingLanguages = programmingLanguages;
        }


        public Programmer()
        {
        }

        public override int CalculateSalary()
        {
            return BaseSalary + (LanguageBonus * ProgrammingLanguages.Count);
        }

        public override string DisplayInfo()
        {
            return $"{GetFullName()} is a programmer. \nHe knows the following programming languages: {string.Join(", ", ProgrammingLanguages)}. \nHis main language is {MainLanguage}.\nHe also earns {CalculateSalary()}.";
        }
    }
}
