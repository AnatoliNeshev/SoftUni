using System;

namespace P01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                int integer ;
                float floating;
                char newChar;
                bool newBool;

                if (int.TryParse(input,out integer))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                            
                else if (float.TryParse(input,out floating))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                              
                else if (char.TryParse(input,out newChar))
                {
                    Console.WriteLine($"{input} is character type");
                }                
                
                else if (bool.TryParse(input,out newBool))
                {
                    Console.WriteLine($"{input} is boolean type");
                }    
                
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}
