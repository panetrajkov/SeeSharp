
namespace PrintInConsoleApp.Helpers
{
    public class PrintInConsole
    {
        public void Print<T> (T item)
        {
            Console.WriteLine(item);
        }
        public void PrintCollection<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
