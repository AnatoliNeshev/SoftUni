using System;

namespace SumofOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            

            for (int i = 0; i < num; i++)
            {
                int currOddNum = 1 + (i*2);
                Console.WriteLine(currOddNum);
                sum+=currOddNum;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
