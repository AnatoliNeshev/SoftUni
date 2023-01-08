using System;
using System.Linq;

namespace P06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ',StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            bool thereIsIndex = false;
            int theIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currIndex = i;
                int sumForward = 0;
                int sumBackward = 0;

                for (int l = currIndex+1; l < array.Length; l++)
                {
                    sumForward += array[l];
                }

                for (int r = currIndex-1; r >= 0; r--)
                {
                    sumBackward += array[r];
                }

                if (sumForward == sumBackward)
                {
                    thereIsIndex = true;
                    theIndex=i;
                }
            }
            if (thereIsIndex)
            {
                Console.WriteLine(theIndex);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
