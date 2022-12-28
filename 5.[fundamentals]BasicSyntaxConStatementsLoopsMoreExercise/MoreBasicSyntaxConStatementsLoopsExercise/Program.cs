using System;

namespace Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string toPrint = "";

            if (age >= 0 && age <= 2)
            {
                toPrint = "baby";
            }
            else if (age >=3 && age <= 13)
            {
                toPrint = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                toPrint = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                toPrint = "adult";
            }
            else if (age >= 66)
            {
                toPrint = "elder";
            }
            Console.WriteLine(toPrint);
        }
    }
}
