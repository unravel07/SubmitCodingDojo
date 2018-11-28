using System;
using System.Text;

namespace work1
{
    public class TextSorting : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            var split = text.Split(',');
            Array.Sort(split);
            String textSort = string.Join(",",split);

            return textSort;
        }
    }
}
