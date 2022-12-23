using System;

namespace WeddingSeats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowsFirstSector = int.Parse(Console.ReadLine());
            int seatsOddrow = int.Parse(Console.ReadLine());
            int currSeats = 0;
            int seatCounter = 0;
            for (int i = 'A'; i <= lastSector; i++)
            {  
                for (int row =1; row <= rowsFirstSector; row++)
                {
                    if (row % 2 == 0)
                    {
                        currSeats = seatsOddrow + 2;
                    }
                    else
                    {
                        currSeats = seatsOddrow;
                    }
                    for (int seat = 1; seat <= currSeats; seat++)
                    {
                        seatCounter++;
                        Console.Write($"{(char)i}{row}{(char)(seat+96)}");     
                        Console.WriteLine();
                    }
                }
                rowsFirstSector += 1;
            }
            Console.WriteLine(seatCounter);
        }
    }
}
