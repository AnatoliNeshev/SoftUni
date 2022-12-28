using System;

namespace PadawanEquipment 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double johnMoney = double.Parse(Console.ReadLine());
            int numStudents = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            int sixtBeltCounter = 0;

            for (int i = 1; i <= numStudents; i++)
            {
                if (i % 6 == 0)
                {
                    sixtBeltCounter++;
                }
            }

            double finalRobePrice = robePrice * numStudents;
            double finalSaberPrice = (numStudents + (Math.Ceiling(numStudents * 0.1)))*lightSaberPrice;
            double finalBeltPrice = (numStudents - sixtBeltCounter) * beltPrice;
            double finalPrice = finalBeltPrice + finalRobePrice + finalSaberPrice;

            if (finalPrice <= johnMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {finalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {finalPrice-johnMoney:f2}lv more.");
            }
        }
    }
}
