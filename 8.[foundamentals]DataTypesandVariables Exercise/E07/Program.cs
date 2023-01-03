using System;

namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double litters = 0;

            for (int i = 0; i < n; i++)
            {
                double littersAdd = double.Parse(Console.ReadLine());
                if (litters +littersAdd > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    litters+=littersAdd;
                }
            }
            Console.WriteLine(litters);
        }
    }
}
