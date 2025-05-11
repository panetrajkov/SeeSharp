using PrintInConsoleApp.Helpers;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("C# Homework | Class 04");
Console.WriteLine("===== Task 01 =====");
Console.ResetColor();
Console.WriteLine();

// Task 01
// Create class PrintInConsole that will have multiple methods to print in console: Print(), PrintCollection().
// Make these methods to be valid for more than one type and use them accordingly with different types.

PrintInConsoleApp.Helpers.PrintInConsole printInConsole = new PrintInConsoleApp.Helpers.PrintInConsole();
printInConsole.Print("Hey there!");
printInConsole.Print(1234567890);
printInConsole.Print(bool.Parse("true"));
var printableList = new object[] { 123, 456, "Hehe", "Haha", true, false };
printInConsole.PrintCollection(printableList.ToList());