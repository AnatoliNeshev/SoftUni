using System;

namespace Elevator

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nummPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Math.Ceiling((double)nummPeople / capacity)}"); 
        }
    }
}
