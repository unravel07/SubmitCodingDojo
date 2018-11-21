using System;
using System.Linq;

namespace Homework07.lib
{
    public class Homework07 : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var split = text.Split(' ');
            var distinct = split.Distinct().ToArray();
            Array.Sort(distinct);

            return distinct.ToString();
        }
    }
}
