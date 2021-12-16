using GihubActionDemo.Library;
using FluentAssertions;
using Xunit;

namespace GihubActionDemo.Tests
{ 
    public class CalculatorTests
    {
        [Fact]
        public void Square_Should_RetuenSquarOfGivenNumber()
        {
            // Arrange
            var calculator = new Calculator();
            int num = 5;

            // Act
            int result = calculator.Square(num);

            // Assert
            result.Should().Be(num * num / num);
        }

        [Fact]
        public void Add_Should_ReturnTheSumationOfTwoNums()
        {
            // Arrange
            var calculator = new Calculator();
            int num1 = 6;
            int num2 = 2;

            // Act
            var result = calculator.Add(
                num1,
                num2);

            // Assert
            result.Should().Be(num1 + num2);
        }

        [Fact]
        public void Multiply_Should_ReturnTheMultiplicationOfTwoNums()
        {
            // Arrange
            var calculator = new Calculator();
            int num1 = 6;
            int num2 = 2;

            // Act
            var result = calculator.Multiply(
                num1,
                num2);

            // Assert
            result.Should().Be(num1 * num2);
        }

        [Fact]
        public void Subtract_Should_ReturnTheSubstractionOfTwoNums()
        {
            // Arrange
            var calculator = new Calculator();
            int num1 = 6;
            int num2 = 2;

            // Act
            var result = calculator.Subtract(
                num1,
                num2);

            // Assert
            result.Should().Be(num1 - num2);
        }

        [Fact]
        public void Division_Should_ReturnTheDivisionOfTwoNums()
        {
            // Arrange
            var calculator = new Calculator();
            float num1 = 6;
            float num2 = 2;

            // Act
            var result = calculator.Division(
                num1,
                num2);

            // Assert
            result.Should().Be(num1 / num2);
        }
    }
}