using EmployeeProgram.Models;
using System.ComponentModel;

Console.WriteLine("C# Homework | Class 02");
Console.WriteLine();
Console.WriteLine("===== Task 04 =====");
Console.WriteLine();

// Task 4:
// Write a program to create an abstract class Employee with abstract methods CalculateSalary() and DisplayInfo().
// Create subclasses Manager and Programmer that extend the Employee class and
// implement the respective methods to calculate salary and display information for each role.

Console.WriteLine("===== Manager Information =====");
Console.WriteLine();
Manager manager = new Manager("John", "Doe", 35, 5000, "IT", 12, 2500);
Console.WriteLine($"Manager info: {manager.DisplayInfo()}");

Console.WriteLine();
Console.WriteLine("===== Programmer Information =====");
Console.WriteLine();
Programmer programmer = new Programmer("Jane", "Smith", 29, 5000, 350, "C#", new List<string> { "Java", "Python", "C++" });
Console.WriteLine($"Programmer info: {programmer.DisplayInfo()}");