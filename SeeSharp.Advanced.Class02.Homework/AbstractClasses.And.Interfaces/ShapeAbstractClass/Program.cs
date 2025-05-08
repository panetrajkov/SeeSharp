using ShapeAbstractClass.Classes;

Console.WriteLine("C# Homework | Class 02");
Console.WriteLine();
Console.WriteLine("===== Task 03 =====");
Console.WriteLine();

// Task 3:
// Write a program to create an abstract class Shape with abstract methods CalculateArea() and CalculatePerimeter().
// Create subclasses Circle and Triangle that extend the Shape class and implement the respective methods to calculate the area and perimeter of each shape.

Circle circle = new Circle();
Console.WriteLine("Calculate the area of the circle");
Console.WriteLine();
circle.CalculateArea();
Console.WriteLine();
Console.WriteLine("Calculate the perimeter of the circle");
Console.WriteLine();
circle.CalculatePerimeter();

Triangle triangle = new Triangle();
Console.WriteLine("Calculate the area of the triangle");
Console.WriteLine();
triangle.CalculateArea();
Console.WriteLine();
Console.WriteLine("Calculate the perimeter of the triangle");
Console.WriteLine();
triangle.CalculatePerimeter();