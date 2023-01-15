using System;

namespace Methods.SignofIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintNumSign(number);
        }

        static void PrintNumSign(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive. "); 
            }
            else
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
        }
    }
}
