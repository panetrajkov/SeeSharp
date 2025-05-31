using LINQ.Vol._3.Models;

/*
    **** REQUIREMENTS ****

    1. Select the horsepower of US cars with more than 150 horsepower.
    2. Select the weight of European cars with less than 100 horsepower.
    3. Select the origin of Japanese cars that weight less than 2200.
    4. Select the cylinder count of US cars with exactly 8 cylinders.
    5. Select the miles per gallon of cars with more than 25 miles per gallon and acceleration time over 15 seconds.
    6. Get the acceleration time of the last 4-cylinder car with acceleration time less than 15 seconds.
    7. Get the model name of the first car that has 0 horsepower.
    8. Get the weight of the last Japanese car with more than 90 horsepower.
    9. Get the horsepower of the first US car that weights more than 4000 and has fewer than 6 cylinders.
    10. Get the origin of the last car with acceleration time greater than 20 seconds.

 */

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("C# Homework | Class 08");
Console.ResetColor();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("===== LINQ Vol. 3 =====");
Console.ResetColor();
Console.WriteLine();

// 1. Select the horsepower of US cars with more than 150 horsepower.

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("1. Select the horsepower of US cars with more than 150 horsepower.");
Console.ResetColor();
Console.WriteLine();

var hpOfUsCars = CarsData.Cars
    .Where(car => car.Origin == "US" && car.HorsePower > 150);

foreach (var car in hpOfUsCars)
{
    Console.WriteLine($"Horsepower of US car: {car.HorsePower}");
}

Console.WriteLine();

// 2.Select the weight of European cars with less than 100 horsepower.

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("2. Select the weight of European cars with less than 100 horsepower.");
Console.ResetColor();
Console.WriteLine();

var weightOfEuropeanCars = CarsData.Cars
    .Where(car => car.Origin == "Europe" && car.HorsePower < 100);

foreach (var car in weightOfEuropeanCars)
{
    Console.WriteLine($"Weight of European car: {car.Weight} kg - {car.HorsePower} HP.");
}

Console.WriteLine();

// 3. Select the origin of Japanese cars that weight less than 2200.

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("3. Select the origin of Japanese cars that weight less than 2200.");
Console.ResetColor();
Console.WriteLine();

var originOfJapaneseCars = CarsData.Cars.
    Where(car => car.Origin == "Japan" && car.Weight < 2200);

foreach (var car in originOfJapaneseCars)
{
    Console.WriteLine($"Origin of cars made in {car.Origin} that weight less than 2200 => {car.Weight} kg.");
}

Console.WriteLine();

// 4. Select the cylinder count of US cars with exactly 8 cylinders.

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("4. Select the cylinder count of US cars with exactly 8 cylinders.");
Console.ResetColor();
Console.WriteLine();

var cylinderCountOfUsCars = CarsData.Cars
    .Where(car => car.Origin == "US" && car.Cylinders == 8);

foreach (var car in cylinderCountOfUsCars)
{
    Console.WriteLine($"Cylinder count of {car.Origin} car with {car.Cylinders} cylinders: ");
    Console.WriteLine($"Model: {car.Model}");
}

Console.WriteLine();

// 5. Select the miles per gallon of cars with more than 25 miles per gallon and acceleration time over 15 seconds.

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("5. Select the miles per gallon of cars with more than 25 miles per gallon and acceleration time over 15 seconds.");
Console.ResetColor();
Console.WriteLine();

var MilesPerGallonOfCars = CarsData.Cars
    .Where(car => car.MilesPerGalon > 25 && car.AccelerationTime > 15);

foreach (var car in MilesPerGallonOfCars)
{
    Console.WriteLine($"Miles per gallon of car with {car.MilesPerGalon} mpg and acceleration time of {car.AccelerationTime} seconds.");
    Console.WriteLine($"{car.Model} - {car.AccelerationTime} seconds - {car.MilesPerGalon} mpg.");
}

Console.WriteLine();

// 6. Get the acceleration time of the last 4-cylinder car with acceleration time less than 15 seconds.

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("6. Get the acceleration time of the last 4-cylinder car with acceleration time less than 15 seconds.");
Console.ResetColor();
Console.WriteLine();

var lastFourCylinderCar = CarsData.Cars
    .Where(car => car.Cylinders == 4 && car.AccelerationTime < 15)
    .LastOrDefault();

Console.WriteLine(lastFourCylinderCar.AccelerationTime + " seconds.");
Console.WriteLine($"Model: {lastFourCylinderCar.Model}");

Console.WriteLine();

// 7. Get the model name of the first car that has 0 horsepower.

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("7. Get the model name of the first car that has 0 horsepower.");
Console.ResetColor();
Console.WriteLine();

var firstCarWithZeroHorsePower = CarsData.Cars
    .FirstOrDefault(car => car.HorsePower == 0);

Console.WriteLine($"Model of the first car with 0 horsepower: {firstCarWithZeroHorsePower.Model}");

Console.WriteLine();

// 8. Get the weight of the last Japanese car with more than 90 horsepower.

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("8. Get the weight of the last Japanese car with more than 90 horsepower.");
Console.ResetColor();
Console.WriteLine();

var lastJapaneseCarWithMoreThan90HP = CarsData.Cars
    .Where(car => car.Origin == "Japan" && car.HorsePower > 90)
    .LastOrDefault();

Console.WriteLine($"Weight of the last car from {lastJapaneseCarWithMoreThan90HP.Origin} with more than 90 horsepower: {lastJapaneseCarWithMoreThan90HP.Weight} kg.");

Console.WriteLine();

// 9. Get the horsepower of the first US car that weights more than 4000 and has fewer than 6 cylinders.

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("9. Get the horsepower of the first US car that weights more than 4000 and has fewer than 6 cylinders.");
Console.ResetColor();
Console.WriteLine();

var firstUsCarWithWeightAnd6Cylinders = CarsData.Cars.Where(car => car.Origin == "US" && car.Weight > 4000 && car.Cylinders < 6)
    .Select(car => car.HorsePower);
Console.WriteLine(firstUsCarWithWeightAnd6Cylinders.Count() == 0 ? "No such car found." : "Horsepower of the first US car that weights more than 4000 kg and has fewer than 6 cylinders: " + firstUsCarWithWeightAnd6Cylinders.FirstOrDefault());
Console.WriteLine();

// 10. Get the origin of the last car with acceleration time greater than 20 seconds.

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("10. Get the origin of the last car with acceleration time greater than 20 seconds.");
Console.ResetColor();
Console.WriteLine();

var lastCarWithAccelerationTimeGreaterThan20 = CarsData.Cars
    .Where(car => car.AccelerationTime > 20)
    .LastOrDefault();

Console.WriteLine($"Origin of the last car with acceleration time greater than 20 seconds: {lastCarWithAccelerationTimeGreaterThan20.Origin}");