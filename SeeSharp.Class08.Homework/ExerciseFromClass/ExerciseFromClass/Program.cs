namespace ExerciseFromClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("C# - Exercise from class");
            Console.WriteLine();

            /*
            Print the date that is 3 days from now
            Print the date that is one month from now
            Print the date that is one month and 3 days from now
            Print 1 year and 2 months ago from today
            Print only the current month of today
            Print only the current year of today
            */

            DateTime today = DateTime.Now;

            DateTime threeDays = today.AddDays(3);
            Console.WriteLine($"3 days from now: {threeDays.ToShortDateString()}");

            DateTime oneMonth = today.AddMonths(1);
            Console.WriteLine($"1 month from now: {oneMonth.ToShortDateString()}");

            DateTime oneMonthAndThreeDays = today.AddMonths(1).AddDays(3);
            Console.WriteLine($"1 month and 3 days from now: {oneMonthAndThreeDays.ToShortDateString()}");

            DateTime oneYearAndTwoMonthsAgo = today.AddYears(-1).AddMonths(-2);
            Console.WriteLine($"1 year and 2 months ago: {oneYearAndTwoMonthsAgo.ToShortDateString()}");

            int currentMonth = today.Month;
            Console.WriteLine($"Current month: {currentMonth}");

            int currentYear = today.Year;
            Console.WriteLine($"Current year: {currentYear}");

        }
    }
}
