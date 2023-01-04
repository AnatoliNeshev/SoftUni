using System;

namespace P04.RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 2; i <= input; i++)
            {
                bool isPrime = false;
                int counter = 0;

                for (int l = 2; l <= i; l++)
                {
                    int toCheck = i % l;
                    if (toCheck == 0)
                    {
                        counter++;                        
                    }
                }

                if (counter == 1)
                {
                    isPrime = true;
                    Console.WriteLine($"{i} -> true");
                }
                else
                {
                    Console.WriteLine($"{i} -> false");
                }                
            }
        }
    }
}
