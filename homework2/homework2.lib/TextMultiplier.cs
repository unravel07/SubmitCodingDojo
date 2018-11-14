using System;
using System.Linq;
using System.Text;

namespace homework2.lib
{
    public class TextMultiplier : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            var array = text.Split(',').Select(it => (int.Parse(it) * 11).ToString()).ToArray();
            // var multiple = split.;
            // var array = multiple.ToArray();
            var newText = new StringBuilder();

            var gd = string.Join(",\n\t", array);
            //newText.Append("[\n\t").Append(gd).Append("\n]");
            newText.Append($"[\n\t{gd}\n]");
            // for (int i = 0; i < split.Length; i++)
            // {
            //     if (i == split.Length - 1)
            //     {
            //         newText.Append("\t").Append(array[i]).Append("\n");
            //         string.Join()
            //         //newText.Append($"\t{array[i]}\n");
            //     }
            //     else
            //     {
            //         newText.Append("\t").Append(array[i]).Append(",").Append("\n");

            //     }
            // }
            return newText.ToString();
        }

    }
}