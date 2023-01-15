using System;
using System.Text;

namespace P07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(input, n));
            
        }

        static string RepeatString (string input,int times)
        {
            string result = string.Empty;
            StringBuilder stringbuilder = new StringBuilder();

            for (int i = 0; i < times ; i++)
            {
                stringbuilder.Append(input);        
            }
            return stringbuilder.ToString();
        }
    }
}
