namespace HomeworkClass05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*
             Make a class Driver. Add properties: Name, Skill
             Make a class Car. Add properties: Model, Speed and Driver
             Make a method of the Car class called : CalculateSpeed() that takes a driver object and calculates the skill multiplied by the speed of the car and return it as a result.
             Make a method RaceCars() that will get two Car objects that will determine which car will win and print the result in the console.
             Make 4 car objects and 4 driver objects.
             Ask the user to select a two cars and two drivers for the cars. Add the drivers to the cars and call the RaceCars() methods
             
             Test Data:
             Choose a car no.1: Hyundai; Mazda; Ferrari; Porsche
             Choose Driver: Bob; Greg; Jill; Anne

             Choose a car no.2: Hyundai; Mazda; Ferrari; Porsche
             Choose Driver: Bob; Greg; Jill; Anne

             Expected Output:
             Car no. 2 was faster.

             BONUS 1: If a user chooses option one for the first care, eliminate that option when the user picks car two.
             BONUS 2: Make the Output message say what was the model of the car that won, what speed was it going and which driver was driving it.
             BONUS 3: Implement a Race Again Feature where you ask the user if he wants to race again and repeat the racing function.
            */


            string[] carModels = { "Hyundai", "Mazda", "Ferrari", "Porsche" };
            string[] driverNames = { "Bob", "Greg", "Jill", "Anne" };

            Car CarOne = new Car();
            Car CarTwo = new Car();
            Car CarThree = new Car();
            Car CarFour = new Car();
            Driver DriverOne = new Driver("Bob", 2);
            Driver DriverTwo = new Driver("Greg", 3);
            Driver DriverThree = new Driver("Jill", 4);
            Driver DriverFour = new Driver("Anne", 5);
            Driver[] drivers = { DriverOne, DriverTwo, DriverThree, DriverFour };

            bool newRace = true;

            while (newRace)
            {
                Console.WriteLine("Choose a value 1-4 for your first car:");

                for (int i = 0; i < carModels.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {carModels[i]}");
                }
                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out int result);
                CarOne.Model = carModels[result - 1];
                Console.WriteLine("Choose a value 1-4 to pick a driver:");
                for (int i = 0; i < driverNames.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {driverNames[i]}");
                }
                input = Console.ReadLine();
                isValid = int.TryParse(input, out result);
                CarOne.Driver = drivers[result - 1];

                for (int i = 0; i < carModels.Length; i++)
                {
                    if (carModels[i] != CarOne.Model)
                    {
                        Console.WriteLine($"{i + 1}. {carModels[i]}");
                    }
                }



                Console.WriteLine("Choose a value from the available options for your second car:");
                input = Console.ReadLine();
                isValid = int.TryParse(input, out result);
                CarTwo.Model = carModels[result - 1];
                Console.WriteLine("Choose a value from the available options to pick the second driver:");
                input = Console.ReadLine();
                isValid = int.TryParse(input, out result);
                CarTwo.Driver = drivers[result - 1];
                CarOne.RaceCars(CarOne, CarTwo);

                Console.WriteLine("Race again? (Y/N)");
                string newRaceInput = Console.ReadLine().ToLower();
                newRace = newRaceInput == "y";

            }



           







        }
    }
}
