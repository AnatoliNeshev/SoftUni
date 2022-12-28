using System;

namespace RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());       
            int HeadsetHitCounter = 0;
            int mouseHitCounter = 0;
            int keyBoardHitCounter = 0;
            int displayHitCounter = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    HeadsetHitCounter++;
                    if (i % 3 == 0)
                    {
                        keyBoardHitCounter++;
                        if (keyBoardHitCounter > 1 && keyBoardHitCounter % 2 == 0)
                        {
                            displayHitCounter++;
                        }
                    }
                }
                if (i % 3 == 0)
                {
                    mouseHitCounter++;
                }           
            }
            double finalCost = (HeadsetHitCounter*headsetPrice) + (mouseHitCounter*mousePrice) + (keyBoardHitCounter*keyboardPrice) + (displayHitCounter*displayPrice);
            Console.WriteLine($"Rage expenses: {finalCost:f2} lv.");
        }
    }
}
