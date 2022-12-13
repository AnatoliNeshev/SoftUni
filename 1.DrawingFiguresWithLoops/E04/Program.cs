using System;

namespace TriangleofDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= n; i++)
            {
                for (int l = 1; l <= i; l++)
                {
                    Console.Write('$'+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
