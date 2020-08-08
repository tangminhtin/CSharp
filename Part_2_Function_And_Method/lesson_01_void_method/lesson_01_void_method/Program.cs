using System;

namespace lesson_01_void_method
{
    class Program
    {
        static void Main(string[] args)
        {
            sayHello();
            welcome("Tang Minh Tin");
        }

        // access modifier (static) return type method name (parameter1, parameter2)
        public static void sayHello()
        {
            Console.WriteLine("Hello Everyone!");
        }

        public static void welcome(string name)
        {
            Console.WriteLine("Welcome, {0} to my programing", name);
        }
    }
}
