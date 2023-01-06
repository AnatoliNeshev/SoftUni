using System;
using System.Linq;

namespace P03RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double[] num = new double[input.Length];

            for     (int i = 0; i < input.Length; i++)
            {
                num[i] = double.Parse(input[i]);                
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == -0)
                {

                }
                Console.WriteLine($"{num[i]} => {Math.Round(num[i],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
