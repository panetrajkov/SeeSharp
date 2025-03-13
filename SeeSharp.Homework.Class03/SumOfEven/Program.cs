namespace SeeSharp.Homework.Class02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Homework | Class 03");
            Console.WriteLine();
            Console.WriteLine("Task 01: SumOfEven");
            Console.WriteLine();

            /*
             Make a console application called SumOfEven. Inside it create an array of 6 integers.
             Get numbers from the input, find and print the sum of the even numbers from the array:
            
            USE FOR LOOP
            * Test Data:
              * Enter integer no.1:
                * 4
              * Enter integer no.2:
                * 3
              * Enter integer no.3:
                * 7
              * Enter integer no.4:
                * 3
              * Enter integer no.5:
                * 2
              * Enter integer no.6:
                * 8
            * Expected Output:
              * The result is: 14
            */

            int[] intArray = new int[6];
            int i = 0;

            while (true)
            {
                while (i < 6)
                {
                    Console.WriteLine("Enter a number:");
                    string input = Console.ReadLine();

                    bool success = int.TryParse(input, out int value);

                    if (success)
                    {
                        intArray[i] = value;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                        continue;
                    }                                       
                }

                int result = 0;
                for (int j = 0; j < intArray.Length; j++)
                {
                    if (intArray[j] % 2 == 0)
                    {
                        result += intArray[j];
                    }
                }
                Console.WriteLine($"The result is {result}");



                Console.WriteLine("Do you want to exit the app? (Y/N)");
                string exitAnswer = Console.ReadLine();

                if (exitAnswer == "Y" || exitAnswer == "y")
                {
                    Console.WriteLine("Closing the app...");
                    break;
                }
                else
                {
                    Console.WriteLine("Restarting the app...");
                    i = 0;
                }

            }

        }
    }
}
