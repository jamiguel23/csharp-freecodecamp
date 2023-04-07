// See https://aka.ms/new-console-template for more information

namespace Csharp
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert your name ");
            string userName = Console.ReadLine();
            Console.WriteLine("insert your age ");
            int age = Convert.ToInt32(Console.ReadLine());
            SayHi(userName, age);
            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("hello " + name + " your age is " + age);

        }
    }

}