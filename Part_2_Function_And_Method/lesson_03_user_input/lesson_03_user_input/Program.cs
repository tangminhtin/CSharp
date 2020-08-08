using System;

namespace lesson_03_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a = ");
            int a = int.Parse(Console.ReadLine());  // get input

            Console.Write("Enter b = ");
            int b = int.Parse(Console.ReadLine());  // get input

            Console.WriteLine("Sum of {0} + {1} = {2}", a, b, Sum(a, b)) ;
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
