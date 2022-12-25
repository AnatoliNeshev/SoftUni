using System;

namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double sum = 0;
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
                counter++;
            }
            Console.WriteLine($"{sum / counter:f2}");
        }
    }
}
