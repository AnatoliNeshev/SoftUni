using System;

namespace Sunglasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('*',2*n));
            Console.Write(new string(' ',n));
            Console.Write(new string('*',2*n));
            Console.WriteLine();

                for (int row = 0; row < n-2; row++)
                {
                    if (row == (n-1)/2-1)
                    {
                        Console.Write("*");
                        Console.Write(new string('/', 2 * n - 2));
                        Console.Write("*");
                        Console.Write(new string('|', n));
                        Console.Write("*");
                        Console.Write(new string('/', 2 * n - 2));
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("*");
                        Console.Write(new string('/', 2 * n - 2));
                        Console.Write("*");
                        Console.Write(new string(' ', n));
                        Console.Write("*");
                        Console.Write(new string('/', 2 * n - 2));
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', 2 * n));
        }
    }
}
