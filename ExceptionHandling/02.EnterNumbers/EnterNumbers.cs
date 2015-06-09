
using System;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            int[] numbers = new int[10];
            int min = 1;
            
            for (int i = 0; i < 10; i++)
            {
                int max = 100 - 10 + i;
                Console.Write("Please enter a number: ");
                numbers[i] = ReadNumber(min, max);
                min = numbers[i];
            }

            Console.WriteLine("You've entered the following numbers: ");
            Console.WriteLine(String.Join(", ", numbers));
        }

        public static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();

            try
            {
                int num = int.Parse(input);
                if (num <= start || num >= end)
                {
                    throw new ArgumentOutOfRangeException("input", 
                        String.Format("The number should be in range {0} .. {1}", start, end));
                }
                return num;

            }
            catch (Exception)
            {
                Console.Write("The number should be in range {0} .. {1}\nPlease enter new number: ", start, end);
                return ReadNumber(start, end);
            }
        }
    }
}
