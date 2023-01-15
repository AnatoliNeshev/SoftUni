using System;

namespace P08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            double powNum = double.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(baseNum,powNum));
        }

        static double MathPower (double basic,double pow)
        {
            double result = 1;
            //return Math.Pow(basic,pow);
            for (int i = 0; i < pow; i++)
            {
                result *= basic;
            }
            return result;
        }
    }
}
