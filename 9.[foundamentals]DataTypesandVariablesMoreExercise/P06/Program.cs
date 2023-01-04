using System;

namespace P06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counterOne = 0;
            int counterTwo = 0;
            bool isBalanced = true;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    counterOne++;
                }
                else if (input == ")")
                {
                    counterTwo++;
                }
                if (counterOne - counterTwo >= 2)
                {
                    isBalanced = false;
                }
                if (counterTwo -counterOne >= 1)
                {
                    isBalanced = false;
                }
            }
            if (isBalanced && counterOne==counterTwo)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
