using System;

namespace TriplesofLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int l = 0; l < num; l++)
                {
                    for (int k = 0; k < num; k++)
                    {
                        char one = (char)('a' + i);
                        char two = (char)('a' + l);
                        char three = (char)('a' + k);
                        Console.WriteLine($"{one}{two}{three}");
                    }
                }
            }
        }
    }
}
