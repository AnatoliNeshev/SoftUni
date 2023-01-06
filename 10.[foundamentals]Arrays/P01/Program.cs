using System;

namespace P01DayofWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dayWeek = new string[8] { "", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int input = int.Parse(Console.ReadLine());

            if (input > 0 && input < dayWeek.Length)
            {
                Console.WriteLine(dayWeek[input]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
