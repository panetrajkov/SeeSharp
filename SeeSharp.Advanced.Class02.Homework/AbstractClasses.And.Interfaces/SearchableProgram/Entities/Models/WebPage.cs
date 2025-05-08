using SearchableProgram.Entities.Interfaces;

namespace SearchableProgram.Entities.Models
{
    public class WebPage : ISearchable
    {

        public string Url { get; set; }

        public WebPage(string url)
        {
            Url = url;
        }

        public void Search()
        {
            while (true)
            {
                string word = Console.ReadLine();
                if (Url.Contains(word))
                {
                    Console.WriteLine($"The word '{word}' is found in the webpage.");
                }
                else
                {
                    Console.WriteLine($"The word '{word}' is not found in the webpage.");
                }
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
