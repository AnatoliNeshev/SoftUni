using System;
using System.Text;

namespace Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder message = new StringBuilder();

            for (int i = 0; i < n; i++)
            {               
                int command = int.Parse(Console.ReadLine());

                if (command == 0)
                {
                    message.Append(" ");
                }

                else
                {
                    string commandLenght = command.ToString();
                    int mainDigit = command % 10;
                    int numOfDIgits = commandLenght.Length;

                    int offset = (mainDigit - 2) * 3;
                    int letterIndex = LetterIndex(offset ,numOfDIgits ,mainDigit);

                    char currLetter = (char)(letterIndex + 97);

                    message.Append(currLetter);
                }                
            }

            Console.WriteLine(message.ToString());  
        }

        static int LetterIndex (int offset , int numOfDigits ,int mainDigit)
        {
            if (mainDigit == 9 || mainDigit == 8)
            {
                return offset + numOfDigits;
            }

            else
            {
                return offset + numOfDigits - 1;
            }
        }
    }
}
