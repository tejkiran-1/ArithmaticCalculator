
using System;

namespace ArithmaticCalculator
{
    public class Program
    {
        static void Main()
        {

            Calculator calc = new Calculator();

            calc.DisplayResult(1, "plus", 2);
            calc.DisplayResult(1, "minus", 2);
            calc.DisplayResult(1, "mod", 2);
            calc.DisplayResult(1, "Tejkiran", 2);

            Console.ReadLine();

        }
    }
}