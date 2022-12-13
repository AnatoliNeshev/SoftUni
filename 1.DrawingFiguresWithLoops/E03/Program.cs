using System;

namespace SquareofStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lenght; i++)
            {
                for (int l = 1; l <= lenght; l++)
                {
                    Console.Write('*' + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
