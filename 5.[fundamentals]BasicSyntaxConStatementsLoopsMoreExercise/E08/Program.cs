using System;

namespace TriangleofNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int r = 0; r < i; r++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
