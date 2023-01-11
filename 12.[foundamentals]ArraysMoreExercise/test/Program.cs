using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var pascalTriangle = new long[n][];

            for (var i = 0; i < n; i++)
            {
                pascalTriangle[i] = new long[i + 1];
                pascalTriangle[i][0] = 1;  
                pascalTriangle[i][^1] = 1; 

                for (var l = 1; l < i; l++)
                {
                    pascalTriangle[i][l] = pascalTriangle[i - 1][l - 1] + pascalTriangle[i - 1][l];
                }
            }

            for (var row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join(" ", pascalTriangle[row]));
            }
        }
    }
}
