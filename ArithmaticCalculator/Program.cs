
using System;

namespace ArithmaticCalculator
{
    public class Program
    {
        static void Main()
        {

            var calc = new Calculator();
            double result;
            calc.DisplayResult(1, "plus", 2, out result);
            calc.DisplayResult(1, "minus", 2, out result);
            calc.DisplayResult(1, "mod", 2, out result);
            calc.DisplayResult(1, "Tejkiran", 2, out result);
            calc.DisplayResult(1, "plus", 2, out result);

            Console.ReadLine();

        }
    }
}