namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Homework | Class 03");
            Console.WriteLine();
            Console.WriteLine("Task 02: StudentGroup");
            Console.WriteLine();

            /*
                Make a new console application called StudentGroup

                Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
                Get a number from the console between 1 and 2 and print the students from that group in the console.
                Example: studentsG1 ["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
                Test Data:
                Enter student group: ( there are 1 and 2 )
                1
                Expected Output:
                The Students in G1 are:
                Zdravko
                Petko
                Stanko
                Branko
                Trajko
            */

            string[] studentArr1 = { "Ace", "Mace", "Dace", "Vace", "Bace" };
            string[] studentArr2 = { "Stojan", "Bojan", "Vojdan", "Momir", "Vasko" };

            while (true)
            {            
                Console.WriteLine("Please select number 1 or number 2 on your keyboard");
                Console.WriteLine();

                string input = Console.ReadLine();
                bool success = int.TryParse(input, out int parsedInput);

                if (parsedInput != 1 && parsedInput != 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid option. Pick a number again.");
                    continue;
                }
                else if (parsedInput == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("The name of the students are:");
                    foreach (string student in studentArr1)
                    {
                        Console.WriteLine(student);
                    }
                }
                else if (parsedInput == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("The name of the students are:");
                    foreach (string student in studentArr2)
                    {
                        Console.WriteLine(student);
                    }
                }
                break;
            }
        }
    }
}
