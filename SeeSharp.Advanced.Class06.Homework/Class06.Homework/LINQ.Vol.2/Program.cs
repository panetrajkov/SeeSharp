using LINQ.Vol._2.Models;

/*
    Practice LINQ Vol. 2 🏋️‍♂️

    1. Filter all cars that have origin from Europe.
    2. Find all unique cylinder values for cars.
    3. Select all car names with their model names converted to uppercase.
    4. Check if there are any cars with horsepower greater than 300.
    5. Find the car with the highest horsepower.
    6. Filter all "Chevrolet" cars and order them by weight in descending order.
    7. Find the car with the longest model name.
    8. Group cars by their origin and then order the groups by the number of cars in each group, in ascending order.
    9. Find the first 5 cars with the highest horsepower. (hint: read about LINQ methods Skip() and Take())
    10. Find the car with the highest acceleration time.
    11. Select only the model and horsepower of cars with horsepower greater than 200.
    12. Select all unique origins of cars, ordered alphabetically (ascending).
    13. Select all cars with more than 4 cylinders, and order them by origin and then by horsepower.
    14. Filter all cars that have more than 6 Cylinders not including 6 after that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result.
    15. Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highest and average Miles per galon for these cars.
    16. Be creative and write requirement of your own choice :) (only one catch, must use at least 3 LINQ methods)
    17. Be creative and write requirement of your own choice :) (only one catch, must use at least 3 LINQ methods)

*/

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("C# Homework | Class 06");
Console.ResetColor();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("===== LINQ Vol. 2 =====");
Console.ResetColor();
Console.WriteLine();

// 1. Filter all cars that have origin from Europe.
var carsFromEurope = CarsData.Cars.Where(car => car.Origin == "Europe").ToList();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Cars from Europe:");
Console.ResetColor();
Console.WriteLine();
foreach (var car in carsFromEurope)
{
    Console.WriteLine($"{car.Model} - {car.Origin}");
}

Console.WriteLine();

// 2. Find all unique cylinder values for cars.
var uniqueCylinderValues = CarsData.Cars.Select(car => car.Cylinders).Distinct().ToList();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Unique Cylinder Values: ");
Console.ResetColor();
Console.WriteLine();
foreach (var cylinder in uniqueCylinderValues)
{
    Console.WriteLine(cylinder);
}

Console.WriteLine();

// 3. Select all car names with their model names converted to uppercase.

var carNamesUpperCase = CarsData.Cars.Select(car => car.Model.ToUpper()).ToList();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Car names with their model names converted to uppercase:");
Console.ResetColor();
Console.WriteLine();
foreach (var car in carNamesUpperCase)
{
    Console.WriteLine(car);
}

Console.WriteLine();

// 4. Check if there are any cars with horsepower greater than 300.

var horsePowerGreaterThan300 = CarsData.Cars.Any(CarsData => CarsData.HorsePower > 300);
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Cars with HP > 300.");
Console.ResetColor();
Console.WriteLine();
Console.WriteLine(horsePowerGreaterThan300 ? "Yes" : "No");
Console.WriteLine();

// 5. Find the car with the highest horsepower.

var carWithHighestHorsePower = CarsData.Cars.OrderByDescending(car => car.HorsePower).FirstOrDefault();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine();
Console.WriteLine("Car with the highest HP:");
Console.ResetColor();
Console.WriteLine();
Console.WriteLine($"{carWithHighestHorsePower.Model} - {carWithHighestHorsePower.HorsePower} HP");

Console.WriteLine();

// 6. Filter all "Chevrolet" cars and order them by weight in descending order.

var chevroletCars = CarsData.Cars
    .Where(car => car.Model.Contains("Chevrolet"))
    .OrderByDescending(car => car.Weight)
    .ToList();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Chevrolet cars ordered by weight in descending order:");
Console.ResetColor();
Console.WriteLine();
foreach (var car in chevroletCars)
{
    Console.WriteLine($"{car.Model} - {car.Weight} kg");
}

// 7. Find the car with the longest model name.

var carWithTheLongestModelName = CarsData.Cars.OrderByDescending(car => car.Model.Length).FirstOrDefault();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine();
Console.WriteLine("Car with the longest model name:");
Console.ResetColor();
Console.WriteLine();
Console.WriteLine($"{carWithTheLongestModelName.Model} - {carWithTheLongestModelName.Model.Length} characters");
Console.WriteLine();

// 8. Group cars by their origin and then order the groups by the number of cars in each group, in ascending order.

var groupedCarsByOrigin = CarsData.Cars
    .GroupBy(car => car.Origin)
    .OrderBy(CarsData => CarsData.Count())
    .ToList();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine();
Console.WriteLine("Grouped cars by origin ordered by the number of cars in each group:");
Console.ResetColor();
Console.WriteLine();
foreach (var car in groupedCarsByOrigin)
{
    Console.WriteLine($"{car.Key} - {car.Count()} cars");
}
Console.WriteLine();

// 9. Find the first 5 cars with the highest horsepower.

var topFiveCarsByHorsePower = CarsData.Cars
    .OrderByDescending(car => car.HorsePower)
    .Take(5)
    .ToList();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Top 5 cars with the highest horsepower:");
Console.ResetColor();
Console.WriteLine();
foreach (var car in topFiveCarsByHorsePower)
{
    Console.WriteLine($"{car.Model} - {car.HorsePower} HP");
}

Console.WriteLine();

// 10.Find the car with the highest acceleration time.

var carWithHighestAccelerationTime = CarsData.Cars.OrderByDescending(car => car.AccelerationTime).FirstOrDefault();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Car with the highest acceleration time:");
Console.ResetColor();
Console.WriteLine();
Console.WriteLine($"{carWithHighestAccelerationTime.Model} - {carWithHighestAccelerationTime.AccelerationTime} seconds");

Console.WriteLine();

// 11. Select only the model and horsepower of cars with horsepower greater than 200.

var onlyModelAndHorsePower = CarsData.Cars
    .Where(car => car.HorsePower > 200)
    .Select(car => (car.Model, car.HorsePower))
    .ToList();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Model of car with HP greater than 200:");
Console.ResetColor();
Console.WriteLine();

foreach (var car in onlyModelAndHorsePower)
{
    Console.WriteLine($"{car.Model} - {car.HorsePower} HP");
}

// 12. Select all unique origins of cars, ordered alphabetically (ascending).

var uniqueOrigins = CarsData.Cars
    .Select(car => car.Origin)
    .Distinct()
    .OrderBy(origin => origin)
    .ToList();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine();
Console.WriteLine("Unique origins of cars ordered alphabetically:");
Console.ResetColor();
Console.WriteLine();

foreach (var origin in uniqueOrigins)
{
    Console.WriteLine(origin);
}

Console.WriteLine();

// 13. Select all cars with more than 4 cylinders, and order them by origin and then by horsepower.

var carsWithMoreThanFourCylinders = CarsData.Cars
    .Where(car => car.Cylinders > 4)
    .OrderBy(car => car.Origin)
    .ThenByDescending(car => car.HorsePower)
    .ToList();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Cars with more than 4 cylinders ordered by origin and then by horsepower:");
Console.ResetColor();
Console.WriteLine();
foreach (var car in carsWithMoreThanFourCylinders)
{
    Console.WriteLine($"{car.Model} - {car.Origin} - {car.HorsePower} HP");
}

Console.WriteLine();

// 14. Filter all cars that have more than 6 Cylinders not including 6 after that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result.

var filteredCars = CarsData.Cars
    .Where(car => car.Cylinders > 6 || (car.Cylinders == 4 && car.HorsePower > 110))
    .ToList();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Filtered cars with more than 6 cylinders or exactly 4 cylinders with HP > 110:");
Console.ResetColor();
Console.WriteLine();
foreach (var car in filteredCars)
{
    Console.WriteLine($"{car.Model} - {car.Cylinders} Cylinders - {car.HorsePower} HP");
}

// 15. Filter all cars that have more than 200 HorsePower and Find out how much is the lowest, highest and average Miles per gallon for these cars.

var carsWithMoreThan200HorsePower = CarsData.Cars
    .Where(car => car.HorsePower > 200)
    .ToList();

var lowestMilesPerGallon = carsWithMoreThan200HorsePower.Min(car => car.MilesPerGalon);

var highestMilesPerGallon = carsWithMoreThan200HorsePower.Max(car => car.MilesPerGalon);

var averageMilesPerGallon = carsWithMoreThan200HorsePower.Average(car => car.MilesPerGalon);

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine();
Console.WriteLine("Cars with more than 200 HorsePower:");
Console.WriteLine();
Console.ResetColor();
foreach (var car in carsWithMoreThan200HorsePower)
{
    Console.WriteLine($"{car.Model} - {car.HorsePower} HP - {car.MilesPerGalon} MPG");
}

Console.WriteLine();
Console.WriteLine($"Lowest Miles per gallon: {lowestMilesPerGallon}");
Console.WriteLine($"Highest Miles per gallon: {highestMilesPerGallon}");
Console.WriteLine($"Average Miles per gallon: {averageMilesPerGallon}");

//    16. Be creative and write requirement of your own choice :) (only one catch, must use at least 3 LINQ methods)

var requirementOfChoice = CarsData.Cars.Where(car => car.Origin == "Europe")
    .Select(CarsData => new { CarsData.Model, CarsData.HorsePower })
    .OrderByDescending(car => car.HorsePower).ToList();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Cars from Europe with their model and horsepower:");
Console.ResetColor();
Console.WriteLine();

foreach (var car in requirementOfChoice)
{
    Console.WriteLine($"{car.Model} - {car.HorsePower} HP");
}

Console.WriteLine();

// 17. Be creative and write requirement of your own choice :) (only one catch, must use at least 3 LINQ methods)

var requirementOfChoice2 = CarsData.Cars
    .Where(car => car.Origin == "US" && car.HorsePower > 150)
    .Select(car => new { car.Model, car.HorsePower, car.Weight, car.AccelerationTime })
    .OrderByDescending(car => car.HorsePower).ToList();

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Cars from USA with HorsePower > 150, their model, horsepower, weight and acceleration time:");
Console.ResetColor();
Console.WriteLine();

foreach (var car in requirementOfChoice2)
{
    Console.WriteLine($"{car.Model} - {car.HorsePower} HP - {car.Weight} kg - {car.AccelerationTime} seconds");
}