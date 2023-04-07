// See https://aka.ms/new-console-template for more information

namespace Csharp
{

    class Program
    {
        static void Main(string[] args)
        {

            //int num = Convert.ToInt32("45");

            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();


            Console.WriteLine("Roses are " + color);
            Console.WriteLine( pluralNoun + " are blue");
            Console.WriteLine("I dont like " + celebrity);

            Console.ReadLine();
        }
    }

}