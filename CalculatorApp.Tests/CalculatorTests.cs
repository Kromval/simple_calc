// This is an independent project of an individual developer. 
// Dear PVS-Studio, please check it.
using Xunit;
using CalculatorApp;
namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calc = new Calculator();

        [Fact]
        public void Add_TwoPositiveNumbers()
        {
            Assert.Equal(5, _calc.Add(2, 3));
        }

        [Fact]
        public void Add_NegativeAndPositive()
        {
            Assert.Equal(-1, _calc.Add(-4, 3));
        }

        [Fact]
        public void Subtract_TwoPositiveNumbers()
        {
            Assert.Equal(2, _calc.Subtract(5, 3));
        }

        [Fact]
        public void Subtract_ReturnsNegative()
        {
            Assert.Equal(-2, _calc.Subtract(3, 5));
        }
    }
}