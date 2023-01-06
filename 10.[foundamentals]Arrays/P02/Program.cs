using System;

namespace P02PrintNumbersReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                array[i] = currNum;
            }

            for (int l = array.Length-1; l >=0; l--)
            {
                Console.Write(array[l] + " ");
            }
        }
    }
}
