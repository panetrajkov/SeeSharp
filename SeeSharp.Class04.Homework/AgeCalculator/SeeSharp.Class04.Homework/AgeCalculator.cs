using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SeeSharp.Class04.Homework
{
    internal class AgeCalculator
    {

        //        Make a method called AgeCalculator
        //        The method will have one input parameter, your birthday date
        //        The method should return your age
        //        Show the age of a user after he inputs a date
        //        Note: take into consideration if the birthday is today, after or before today



        static int AgeCalculator(DateTime birthday)
        {
            DateTime timeNow = DateTime.Now;
            int age = timeNow.Year - birthday.Year - 1;

            int month = timeNow.Month - birthday.Month;
            if (month > 0) 
            {
                age++;
            }

            int day = timeNow.Day;
            int birthdayDay = birthday.Day;
            int tmp = day - birthdayDay;

            if (month == 0 && tmp >= 0)
            {
                age++;
            }

            return age;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter your birthday in format 'dd-MM-yyyy'");
            string userInput = Console.ReadLine();
            if (DateTime.TryParse(userInput, out DateTime birthday))
            {
                int age = AgeCalculator(birthday);
                Console.WriteLine("The age of the user is: " + age);
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter a valid date in 'dd-MM-yyyy' format.");
            }
        }

    }
}
