using System;

namespace lesson_04_try_catch_and_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");

            try
            {
                int number = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
            }
            finally {
                Console.WriteLine("This is finally!");
            }
        }
    }
}
