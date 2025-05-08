using UserDatabase.Models;


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("C# Homework | Class 03");
Console.WriteLine("===== Task 01 =====");
Console.ResetColor();
Console.WriteLine();

// Task 1
// Create class User that will have 3 properties Id, Name, Age.
// Create static class UserDatabase that will contain a list of Users (create couple of users and add them to the list).
// Create method (or methods) Search() that will search the UserDatabase by Id, Name and Age and will return users as a result.

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Searching predefined user");
Console.ResetColor();
Console.WriteLine();

User user = new User(5, "Petko", 15);
User user2 = new User(6, "Tino", 16);
User user3 = new User(7, "Milan", 17);

Database.Users.Add(user);
Database.Users.Add(user2);
Database.Users.Add(user3);

var Bob = Database.Search("Bob");
var Greg = Database.Search(2);
var Janice = Database.Search(3);
var Petko = Database.Search("15");
var Tino = Database.Search(16);
var Milan = Database.Search(17);

if (Database.Users.Count == 0)
{
    Console.WriteLine("No users found");
}
else
{
    Console.WriteLine("List of all available users");
    foreach (var foundUser in Database.Users)
    {
        Console.WriteLine(foundUser);
    }
}
    
