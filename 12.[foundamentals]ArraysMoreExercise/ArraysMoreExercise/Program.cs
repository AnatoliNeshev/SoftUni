using System;

namespace ArraysMoreExercise.EncryptSortandPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfStrings = int.Parse(Console.ReadLine());
            string vowels = "EeUuIiOoAa";
            int sumVowels = 0;
            int sumConsonant = 0;
            int[] arrayToPrint = new int[numOfStrings];

            for (int i = 0; i < numOfStrings; i++)
            {
                string word = Console.ReadLine();
                for (int l = 0; l < word.Length; l++)
                {
                    char currentChar = word[l];
                    if (vowels.Contains(currentChar))
                    {
                        sumVowels += (currentChar*word.Length);
                    }

                    else
                    {
                        sumConsonant += (currentChar/word.Length);
                    }
                }

                arrayToPrint[i] = sumConsonant + sumVowels;
                sumVowels = 0;
                sumConsonant = 0;
            }

            Array.Sort(arrayToPrint);
            foreach (int sum in arrayToPrint)
            {
                Console.WriteLine(sum);
            }

        }
    }
}
