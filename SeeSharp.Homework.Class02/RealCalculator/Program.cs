namespace SeeSharp.Homework.Class02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Homework | Class 02");
            Console.WriteLine();
            Console.WriteLine("Task 01: Real Calculator");
            Console.WriteLine();

            /*
            Create new console application called“RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.

            Test Data:
            Enter the First number: 10
            Enter the Second number: 15
            Enter the Operation: +

            Expected Output:
            The result is: 25
            */

            Console.WriteLine("Please pick two numbers");
            string userInput = Console.ReadLine();
            string userInputTwo = Console.ReadLine();

            bool success = int.TryParse(userInput, out int result);
            bool successTwo = int.TryParse(userInputTwo, out int resultTwo);

            Console.WriteLine("What kind of operation would you want to be done? \nOptions: + ; - ; * ; /");
            string arithmeticInput = Console.ReadLine();

            if (arithmeticInput != "+" && arithmeticInput != "-" && arithmeticInput != "*" && arithmeticInput != "/")
            {
                Console.WriteLine("Invalid option");
            }
            else if (arithmeticInput == "+")
            {
                Console.WriteLine("Result: " + (result + resultTwo));
            }
            else if (arithmeticInput == "-")
            {
                Console.WriteLine("Result: " + (result - resultTwo));
            }
            else if (arithmeticInput == "*")
            {
                Console.WriteLine("Result: " + (result * resultTwo));
            }
            else if (arithmeticInput == "/")
            {
                if (resultTwo != 0)
                {
                    Console.WriteLine("Result: " + (result / resultTwo));
                }
                else
                {
                    Console.WriteLine("We don't want to divide with 0.");
                }
            }
        }
    }
}
