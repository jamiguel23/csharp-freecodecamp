// See https://aka.ms/new-console-template for more information

namespace Csharp
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cube(3));
  
            Console.ReadLine();
        }

        static int cube(int num)
        {
            int result = num * num * num;

            return result;
        }
    }

}