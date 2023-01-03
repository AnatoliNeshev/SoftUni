using System;
using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numSnowBalls = int.Parse(Console.ReadLine());
            int bestSnoballAnow = 0;
            int bestSnoballTime = 0;
            int bestSnowballQuality = 0;
            BigInteger bestFinal = BigInteger.Zero;

            for (int i = 1; i <= numSnowBalls; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());
                int snowballDivide = snowBallSnow / snowballTime;
                BigInteger snowballValue = BigInteger.Pow(snowballDivide, snowBallQuality);

                if (snowballValue >= bestFinal)
                {
                    bestFinal = snowballValue;
                    bestSnoballAnow = snowBallSnow;
                    bestSnoballTime = snowballTime;
                    bestSnowballQuality = snowBallQuality;
                }
            }
            Console.WriteLine($"{bestSnoballAnow} : {bestSnoballTime} = {bestFinal} ({bestSnowballQuality})");
        }
    }
}
