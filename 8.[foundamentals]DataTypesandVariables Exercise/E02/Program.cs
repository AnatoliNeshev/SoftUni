using System;
using System.Text;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int num = int.Parse(Console.ReadLine());
            int sum = 0;            
            string number = num.ToString();
            StringBuilder currNum = new StringBuilder();

            for (int i = number.Length-1 ; i >= 0; i--)
            {
                currNum.Append(number[i]);
                string toTake = currNum.ToString();
                int theNumberWeSearchFor = int.Parse(toTake);
                sum += theNumberWeSearchFor;
                currNum = new StringBuilder();             
            }

            Console.WriteLine(sum); 
        }
    }
}
