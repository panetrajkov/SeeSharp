using System.Text;

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("C# Homework | Class 09");
Console.ResetColor();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("===== Working with File System =====");
Console.ResetColor();
Console.WriteLine();


#region Task 1 - Create a folder and a file
/*
    *** Task 1
    Create a folder named "Files".
    Create a file name "names.txt" 
*/

//string relativePath = @"Files/names.txt";
string relativeFolderPath = @"../../../Files";

bool folderExists = Directory.Exists(relativeFolderPath);
Console.WriteLine($"Folder exists: {folderExists}");

Console.WriteLine();

if (!folderExists)
{
    Directory.CreateDirectory(relativeFolderPath);
    Console.WriteLine($"Folder '{relativeFolderPath}' created successfully.");
}
else
{
    Console.WriteLine($"Folder '{relativeFolderPath}' already exists.");
}

relativeFolderPath = @"../../../Files";
string fileName = "names.txt";

string relativeFilePath = Path.Combine(relativeFolderPath, fileName);

bool fileExists = File.Exists(relativeFilePath);
Console.WriteLine($"File exists: {relativeFilePath}");

if (!fileExists)
{
    File.Create(fileName).Close();
    Console.WriteLine($"File '{fileName}' created successfully.");
}
else
{
    Console.WriteLine($"File '{fileName}' already exists.");
}

#endregion

#region Task 2 - Write to the file
/*
    *** Task 2
    Write the names of your friends to the file "names.txt".
    Use the following names: "Alice", "Bob", "Charlie", "David", "Eve".
*/

string[] yourFriends = { "Alice", "Bob", "Charlie", "David", "Eve" };

StringBuilder arrayContent = new StringBuilder();
for (int i = 0; i < yourFriends.Length; i++)
{
    arrayContent.AppendLine(yourFriends[i]);
}

File.WriteAllText(relativeFilePath, arrayContent.ToString());

Console.WriteLine();
#endregion

#region Task 3 - Read from the file

/*
    *** Task 3
    Read the file and print its content to the console.
    If the file does not exist, print a message to the console.
*/

string fileContent = File.ReadAllText(relativeFilePath);
Console.WriteLine("File content:");
Console.WriteLine(fileContent);

#endregion

#region Task 4 - Delete the file and folder
/*
    *** Task 4
    Delete the file "names.txt" and the folder "Files".
    If the file or folder does not exist, print a message to the console.
*/

if (File.Exists(relativeFilePath))
{
    File.Delete(relativeFilePath);
    Console.WriteLine($"File '{fileName}' deleted successfully.");
}
else
{
    Console.WriteLine($"File '{fileName}' does not exist.");
}
#endregion