using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5,5,5,15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,5)]
        [InlineData(12,6,6)]
        [InlineData(5,5,0)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,10,100)]
        [InlineData(5,5,25)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6,6,1)]
        [InlineData(30,5,6)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetHelloWorld()
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.GetHelloWorld();
            //Assert
            Assert.Equal("Hello World!", actual);
        }

        [Fact]
        public void GetColorOfSky()
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.GetColorOfSky();
            //Assert
            Assert.Equal("blue", actual);
        }
    }
}
