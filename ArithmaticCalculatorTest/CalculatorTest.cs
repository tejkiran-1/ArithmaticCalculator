
using ArithmaticCalculator;
using Xunit;

namespace ArithmaticCalculatorTest
{
    public class CalculatorTest
    {
        private Calculator calc;
        int num1 = 10;
        int num2 = 20;

        public CalculatorTest()
        {
            calc = new Calculator();
        }


        [Fact]
        public void TestPlus()
        {
            double res;
            calc.DisplayResult(num1, "plus", num2, out res);

            Assert.Equal(30, res);
        }

        [Fact]
        public void TestMinus()
        {
            double res;
            calc.DisplayResult(num1, "minus", num2, out res);

            Assert.Equal(-10, res);
        }

        [Fact]
        public void TestMod()
        {
            double res;
            calc.DisplayResult(num1, "mod", num2, out res);

            Assert.Equal(10, res);
        }

        [Fact]
        public void TestInvalidOperation()
        {
            double res;
            calc.DisplayResult(num1, "FooFoo", num2, out res);

            Assert.Equal(0, res);
        }



    }
}
