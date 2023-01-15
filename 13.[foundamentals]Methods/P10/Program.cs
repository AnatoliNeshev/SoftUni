using System;

namespace P10.MultiplyEvensbyOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var SumOfEvenDigits = GetSumOfEvemDigits(Math.Abs(number));
            var SumOfOddDigits = GetSumOfOddDigits(Math.Abs(number));
            Console.WriteLine(SumOfEvenDigits * SumOfOddDigits);
        }

        static int GetSumOfEvemDigits (int num)
        {
            int sum = 0;    

            while (num != 0)
            {
                int digit = num % 10;   

                if (digit % 2 == 0)
                {
                    sum += num % 10;
                }
                num /= 10;
            }

            return sum;
        }

        static int GetSumOfOddDigits(int num)
        {
            int sum = 0;

            while (num != 0)
            {
                int digit = num % 10;

                if (digit % 2 != 0)
                {
                    sum += num % 10;
                }
                num /= 10;
            }

            return sum;
        }
    }
}
