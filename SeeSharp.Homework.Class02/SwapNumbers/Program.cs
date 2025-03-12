namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Homework | Class 02");
            Console.WriteLine();
            Console.WriteLine("Task 03: Swap Numbers");
            Console.WriteLine();

            /*
            Create new console application called “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:
            Test Data:
                Input the First Number: 5
                Input the Second Number: 8
            Expected Output:
                After Swapping:
                First Number: 8
                Second Number: 5
                string inputOne = Console.ReadLine();
                string inputTwo = Console.ReadLine();
            */

            Console.WriteLine("Please input 2 numbers of your choice. \nWe will try to swap those numbers.");
            Console.WriteLine();

            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();
            int inputThree = default;

            bool successOne = int.TryParse(inputOne, out int resultOne);
            bool successTwo = int.TryParse(inputTwo, out int resultTwo);


            if (successOne && successTwo)
            {
                Console.WriteLine($"You have picked {resultOne} and {resultTwo}");
                
                inputThree = resultOne;
                resultOne = resultTwo;
                resultTwo = inputThree;
                Console.WriteLine($"Here are your numbers in reversed order {resultOne} & {resultTwo}");

            }
        }
    }
}
