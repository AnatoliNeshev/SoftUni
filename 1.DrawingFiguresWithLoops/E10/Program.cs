using System;

namespace Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = (n - 1) / 2;
            int dash = rows;
            int dashTwo = 0;

            if (n == 1)
            {
                Console.WriteLine("*");
                return;
            }
            if (n % 2 == 0)
            {
                dashTwo = 2;
            }
            else
            {
                dashTwo = 1;
            }
            for (int i = 1; i <= rows; i++)
            {    
                Console.Write(new string ('-',dash)); 
                Console.Write("*");
                if (i >= 2)
                {
                    Console.Write(new string ('-',dashTwo));
                    dashTwo += 2;
                }
                if (i == 1 && n%2==0)
                {
                    Console.Write("*");
                }
                if (i > 1)
                {
                    Console.Write("*");
                }
                Console.Write(new string('-', dash));
                dash--;
                Console.WriteLine();
            }

            Console.Write("*");
            Console.Write(new string ('-',n-2));
            Console.Write("*");
            Console.WriteLine();

            int bash = rows;
            int dashTree;
            if (n > 3)
            {
                 dashTree = n - 4;
            }
            else
            {
                dashTree = 0;
            } 
            for (int i = 1; i <= rows; i++)
            {
                Console.Write(new string('-', (bash+1) - rows));
                Console.Write("*");
                Console.Write(new string('-', dashTree));
                if (dashTree == 1)
                {
                    dashTree = 0;
                }
                if (dashTree >= 2 && dashTree!=1)
                {
                    
                    dashTree -= 2;
                }
                if (i == rows && n % 2 == 0)
                {
                    Console.Write("*");
                }
                if (i < rows)
                {
                    Console.Write("*");
                }
                Console.Write(new string('-', (bash+1)-rows));        
                bash++;
                Console.WriteLine();
            }
        }
    }
}
