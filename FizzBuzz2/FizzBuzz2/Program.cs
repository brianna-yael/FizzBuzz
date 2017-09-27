using System;

namespace FizzBuzz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz! This program will print numbers from 1 to 100. Can you detect a pattern?");
            for (int i = 1; i < 100; i++)
            {
                FizzBuzz(i);
                Console.WriteLine(FizzBuzz(i));
            }
        }

        public static string FizzBuzz(int f)
        {
            string result = string.Empty;
            if (f % 3 == 0 && f % 5 == 0)
            {
                result = "FizzBuzz";
            }
            else if (f % 3 == 0)
            {
                result = "Fizz";
            }
            else if (f % 5 == 0)
            {
                result = "Buzz";
            }
            else
            {
                result = Convert.ToString(f);
            }

            return result;
        }
    }
}
