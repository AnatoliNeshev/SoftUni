using System;
using System.Linq;

namespace Arrays.DayofWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            foreach (int i in input)
            {
               int result = i % 2 == 0 ? sum += i : sum;
            }
            Console.WriteLine(sum);
        }
    }
}
