using System;

namespace lesson_02_string_and_some_method
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable string
            string myName = "Minh Tin Tang";
            string message = "My name is " + myName;

            Console.WriteLine(message);

            // some method of string
            Console.WriteLine(message.ToUpper());
            Console.WriteLine(message.ToLower());
            Console.WriteLine(message.Length);
            Console.WriteLine(message.Contains("Tin"));
        }
    }
}
