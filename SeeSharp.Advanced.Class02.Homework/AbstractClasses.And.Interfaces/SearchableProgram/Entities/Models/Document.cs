using SearchableProgram.Entities.Interfaces;

namespace SearchableProgram.Entities.Models
{
    public class Document : ISearchable
    {
        public string Text { get; set; }

        public Document(string text)
        {
            Text = text;
        }

        public void Search()
        {
            while (true)
            {
                string word = Console.ReadLine();
                if (Text.Contains(word))
                {
                    Console.WriteLine($"The word '{word}' is found in the document.");
                }
                else
                {
                    Console.WriteLine($"The word '{word}' is not found in the document.");
                }
                ;
                Console.WriteLine("Do you want to search for another word? (yes/no)");
                string answer = Console.ReadLine();
                if (answer.ToLower() != "yes")
                {
                    Console.WriteLine("Exiting the app...");
                    break;
                }
            }
        }
    }
}
