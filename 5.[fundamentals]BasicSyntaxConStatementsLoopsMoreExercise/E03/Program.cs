using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();   
            string day = Console.ReadLine();
            double prise = 0;

            if (type == "Students")
            {
                switch (day)
                {
                    case "Friday":
                        prise = 8.45;
                        break;
                    case "Saturday":
                        prise = 9.80;
                        break;
                    case "Sunday":
                        prise = 10.46;
                        break;
                }
                prise *= people;
                if (people >= 30)
                {
                    prise -= (prise * 0.15); 
                }
                Console.WriteLine($"Total price: {prise:f2}");
            }
            if (type == "Regular")
            {
                switch (day)
                {
                    case "Friday":
                        prise = 15;
                        break;
                    case "Saturday":
                        prise = 20;
                        break;
                    case "Sunday":
                        prise = 22.5;
                        break;                        
                }
                prise *= people;
                if (people >= 10 && people <=20)
                {
                    prise -= (prise * 0.05);
                }
                Console.WriteLine($"Total price: {prise:f2}");
            }
            if (type == "Business")
            {
                switch (day)
                {
                    case "Friday":
                        prise = 10.9;
                        break;
                    case "Saturday":
                        prise = 15.6;
                        break;
                    case "Sunday":
                        prise = 16;
                        break;
                }              
                if (people >= 100)
                {
                    people -= 10;
                }
                prise *= people;

                    Console.WriteLine($"Total price: {prise:f2}");
            }
        }
    }
}
