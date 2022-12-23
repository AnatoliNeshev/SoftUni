using System;

namespace UniquePINCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numTree = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numOne; i++)
            {
                for (int l = 1; l <= numTwo; l++)
                {
                    int counter = 0;
                    for (int k = 1; k <= l; k++)
                    {
                        if (l % k == 0)
                        {
                            counter++;
                        }
                    }
                    for (int j = 1; j <= numTree; j++)
                    {
                        if (counter == 2 && (i % 2 == 0) && (j % 2 == 0))
                        {
                            Console.WriteLine($"{i} {l} {j}");
                        }                     
                    }
                    counter = 0;
                }
            }
        }
    }
}
