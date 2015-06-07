using System;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException("number", "Number can't be negative.");
                }
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine("Square root of {0} is {1}", number, squareRoot);
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
