// See https://aka.ms/new-console-template for more information

namespace Csharp
{

    class Program
    {
        static void Main(string[] args)
        {

            int[] luckyNumber = { 4, 8, 15, 1, 23, 42 };
            string[] people = new string[10];// if starting new empty string array use new string[i] where i is the amount of items in the string

            people[0] = "Phil";
            luckyNumber[1] = 640;
            Console.WriteLine(people[0]);

            Console.ReadLine();
        }
    }

}