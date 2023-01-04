using System;
using System.Text;

namespace P02.FromLefttoTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());

            while (nLines > 0)
            {
                string input = Console.ReadLine();
                bool isSecondNum = false;
                StringBuilder first = new StringBuilder();
                StringBuilder second = new StringBuilder();

                for (int i = 0; i <= input.Length-1; i++)
                {
                    char currChar = input[i];
                    if ( currChar == ' ')
                    {
                        isSecondNum = true;
                        continue;
                    }
                    if (!isSecondNum)
                    {
                        first.Append(input[i]);
                    }
                    else
                    {
                        second.Append(input[i]);
                    }                    
                }

                long numOne = long.Parse(first.ToString());
                long numTwo = long.Parse(second.ToString());

                if (numOne >= numTwo)
                {
                    long toPrintOne = 0;
                    int row = 0;
                    if (numOne < 0)
                    {
                        row = 1;
                    }
                    for (int i = row; i <= first.Length-1; i++)
                    {
                        char currChar = first[i];
                        string currNum = currChar.ToString();
                        long toCalculate = long.Parse(currNum);
                        toPrintOne+=toCalculate;
                    }
                    Console.WriteLine(toPrintOne);
                }

                else 
                {
                    long toPrintTwo = 0;
                    int row = 0;
                    if (numTwo < 0)
                    {
                        row = 1;
                    }
                    for (int i= row; i <= second.Length - 1; i++)
                    {
                        char currChar = second[i];
                        string currNum = currChar.ToString();
                        long toCalculate = long.Parse(currNum);
                        toPrintTwo += toCalculate;
                    }                    
                    Console.WriteLine(toPrintTwo);
                }
                nLines--;
            }       
        }
    }
}
