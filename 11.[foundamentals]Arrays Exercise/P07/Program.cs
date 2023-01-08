using System;
using System.Linq;

namespace P07.MaxSequenceofEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int currSecLenght = 1;
            int currSecStart = 0;
            int lomgestSecLenght = 1;
            int longestSecStart = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currSecLenght++;

                    if(currSecLenght > lomgestSecLenght)
                    {
                        lomgestSecLenght = currSecLenght;
                        longestSecStart = currSecStart;
                    }
                }

                else
                {
                    currSecLenght = 1;
                    currSecStart =i;
                }
            }            

            for (int i = longestSecStart; i < longestSecStart+lomgestSecLenght; i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}
