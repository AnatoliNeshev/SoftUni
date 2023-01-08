using System;

namespace P02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split();
            string [] second = Console.ReadLine().Split();

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = second.Length-1; j >= 0; j--)
                {
                    if (first[i] == second[j])
                    {
                        Console.Write($"{second[j]} ");
                    }
                }
            }
        }
    }
}
