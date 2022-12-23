using System;

namespace Thesongofthewheels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int control = int.Parse(Console.ReadLine());
            int counter = 0;
            int passA = 0;
            int passB = 0;
            int passC = 0;
            int passD = 0;
            bool isFound = false;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            bool first = false;
                            bool second = false;   
                            if (a<b && c>d)
                            {
                                first = true;
                            }
                            if ((a*b)+(c*d)==control)
                            {
                                second = true;
                            }
                            if (first && second)
                            {
                                counter++;
                                Console.Write($"{a}{b}{c}{d} ");
                                if (counter == 4)
                                {
                                    isFound = true;
                                    passA = a;
                                    passB = b;
                                    passC = c;
                                    passD = d;
                                }
                            }                           
                        }
                    }
                }              
            }
            Console.WriteLine();
            if (!isFound)
            {
                Console.WriteLine("No!");
            }
            else
            {
                Console.WriteLine($"Password: {passA}{passB}{passC}{passD}");
            }
        }
    }
}
