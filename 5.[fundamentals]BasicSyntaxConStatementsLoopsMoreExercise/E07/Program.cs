using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coinSum = 0;
            string input = string.Empty;

            while ((input = Console.ReadLine())!= "Start")
            {
                double currCoin = double.Parse(input);
                if (currCoin == 0.1)
                {
                    coinSum+=currCoin;
                }
                else if (currCoin == 0.2)
                {
                    coinSum += currCoin;
                }
                else if (currCoin == 0.5)
                {
                    coinSum += currCoin;
                }
                else if (currCoin == 1)
                {
                    coinSum += currCoin;
                }
                else if (currCoin == 2)
                {
                    coinSum += currCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currCoin}");
                }
            }

            string nextOutput = string.Empty;
            double prise = 0;

            while ((nextOutput = Console.ReadLine())!= "End")
            {
                switch (nextOutput)
                {
                    case "Nuts":
                        prise = 2.0;
                        break;
                    case "Water":
                        prise = 0.7;
                        break;
                    case "Crisps":
                        prise = 1.5;
                        break;
                    case "Soda":
                        prise = 0.8;
                        break;
                    case "Coke":
                        prise = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (prise <= coinSum && prise != 0)
                {
                    Console.WriteLine($"Purchased {nextOutput.ToLower()}");
                    coinSum -= prise;
                }
                else if (prise > coinSum)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            Console.WriteLine($"Change: {coinSum:f2}");
        }
    }
}
