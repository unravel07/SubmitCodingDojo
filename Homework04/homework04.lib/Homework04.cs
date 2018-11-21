using System;
using System.Linq;
using System.Text;

namespace homework04.lib
{
    public class Homework04 : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            var split = text.Split(',').Where(it => Convert.ToInt32(it, 2) % 5 == 0).ToArray();
            var result = string.Join(",",split);
            // var divBy5 = split.Where(it => Convert.ToInt32(it, 2) % 5 == 0).ToArray();
            // var result = string.Join(",", divBy5);
            return result;
 
        }
    }
}
