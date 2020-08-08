using System;

namespace lesson_06_constant
{
    class Program
    {
        static void Main(string[] args)
        {
            // constant is immutable values which are known
            // at compile time and do not change for the life of the program.
            const double PI = 3.14159265359;
            const int weeks = 52, month = 12;
            int days = 365;
            const string birthday = "1999-29-09";

            Console.WriteLine("My birthday is always going to be: {0}", birthday);
        }
    }
}
