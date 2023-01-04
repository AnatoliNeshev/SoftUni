using System;

namespace P03.FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double eps = Math.Abs(a - b);

            bool toPrint = eps <= 0.000001;
            Console.WriteLine(toPrint);
        }
    }
}
