using System;
using System.Numerics;

namespace SpiceMustFlow 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long startingYield = int.Parse(Console.ReadLine());
            long daycounter = 0;
            BigInteger product = BigInteger.Zero;
            bool toStop = false;

            while (!toStop)
            {
                if (startingYield < 100)
                {
                    if (product >= 26)
                    {
                        product -= 26;
                    }
                    else
                    {
                        product = 0;
                    }
                    toStop = true;
                    continue;
                }

                product += startingYield;
                
                if (product >= 26)
                {
                    product-=26;
                }
                else
                {
                    product=0;
                }
                daycounter++;
                startingYield -= 10;      
            }
            Console.WriteLine(daycounter);
            Console.WriteLine(product);
        }
    }
}
