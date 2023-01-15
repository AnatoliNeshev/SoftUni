﻿using System;

namespace P09.GreaterofTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();


            if (type == "int")
            {
               int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMAx(first, second));
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }
        }

        static int GetMAx(int first,int second)
        {
            return (first>second) ? first : second;
        }
        static char GetMax(char first,char second)
        {
            return (first > second) ? first : second;
        }
        static string GetMax(string first,string second)
        {
            if (first.CompareTo(second)>0)
            {
                return first;
            }           
                return second;            
        }
    }
}
  