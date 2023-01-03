using System;

namespace IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine()), two = int.Parse(Console.ReadLine()), three = int.Parse(Console.ReadLine()), four = int.Parse(Console.ReadLine());
            
            one+=two;
            one /= three;
            one*=four;
            Console.WriteLine(one);
        }
    }
}
