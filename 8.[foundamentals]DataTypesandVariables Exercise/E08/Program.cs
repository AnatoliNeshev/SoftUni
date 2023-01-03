using System;
using System.Numerics;

namespace BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger biggestKeg = BigInteger.Zero;
            string biggestKegName = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int hight = int.Parse((Console.ReadLine()));

                BigInteger currKegSize =(BigInteger) (3.14 * (Math.Pow(radius, 2) * hight));
                if ((BigInteger)currKegSize > biggestKeg)
                {
                    biggestKeg = (BigInteger)currKegSize;
                    biggestKegName = model;
                }          
            }
            Console.WriteLine(biggestKegName);
        }
    }
}
