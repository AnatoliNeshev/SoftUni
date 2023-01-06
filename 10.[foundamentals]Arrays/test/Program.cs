using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = -0.09;

            Console.WriteLine($"{Math.Round(num,MidpointRounding.AwayFromZero)}");
        }
    }
}
