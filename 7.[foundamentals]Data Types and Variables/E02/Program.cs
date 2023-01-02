using System;

namespace PoundstoDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pounds = double.Parse(Console.ReadLine());
            double usd = pounds * 1.31;
            Console.WriteLine($"{usd:f3}");
        }
    }
}
