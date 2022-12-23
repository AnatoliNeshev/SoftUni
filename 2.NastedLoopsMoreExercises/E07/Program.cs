using System;

namespace SafePasswordsGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPass = int.Parse(Console.ReadLine());
            int passCounter = 0;
            int theA = 35;
            int theB = 64;
  
             for (int first = 1; first <= a; first++)
             {
                for (int second = 1; second <= b; second++)
                {
                    Console.Write($"{(char)theA}{(char)theB}{first}{second}{(char)theB}{(char)theA}|");
                 passCounter++;
                    if (passCounter >= maxPass)
                    {
                        return;
                    }
                 theA++;
                 theB++;
                    if (theA>55)
                    {
                        theA = 35;
                    }
                    if (theB>96)
                    {
                        theB = 64;
                    }
                }
     
             }
        }
    }
}
