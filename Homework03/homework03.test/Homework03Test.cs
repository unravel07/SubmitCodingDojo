using System;
using homework03.lib;
using Xunit;

namespace homework03.test
{
    public class Homework03Test
    {
         [Theory]
        [InlineData(new string[] {"Hello world","Practice makes perfect"}, new string[]{"HELLO WORLD","PRACTICE MAKES PERFECT"})]
        public void Test(string[] text, string[] expected)
        {
            {
                var sut = new HomeWork03();
                var result = sut.CapitalizedText(text);
                Assert.Equal(expected, result);
            }
        }
    }
}
