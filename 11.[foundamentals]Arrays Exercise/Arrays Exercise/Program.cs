using System;
using System.Linq;

namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] passengers = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int currInt = int.Parse(Console.ReadLine());
                sum += currInt;
                passengers[i] = currInt;
            }
            
            Console.WriteLine(String.Join(" ",passengers));  
            Console.WriteLine(sum);
        }
    }
}
