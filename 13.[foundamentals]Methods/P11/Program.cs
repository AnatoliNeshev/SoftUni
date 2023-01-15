using System;

namespace P11.Mathoperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            char theOperator = char.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());    
            double result = MathOperation(firstNum,theOperator,secondNum);
            Console.WriteLine(result);
        }

        static double MathOperation(double a,char @operator,double b)
        {
            double result = 0;

            switch (@operator)
            {
                case '/':
                    result = a / b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;   
            }
            return result;
        }
    }
}
