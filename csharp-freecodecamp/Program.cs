// See https://aka.ms/new-console-template for more information

using System.Runtime.Intrinsics.X86;

namespace Csharp
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("enter an number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if(op == "+")
            {
                Console.Write(num1 + num2);
            }
            else if (op == "-")
            {
                Console.Write(num1 - num2);

            }
            else if (op == "/")
            {
                Console.Write(num1 / num2);

            }
            else if (op == "*")
            {
                Console.Write(num1 * num2);

            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

            Console.ReadLine();
        }


    }

}