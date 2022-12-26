using System;

namespace EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool terminate = false;

            while (!terminate)
            {
                int num = int.Parse(Console.ReadLine());

                if (num%2!=0)
                {
                    Console.WriteLine("Please write an even number.");
                    continue;
                }
                else if (num % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    terminate = true;
                }
            }
        }
    }
}
