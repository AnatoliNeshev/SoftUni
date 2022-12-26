using System;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int times = 1;
            while (times != 11)
            {
                Console.WriteLine($"{num} X {times} = {num*times}");
                times++;
            }
        }
    }
}
