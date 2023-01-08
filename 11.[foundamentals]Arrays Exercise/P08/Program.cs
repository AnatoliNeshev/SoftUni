using System;
using System.Linq;

namespace P08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int[] array = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int given = int.Parse(Console.ReadLine());
            
            for (int d = 0; d < array.Length; d++)
            {                
                for (int l = d+1; l < array.Length; l++)
                {
                    if (array[d] + array[l] == given)
                    {
                        Console.Write($"{array[d]} {array[l]}");
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}
