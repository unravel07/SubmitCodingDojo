using System;
using work1;
using Xunit;

namespace test1
{
    public class TestTextSorting
    {
        [Theory]
        [InlineData("without,hello,bag,world", "bag,hello,without,world")]
        [InlineData("wheel,house,bat,ant", "ant,bat,house,wheel")]
        [InlineData("ant,air,ate,aaa", "aaa,air,ant,ate")]
        public void Test1(string text,string expected)
        {
            var sut = new TextSorting();
            var result = sut.SortByAlphabetical(text);
            Assert.Equal(expected, result);

        }
    }
}
