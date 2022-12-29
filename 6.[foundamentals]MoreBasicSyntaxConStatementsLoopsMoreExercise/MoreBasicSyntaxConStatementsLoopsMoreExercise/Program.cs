using System;

namespace SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            string input;

            for (int i = 0; i < array.Length; i++)
            {
                input = Console.ReadLine();
                int currNum = int.Parse(input);
                int transit = 0;

                if (currNum > array[0])
                {
                    transit = array[0];
                    array[0] = currNum;
                    currNum = transit;

                    if (currNum > array[1])
                    {
                        transit = array[1];
                        array[1] = currNum;
                        array[2] = transit;
                    }
                }
                else if (currNum > array[1])
                {
                    transit = array[1];
                    array[1] = currNum;
                    array[2] = transit;
                }
                else
                {
                    array[2] = currNum;
                }
            }
            foreach (var sortNumber in array)
            {
                Console.WriteLine(sortNumber);
            }
        }
    }
}
