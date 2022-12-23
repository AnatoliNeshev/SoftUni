using System;

namespace SumofTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            bool toStop=false;
            
            
                for (int i = firstNum; i <= lastNum; i++)
                {
                   for (int j = firstNum; j <= lastNum; j++)
                   {
                       counter++;
                       if (i+j== magicNum)
                       {
                           toStop = true;
                           Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNum})");
                            return;
                       }
                   }
                }
                if (!toStop)
                {
                    Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
                }      
        }
    }
}
