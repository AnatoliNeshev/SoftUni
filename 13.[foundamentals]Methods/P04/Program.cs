using System;

namespace P04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int toEnd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= toEnd; i++)
            {
                PrintLine(1,i);
            }

            for (int i = toEnd-1; i >= 1; i--)
            {
                PrintLine(1, i);
            }            
        }
        static void PrintLine(int start,int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");                               
            }
            Console.WriteLine();
        }        
    }
}
