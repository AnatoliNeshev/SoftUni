using System;
using System.Text;

namespace P05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            StringBuilder word = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                char newChar = char.Parse(Console.ReadLine());
                int currInt = (int)newChar+key;
                char currChar = (char)currInt;
                word.Append(currChar);
            }
            Console.WriteLine(word.ToString());
        }
    }
}
