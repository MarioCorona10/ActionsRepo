using CalculatorDotNet.Controllers;
using CalculatorDotNet.Models;

namespace OperationsTests
{
    public class OperationsTests
    {
        [Fact]
        public void DivideTest()
        {
            int n1 = 10;
            int n2 = 0;

            Assert.Throws<DivideByZeroException>(() => (n1/n2));

        }

        [Fact]
        public void AddTest()
        {
            int n1 = 8;
            int n2 = 2;

            Assert.Equal(10, n1 + n2);
        }

        [Fact]
        public void SubstractTest()
        {
            int n1 = 12;
            int n2 = 6;

            Assert.Equal(6, n1 - n2);
        }

        [Fact]
        public void MultiplyTest()
        {
            int n1 = 3;
            int n2 = 4;

            Assert.Equal(12, n1 * n2);
        }


    }
}