using System;

namespace PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            double check = (double)n-((double)n *0.5);
            bool toStop = false;
            int targetCounter = 0;

            while (!toStop)
            {
                if (n >= m)
                {
                    n -= m;
                    targetCounter++;
                }

                if (n == check)
                {   
                    if (y > 0)
                    {
                        n /= y;
                    }                                           
                }                
                if (n < m)
                {
                    toStop = true;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(targetCounter);
        }
    }
}
