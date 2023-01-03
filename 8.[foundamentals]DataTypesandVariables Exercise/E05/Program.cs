using System;

namespace PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingPoint = int.Parse(Console.ReadLine());
            int finishPoint = int.Parse(Console.ReadLine());

            for (int i = startingPoint; i <= finishPoint; i++)
            {
                char charToPrint = (char)i;
                Console.Write(charToPrint+" ");
            }
        }
    }
}
