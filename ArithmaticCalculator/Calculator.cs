using System;

namespace ArithmaticCalculator
{
    public class Calculator
    {

        public void DisplayResult(double number1, string operation, double number2)
        {
            double result;
            switch (operation)
            {
                case "plus":
                    result = number1 + number2;
                    break;
                case "minus":
                    result = number1 - number2;
                    break;
                case "mod":
                    result = number1 % number2;
                    break;
                default:
                    Console.WriteLine("Invalid operation: " + operation);
                    return;
            }

            Console.WriteLine("{0}({1}, {2}) = {3}", operation, number1, number2, result);
        }
    }
}
