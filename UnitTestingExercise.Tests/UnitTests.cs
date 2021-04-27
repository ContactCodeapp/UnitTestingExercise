using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(3, 4, 5, 12)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var a = new UnitTestMethods();

            //Act
            var actual = a.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 6, 2)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var s = new UnitTestMethods();

            //Act
            var actaul = s.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actaul);
             
        }

        [Theory]
        [InlineData(3, 7, 21)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var m = new UnitTestMethods();

            //Act
            var actual = m.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(72, 8, 9)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var d = new UnitTestMethods();

            //Act
            var actual = d.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            var f = new UnitTestMethods();

            //Act
            var actual = f.Fact1();

            //Assert
            Assert.Equal("Surf's Up!", actual);

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            var f2 = new UnitTestMethods();

            //Act
            var actual = f2.Fact2();

            //Assert
            Assert.Equal("Kook", actual);
        }
    }
}
