using System;
using System.Linq;

namespace P06EvenandOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEven = 0;
            int sumOdd = 0;

            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    sumEven+=num;
                }
                else
                {
                    sumOdd+=num;
                }
            }
            Console.WriteLine($"{sumEven - sumOdd}");
        }
    }
}
