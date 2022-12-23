using System;

namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                for (int f = 1; f <= n; f++)
                {
                    for (int h = 1; h <= l; h++)
                    {
                        for (int v = 1; v <= l; v++)
                        {
                            for (int r = 1; r <= n; r++)
                            {
                                if (r > f && r > i)
                                {
                                    Console.Write($"{i}{f}{(Char)(h + 96)}{(Char)(v + 96)}{r} ");
                                }                               
                            }
                        }
                    }
                }
            }
        }
    }
}
