using System;
using System.Text;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            bool toDo = false;
            StringBuilder pass = new StringBuilder();
            int passCounter = 0;
            
            while (!toDo)
            {
                string password = Console.ReadLine();
                for (int i=name.Length -1; i >= 0; i--)
                {
                    pass.Append(name[i]);
                }
                passCounter++;
                string test = pass.ToString();
                if (passCounter > 3 && test != password)
                {
                    Console.WriteLine($"User {name} blocked!");
                    toDo = true;
                    continue;
                }
                if (test == password)
                {
                    Console.WriteLine($"User {name} logged in.");
                    toDo = true;
                    continue;
                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
              pass = new StringBuilder();             
            }
        }
    }
}
