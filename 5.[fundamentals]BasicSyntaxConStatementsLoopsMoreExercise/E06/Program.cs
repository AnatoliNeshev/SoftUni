using System;

namespace Strongnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            long factorialSum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                char currCH = num[i];
                int currDigit = (int)currCH - 48;
                long currDigitFactorial = 1;

                for (int r  = currDigit; r > 1; r--)
                {
                    currDigitFactorial *= r;
                }
                factorialSum+=currDigitFactorial;
            }
            if (factorialSum == int.Parse(num))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
