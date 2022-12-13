using System;

namespace Rectangleof10x10Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int l = 1; l <= 10; l++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
