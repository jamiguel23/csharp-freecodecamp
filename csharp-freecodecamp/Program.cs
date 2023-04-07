// See https://aka.ms/new-console-template for more information

namespace Csharp
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToInt32(GetMax(10, 30, 60)));

            
            Console.ReadLine();
        }

        static int GetMax(int a, int b, int c)
        {
            //if( a == b) {
            //    {
            //        int[] result = { a, b };
            //        return result
            //     }

            if(a >= b && a>= c) 
            {
       
                return a;

            }
            else if(b>= a && b>=c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }

}