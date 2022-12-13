using System;

namespace RhombusofStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n-row;col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int colTwo = 1; colTwo < row; colTwo++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int row = 1; row <= n-1; row++)
            {
                for (int col  = 0; col  < row; col ++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int colTwo = 2; colTwo <= n-row; colTwo++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
