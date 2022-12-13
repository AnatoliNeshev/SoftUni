using System;

namespace House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rows = (n + 1) / 2;
            int stars = 0;
            int dashes = 0;
            int houseFoundation = n - rows;

            if (n % 2 == 0)
            {
                stars = 2;
            }
            else
            {
                stars = 1;
            }

            dashes = (n - stars) / 2;

            for (int i = 1; i <= rows; i++)
            {

                Console.Write(new string('-', dashes));
                Console.Write(new string('*', stars));
                Console.Write(new string('-', dashes));
                stars += 2;
                dashes -= 1;
                Console.WriteLine();
            }
           
            for (int i = 1; i <= houseFoundation; i++)
            {
                Console.Write(new string ('|',1));
                Console.Write(new string ('*',n-2));
                Console.Write(new string ('|',1));
                Console.WriteLine();
            }
        }
    }
}
