using System;

namespace lesson_03_implicit_and_explicit_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion
            int num = 1253459324;
            long bigNum = num;

            float myFloat = 14.345f;
            double myDouble = myFloat;


            // explicit conversion
            double myNewDouble = 3.14;
            int myInt;
            
            myInt = (int)myNewDouble;   // cast double to int
            Console.WriteLine(myInt);

            // type conversion
            string myString = myDouble.ToString();
        }
    }
}
