using System;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
           string[] strings = new string[input.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = input[i].ToString();
            }
            Array.Reverse(strings);
            Console.WriteLine(String.Join("",strings));            
        }
    }
}
