using System;

namespace SumofChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numLines = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numLines; i++)
            {
                char newChar = char.Parse(Console.ReadLine());
                sum+=newChar;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
