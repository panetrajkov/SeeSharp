namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Homework | Class 02");
            Console.WriteLine();

            Console.WriteLine("Task 02: Average Number");

            Console.WriteLine();

            /*
            Create new console application called “AverageNumber” that takes four numbers as input to calculate and print the average.

            Test Data:
            Enter the First number: 10
            Enter the Second number: 15
            Enter the third number: 20
            Enter the four number: 30
            Expected Output:
            The average of 10, 15, 20 and 30 is: 18
            */

            Console.WriteLine("Please pick 4 numbers. \nWe will calculate the average of those numbers.");

            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();
            string inputThree = Console.ReadLine();
            string inputFour = Console.ReadLine();
            
            bool successOne = int.TryParse(inputOne, out int resultOne);
            bool successTwo = int.TryParse(inputTwo, out int resultTwo);
            bool successThree = int.TryParse(inputThree, out int resultThree);
            bool successFour = int.TryParse(inputFour, out int resultFour);

            if (successOne && successTwo && successThree && successFour)
            {
                int result = (resultOne + resultTwo + resultThree + resultFour) / 4;
                Console.WriteLine($"The average of those four numbers is {result}");
            }
            else
            {
                Console.WriteLine("You haven't entered valid data");
            }
        }
    }
}
