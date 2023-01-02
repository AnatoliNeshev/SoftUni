using System;
using System.Numerics;

namespace ExactSumofRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            decimal sum = 0M;
            
            for (int i = 0; i < n; i++)
            {
               decimal input = decimal.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine(sum);
        }
    }
}
