using System;
using System.Linq;

namespace P09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());
            string input;
            int[] finalDna = new int[dnaLenght];
            int theBestIndex = int.MinValue;
            int bestDnaLenght = int.MinValue;
            int theBestDnaSum = int.MinValue;
            int theBestStartIndex = 0;
            int index = 0;
            
            while((input = Console.ReadLine()) != "Clone them!")
            {
                int[] dnaSeqences = input
                .Split('!',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
                index++;
                int currDnaLenght = int.MinValue;;
                int currDnaStartIndex = int.MinValue;
                int toCheckDnalenght = 0;
                int toCheckDnaIndex = 0;                
                bool flag = false;

                for (int i = 0; i < dnaLenght; i++)
                {
                    if (dnaSeqences[i] == 1 && flag)
                    {
                        toCheckDnalenght++;
                    }
                    else if (dnaSeqences[i] == 1)
                    {
                        flag = true;
                        toCheckDnalenght = 1;
                        toCheckDnaIndex = i;
                    }
                    if (dnaSeqences[i] == 0 && flag)
                    {                        
                        if (toCheckDnalenght > currDnaLenght)
                        {
                            currDnaLenght = toCheckDnalenght;                                                        
                            currDnaStartIndex = toCheckDnaIndex;
                        }
                        flag = false;
                        toCheckDnaIndex = 0;
                        toCheckDnalenght = 0;
                    }
                }

                if (flag)
                {
                    if (toCheckDnalenght > currDnaLenght)
                    {
                        currDnaLenght = toCheckDnalenght;
                        currDnaStartIndex = toCheckDnaIndex ;
                    }
                }
                                                                                                                                                                     if (currDnaLenght > bestDnaLenght)
                {
                    bestDnaLenght = currDnaLenght;
                    theBestStartIndex = currDnaStartIndex;
                    theBestDnaSum = dnaSeqences.Sum();
                    theBestIndex = index;
                    finalDna = dnaSeqences;
                }
                else if (currDnaLenght == bestDnaLenght)
                {
                    if (currDnaStartIndex < theBestStartIndex)
                    {
                        bestDnaLenght = currDnaLenght;
                        theBestStartIndex = currDnaStartIndex;
                        theBestDnaSum = dnaSeqences.Sum();
                        theBestIndex = index;
                        finalDna = dnaSeqences;
                    }
                    else if (currDnaStartIndex == theBestStartIndex)
                    {
                        if (dnaSeqences.Sum() > theBestDnaSum)
                        {
                            bestDnaLenght = currDnaLenght;
                            theBestStartIndex = currDnaStartIndex;
                            theBestDnaSum = dnaSeqences.Sum();
                            theBestIndex = index;
                            finalDna = dnaSeqences;
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {theBestIndex} with sum: {theBestDnaSum}.");
            Console.WriteLine($"{string.Join(" ",finalDna)}");
        }
    }
}
