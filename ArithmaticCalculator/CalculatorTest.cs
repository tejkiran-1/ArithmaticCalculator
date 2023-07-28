
using Xunit;

namespace ArithmaticCalculator
{

    public class CalculatorTest
    {
        private Calculator calc;
        public CalculatorTest()
        {
            calc = new Calculator();
        }

        [Fact]
        public void TestPlus()
        {
            calc.DisplayResult(1, "plus", 2);
        }

    }
}
