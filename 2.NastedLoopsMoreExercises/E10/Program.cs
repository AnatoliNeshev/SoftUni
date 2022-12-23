using System;

namespace Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coinsByOne = int.Parse(Console.ReadLine());
            int coinsByTwo = int.Parse(Console.ReadLine()); 
            int billsByFive = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= coinsByOne; i++)
            {
                for (int j = 0; j <= coinsByTwo; j++)
                {
                   for (int l = 0;l<= billsByFive; l++)
                    {
                        int one = i * 1;
                        int two = j * 2;
                        int three = l * 5;
                        if (one + two + three == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {l} * 5 lv. = {sum} lv.");
                        }
                    }
                } 
            }
        }            
    }
}
