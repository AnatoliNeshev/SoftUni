using System;

namespace PrimePairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstBegin = int.Parse(Console.ReadLine());
            int secondBegin = int.Parse(Console.ReadLine());
            int diffFirst = int.Parse(Console.ReadLine());
            int diffSecond = int.Parse(Console.ReadLine());
            int counterOne = 0;
            int counterTwo = 0;
            
            for (int i = firstBegin; i <= firstBegin+diffFirst; i++)
            {
                for (int test = 1; test <= i; test++)
                {
                    if (i % test == 0)
                    {
                        counterOne++;
                    }             
                }
                for (int j = secondBegin; j <= secondBegin + diffSecond; j++)
                {
                    for (int test2 = 1; test2 <= j; test2++)
                    {
                        if (j % test2 == 0)
                        {
                            counterTwo++;
                        }
                    }
                    if (counterOne == 2 && counterTwo == 2)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                    counterTwo = 0;
                }
                counterOne = 0;
            }
        }
    }
}
