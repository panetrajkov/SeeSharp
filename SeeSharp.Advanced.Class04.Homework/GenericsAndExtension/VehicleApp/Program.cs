using VehicleApp.Models;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("C# Homework | Class 04");
Console.WriteLine("===== Task 02 =====");
Console.ResetColor();
Console.WriteLine();
/*
 * Task 02
Create a class Vehicle that has one method DisplayInfo().
Create class Car, MotorBike, Boat, Airplane that will inherit from Vehicle and will implement the respective method.
Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo()

// in console we should display
// Im a car and i drive on 4 wheels :)
// Im a motorbike and i drive on 2 wheels :)
// Im a boat and i do not have wheels :(
// Im a plane i have couple of wheels :)

*/

Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();
List<Vehicle> vehicles = new List<Vehicle> { car, motorBike, boat, plane };

Console.WriteLine(car.DisplayInfo());
Console.WriteLine(motorBike.DisplayInfo());
Console.WriteLine(boat.DisplayInfo());
Console.WriteLine(plane.DisplayInfo());

/*
 * Task 3
From the previous task get the implementation and DO NOT CHANGE the implementation of the classes.

Now we need to EXTEND the functionalities with a couple of methods:

Car objects should have Drive() method;
MotorBike should have Wheelie() method;
Boat should have Sail() method;
Airplane should have Fly() method;
*/

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("===== Task 03 =====");
Console.ResetColor();
Console.WriteLine();

foreach (Vehicle vehicle in vehicles)
{
    switch (vehicle)
    {
        case Car c:
            Console.WriteLine(c.Drive());
            break;
        case MotorBike m:
            Console.WriteLine(m.Wheelie());
            break;
        case Boat b:
            Console.WriteLine(b.Sail());
            break;
        case Airplane a:
            Console.WriteLine(a.Fly());
            break;
    }
}
Car car123 = new Car();
car123.Drive();

Boat boatie = new Boat();
boatie.Sail();

Airplane boeing = new Airplane();
boeing.Fly();

MotorBike cross = new MotorBike();
cross.Wheelie();

Console.WriteLine(boatie.Sail() + " | " + cross.Wheelie() + " | " + car123.Drive() + " | " + boeing.Fly());
