using System;
using System.Linq;

namespace P04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rotationCount = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < rotationCount; i++)
            {
                int firstEl = arr[0];

                for (int l = 0; l < arr.Length-1; l++)
                {
                    arr[l] = arr[l + 1];
                }
                arr[arr.Length-1] = firstEl;
            }
            Console.WriteLine(String.Join(" ",arr));             
        }
    }
}
