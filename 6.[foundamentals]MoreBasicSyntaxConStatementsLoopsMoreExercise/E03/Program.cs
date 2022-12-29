using System;
using System.Collections.Generic;

namespace GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double totalSpent = 0;

           Dictionary<string,double> gameTable = new Dictionary<string, double>()
           {   ["OutFall 4"] = 39.99,
               ["CS: OG"] = 15.99,
               ["Zplinter Zell"] = 19.99,
               ["Honored 2"] = 59.99,
               ["RoverWatch"] = 29.99,
               ["RoverWatch Origins Edition"] = 39.99 };

            string command;
            while((command = Console.ReadLine()) != "Game Time")
            {
               if (gameTable.ContainsKey(command))
               {
                    if (gameTable[command] > balance)
                    {
                        Console.WriteLine($"Too Expensive");
                        continue;
                    }
                    balance -= gameTable[command];
                    totalSpent += gameTable[command];
                    Console.WriteLine($"Bought {command}");
               }

               else
               {
                    Console.WriteLine($"Not Found");
               }

               if(balance <= 0)
               {
                    break;
               }
            }

            if (balance > 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}
