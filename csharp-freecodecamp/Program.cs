// See https://aka.ms/new-console-template for more information

namespace Csharp
{

    class Program
    {
        static void Main(string[] args)
        {

            string words = "lets go";
            Console.WriteLine(words.Contains("6")); //should be false
            Console.WriteLine(words[3]); // s
            Console.WriteLine(words.IndexOf(" ")); // 4
            Console.WriteLine(words.Substring(3)); // s go
            Console.WriteLine(words.Substring(3, 3)); // s go





            Console.ReadLine();
        }
    }

}