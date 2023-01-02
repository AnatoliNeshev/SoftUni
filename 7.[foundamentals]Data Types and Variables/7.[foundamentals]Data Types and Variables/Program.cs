using System;

namespace ConvertMeterstoKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  n = int.Parse(Console.ReadLine());

            double k = n / 1000d;
            Console.WriteLine($"{k:f2}");
        }
    }
}
