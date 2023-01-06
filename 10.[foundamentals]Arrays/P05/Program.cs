﻿using System;
using System.Linq;

namespace P05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] % 2 == 0)
            //    {
            //        sum += input[i];
            //    }
            //}

            foreach (int i in input)
            {
                if (i % 2 == 0)
                {
                    sum+=i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
