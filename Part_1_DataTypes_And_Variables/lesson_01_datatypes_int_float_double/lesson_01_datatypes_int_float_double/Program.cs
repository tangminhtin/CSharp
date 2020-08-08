using System;

namespace lesson_01_datatypes_int_float_double
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable
            int iA = 5, iB = 10;
            float fA = 3.5f, fB = 4.3f;
            double dA = 3.5, dB = 4.3;
            
            // set color for console
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.WriteLine("The sum of [int]: " + iA + " + " + iB + " = " + (iA + iB));
            Console.WriteLine("The sum of [float]: " + fA + " + " + fB + " = " + (fA + fB));
            Console.WriteLine("The sum of [double]: " + dA + " + " + dB + " = " + (dA + dB));
        }
    }
}
