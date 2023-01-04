using System;
using System.Text;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            
            
                char currChar = 'P';
            int currInt = (int)currChar;
            currInt += 3;
            char newChar = (char)currInt;
            Console.WriteLine(newChar); 
        }
    }
}
