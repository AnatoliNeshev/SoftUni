using System;

namespace P02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DegreeDjuge(double.Parse(Console.ReadLine()));
        }

        static void DegreeDjuge(double degree)
        {
            if (degree >=2.00 && degree <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (degree >= 3.00 && degree <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (degree >= 3.50 && degree <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (degree >= 4.50 && degree <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
