using System;

namespace SecretDoorsLock
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numHun = int.Parse(Console.ReadLine());
           int numTen = int.Parse(Console.ReadLine());
           int numOne = int.Parse(Console.ReadLine());
            
           

            for (int hun = 1; hun <= numHun; hun++)
             {
                for (int ten = 1; ten <= numTen; ten++)
                {
                    int second = 0;
                    int counter = 0;
                    for (int i = 1; i <= ten; i++)
                    {
                        if (ten % i == 0)
                        {
                            counter++;
                        }
                    }
                    if (counter == 2)
                    {
                        second = ten; 
                    }
                    counter = 0;

                    for (int one = 1; one <= numOne; one++)
                    {
                        int first = 0;   
                        int third = 0;
                        if (hun % 2 == 0)
                        {
                            first = hun;
                        }
                        if (one % 2 == 0)
                        {
                            third = one;
                        }
                        if (first != 0 && second != 0 && third != 0)
                        {
                            Console.WriteLine($"{first} {second} {third}");
                        }
                    }
                }                
            }               
        }
    }
}
