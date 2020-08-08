using System;

namespace lesson_02_method_with_return_value
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum: " + Add(5, 3));
            Console.WriteLine("Multiple: " + Multiple(5, 3));
            Console.WriteLine("Devide: " + Devide(5, 3));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiple(int a, int b)
        {
            return a * b;
        }

        public static double Devide(double a, double b)
        {
            return a / b;
        }
    }
}
