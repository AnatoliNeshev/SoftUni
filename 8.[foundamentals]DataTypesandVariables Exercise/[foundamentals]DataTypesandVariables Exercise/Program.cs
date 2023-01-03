using System;

namespace _foundamentals_DataTypesandVariables_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 919;
            string test = number.ToString();
            int curr = 1;

            int theNum = int.Parse(test);
            
            Console.WriteLine(test);
        }
    }
}
