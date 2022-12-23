using System;

namespace HappyCatParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double tottalSum = 0;
            double currentSum = 0;
            for (int i = 1; i <= days; i++)
            {
                currentSum = 0;

                for (int j = 1; j <= hours; j++)
                {
                    
                    if (i%2==0 && j % 2 != 0)
                    {
                        currentSum += 2.5;
                    }
                    else if (i%2!=0 && j % 2 == 0)
                    {
                        currentSum += 1.25;
                    }
                    else
                    {
                        currentSum += 1;
                    }              
                }
                Console.WriteLine($"Day: {i} - {currentSum:f2} leva");
                tottalSum += currentSum;
            }
            Console.WriteLine($"Total: {tottalSum:f2} leva");
        }
    }
}
