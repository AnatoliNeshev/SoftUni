using System;

namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int biggDiv = int.MinValue;

            if (num % 2 == 0)
            {
                biggDiv = 2;
            }
            if (num % 3 == 0)
            {
                biggDiv = 3;
            }
            if (num % 6 == 0)
            {
                biggDiv = 6;
            }
            if (num % 7 == 0)
            {
                biggDiv = 7;
            }
            if (num % 10 == 0)
            {
                biggDiv = 10;
            }
            if (biggDiv < 2)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {biggDiv}");
            }           
        }
    }
}
