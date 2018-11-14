using System;
using System.Text;

namespace work1
{
    public class TextSorting : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            var spilt = text.Split(',');
            Array.Sort(spilt);
            String textSort = string.Join(",",spilt);

            return textSort;
        }
    }
}
