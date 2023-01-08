using System;
using System.Linq;

namespace P03.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 1 ; i <=n; i++)
            {
                int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i%2 != 0)
                {
                    firstArray[i-1] = array[0];
                    secondArray[i-1] = array[1];
                }
                else
                {
                    firstArray[i - 1] = array[1];
                    secondArray[i - 1] = array[0];
                }
            }
            Console.WriteLine(String.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
