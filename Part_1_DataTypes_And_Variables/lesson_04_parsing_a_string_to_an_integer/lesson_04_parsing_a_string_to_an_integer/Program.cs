using System;

namespace lesson_04_parsing_a_string_to_an_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFirstString = "15";
            string mySecondString = "14";
            string result = myFirstString + mySecondString;

            Console.WriteLine(result);

            // parsing string to integer
            int a = Int32.Parse(myFirstString);
            int b = Int32.Parse(mySecondString);
            int newResult = a + b;

            Console.WriteLine(newResult);
        }
    }
}
