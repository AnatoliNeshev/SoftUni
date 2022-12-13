using System;

namespace SquareFrame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
                for (int l = 1; l <= n; l++)
                {
                  
                    if (l == 1 || l == n )
                    {
                    Console.Write("+ ");
                    }
                    else
                    {
                    Console.Write("| ");
                    }
                    for (int i = 1; i <= n-2; i++)
                    {
                      Console.Write("- ");
                    }
                    if (l == 1 || l == n)
                    {
                      Console.Write("+");
                    }
                    else
                    {
                        Console.Write("|");
                    }

                     Console.WriteLine();
                }
            
        }
    }
}
