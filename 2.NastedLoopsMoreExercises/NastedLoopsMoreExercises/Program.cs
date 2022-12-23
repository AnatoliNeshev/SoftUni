using System;

namespace LettersCombinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char charecter1 = char.Parse(Console.ReadLine());
            char charecter2 = char.Parse(Console.ReadLine());
            char charecter3 = char.Parse(Console.ReadLine());

            int combinations = 0;

            for (char  i  = charecter1; i <= charecter2; i++)
            {
                for (char j = charecter1; j <= charecter2; j++)
                {
                    for (char k = charecter1; k <= charecter2; k++)
                    {
                        if (i!= charecter3 && j!= charecter3 && k != charecter3)
                        {
                            Console.Write($"{i}{j}{k} ");
                            combinations++;
                        }
                    }
                }
            }
            Console.WriteLine(combinations);
        }
    }
}
