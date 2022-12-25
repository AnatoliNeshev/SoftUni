using System;

namespace ReportSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = int.Parse(Console.ReadLine());
            string input = "";
            double cashCounter = 0;
            double cardCounter = 0;
            double cashSum = 0;
            double cardSum = 0;
            double finalSum = 0;
            double transactionCounter = 0;

            while (input != "End" && finalSum < sum && finalSum!=sum)
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    continue;
                }
                transactionCounter++;
                if (transactionCounter % 2 != 0)
                {
                    if (double.Parse(input) > 100) 
                    {
                        Console.WriteLine("Error in transaction!");    
                    } 
                    else
                    {
                        Console.WriteLine("Product sold!");
                        cashCounter++;
                        cashSum+=double.Parse(input);
                    }
                }
                else
                {
                    if (double.Parse(input) < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        cardCounter++;
                        cardSum += double.Parse(input);
                    }
                }
                finalSum = cardSum + cashSum;
            }
            if (finalSum >= sum)
            {
                Console.WriteLine($"Average CS: {cashSum/cashCounter:f2}");
                Console.WriteLine($"Average CC: {cardSum/cardCounter:f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
