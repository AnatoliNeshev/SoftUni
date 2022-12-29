using System;

namespace EnglishNameoftheLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(NameOfLastDigit(num));
        }

        static string NameOfLastDigit(int num)
        {
            string input = num.ToString();
            string output = string.Empty;

            switch (input[input.Length-1])
            {
                case '0':
                    output = "zero";
                    break;
                case '1':
                    output = "one";
                    break;
                case '2':
                    output = "two";
                    break;
                case '3':
                    output = "three";
                    break;
                case '4':
                    output = "four";
                    break;
                case '5':
                    output = "five";
                    break ;
                case '6':
                    output = "six";
                    break;
                case '7':
                    output = "seven";
                    break;
                case '8':
                    output = "eight";
                    break;
                case '9':
                    output = "nine";
                    break;
                default:
                    break;
            }
            return output;
        }
    }
}
