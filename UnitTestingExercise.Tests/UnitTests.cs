using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,1,1,3)]
        [InlineData(1, -1, 1, 1)]
        [InlineData(0,0,0,0)]
        [InlineData(100, 1000, 10000, 11100)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            //This creates a method to test
            UnitTestMethods sut = new UnitTestMethods();

            //Act
            int actual = sut.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8,5,3)]
        [InlineData(10, -5, 15)]
        [InlineData(-10, -5, -5)]
        [InlineData(0,0,0)]
        [InlineData(10, 100, -90)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();

            //Act
            int actual = sut.Subtract(minuend,subtrhend);

            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(-2, -2, 4)]
        [InlineData(-2, 2, -4)]
        [InlineData(0, 0, 0)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();

            //Act
            int actual = sut.Mutiply(num1,num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,2)]
        [InlineData(10, -5, -2)]
        [InlineData(10, 0, -1)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();

            //Act
            int actual = sut.Divide(num1,num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetHello()
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            string actual = sut.GetHello();
            //Assert
            Assert.Equal("Hello!", actual);
        }

        [Fact]
        public void SayGoodbye()
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();

            //Act
            string actual = sut.SayGoodbye();

            //Assert
            Assert.Equal("Goodbye!", actual);
        }
    }
}
