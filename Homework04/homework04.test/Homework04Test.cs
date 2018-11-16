using System;
using homework04.lib;
using Xunit;

namespace homework04.test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("0100,0011,1010,1001", "1010")]
        [InlineData("0100,0011,1010,0101", "1010,0101")]
        [InlineData("0100,0011,1010,1001,0101", "1010,0101")]

        public void Test1(string text, string expected)
        {
            var sut = new Homework04();
            var result = sut.GetDivisibleBy5Text(text);
            Assert.Equal(expected, result);

        }
    }
}
