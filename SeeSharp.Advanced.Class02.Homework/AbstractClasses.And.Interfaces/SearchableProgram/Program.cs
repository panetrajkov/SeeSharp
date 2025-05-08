using SearchableProgram.Entities.Models;

Console.WriteLine("C# Homework | Class 02");
Console.WriteLine();
Console.WriteLine("===== Task 01 =====");
Console.WriteLine();

// ## Task 1
// Write a program to create an interface Searchable with a method Search(string word)
// that searches for a given keyword in a text document. Create two classes Document and WebPage
// that implement the Searchable interface and provide their own implementations of the Search() method.

string documentText = @"
    Once upon a time in a small village, there lived a man named John. John was known for his kindness and generosity.
    His neighbor, Anna, often came by to borrow sugar or just chat. One day, John and Anna decided to organize a small community event.
    They invited their friends Mark and Lisa to help with the arrangements. Lisa baked cookies while Mark handled the music.
    During the event, everyone praised John and Anna for their efforts. Later that evening, John wrote a thank-you note to Lisa and Mark.
    The next day, Mark visited John again, and they talked about how successful the event was.
    Even Anna stopped by with a basket of fruit as a thank-you gift. Everyone agreed that it was a day to remember, thanks to John, Anna, Mark, and Lisa.
";

string[] wordsInText = documentText.Split(new char[] { ' ', ',', '.', '-' }, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine("Please enter the word you want to search it up:");

Document document = new Document(documentText);

document.Search();

Console.WriteLine();
Console.WriteLine("========================================");
Console.WriteLine();

Console.WriteLine("Please check if you can find if our URL (https://example.com) and its short forms exist.");

string webPageText = @"
    Welcome to our website - https://example.com ! We offer a variety of services including web development, graphic design, and digital marketing.
    Our team is dedicated to providing the best solutions for your business needs. Contact us today for a free consultation.
    Don't forget to check out our blog for the latest industry news and tips. Thank you for visiting https://example.com!";

string[] wordsInWebPage = webPageText.Split(new char[] { ' ', ',', '.', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

WebPage webPage = new WebPage(webPageText);

webPage.Search();