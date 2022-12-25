using System;

namespace Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bottlesNum = int.Parse(Console.ReadLine());
            string input = "";
            double detergent = bottlesNum * 750;
            double counterDetergent = 0;
            int rowCounter=0;
            int counterPot = 0;
            int counterDish = 0;

            while ((input = Console.ReadLine()) != "End" && detergent >= counterDetergent)               
            {
                rowCounter++;
                if (rowCounter % 3 == 0)
                {
                    counterDetergent += int.Parse(input) * 15;
                    counterPot+=int.Parse(input);
                }
                else
                {
                    counterDetergent += int.Parse(input) * 5;
                    counterDish += int.Parse(input);
                }

            }
            if (detergent >= counterDetergent)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{counterDish} dishes and {counterPot} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergent-counterDetergent} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {counterDetergent-detergent} ml. more necessary!");
            }
        }
    }
}
