using System;

namespace P06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area =ReactangleArea(width, height);
            Console.WriteLine(area);
        }

        static double ReactangleArea(double width,double hight)
        {
            return(width* hight);
        }
    }
}
