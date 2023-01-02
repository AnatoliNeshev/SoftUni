using System;

namespace ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimitier = Console.ReadLine();

            Console.WriteLine(@$"{firstName}{delimitier}{lastName}");
        }
    }
}
