using System;
using System.Linq;

namespace P05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] topInt = new int[array.Length];
            int topIntIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currNum = array[i];
                bool isTopInteger =true;

                for (int j = i+1; j < array.Length; j++)
                {
                    if (currNum<= array[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    topInt[topIntIndex] = currNum;
                    topIntIndex++;
                }
            }
            for (int i = 0; i < topIntIndex; i++)
            {
                Console.Write($"{topInt[i]} ");
            }
        }
    }
}
