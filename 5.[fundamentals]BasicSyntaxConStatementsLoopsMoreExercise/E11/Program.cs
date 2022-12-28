using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double finalPrice = 0;
            for (int i = 1; i <= n; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse((Console.ReadLine()));
                int capsulesCount = int.Parse((Console.ReadLine()));
                double cofeePrice = ((days * capsulesCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${cofeePrice:f2}");
                finalPrice+=cofeePrice;
            }
            Console.WriteLine($"Total: ${finalPrice:f2}");
        }
    }
}
