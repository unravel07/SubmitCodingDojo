using System;
using System.Linq;
using System.Text;

namespace homework2.lib
{
    public class TextMultiplier : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            var split = text.Split(',');
            var multiple = split.Select(it => (int.Parse(it) * 11).ToString());
            var array = multiple.ToArray();
            var newText = new StringBuilder();

            newText.Append("[\n");
            for (int i = 0; i < split.Length; i++)
            {
                if (i == split.Length - 1)
                {
                    newText.Append("\t").Append(array[i]).Append("\n");
                }
                else
                {
                    newText.Append("\t").Append(array[i]).Append(",").Append("\n");

                }
            }
            newText.Append("]");

            return newText.ToString();
        }

    }
}