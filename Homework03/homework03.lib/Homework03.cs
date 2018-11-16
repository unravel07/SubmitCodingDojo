using System;
using System.Collections.Generic;
using System.Linq;

namespace homework03.lib
{
    public class HomeWork03 : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text)
        {
            //var upperCase = text.Select(input => input.ToUpper());
            return text.Select(input => input.ToUpper());
        }
    }
}
