using System;

namespace P05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();  
            int quantity = int.Parse(Console.ReadLine());

            CalculateOrder(input, quantity);
        }

        static void CalculateOrder (string type,double quant)
        {
            double orderPrice = 0;
            switch (type)
            {
                case "coffee":
                    orderPrice =1.5 * quant;
                    break;
                case "water":
                    orderPrice= 1 * quant;
                    break ;
                case "coke":
                    orderPrice=1.4 * quant;
                    break;;
                case "snacks":
                    orderPrice = 2 * quant;
                    break;
                    default:
                    break;
            }
            Console.WriteLine($"{orderPrice:f2}");
        }
    }
}
