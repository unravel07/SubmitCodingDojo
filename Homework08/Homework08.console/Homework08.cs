using System;
using System.Text;

namespace Homework08.console
{
    public class Homework08 : IHomework08
    {
        public string GetTriangleShapeAsText(int input)
        {
            var triangle = new StringBuilder();

            for (int i = 1; i <= input; i++)
            {
                var space1 = new string(' ', input - i);
                var space2 = new string(' ', i - 1);

                triangle = (i == input)
                ? triangle.AppendLine().Append('/').Append('_', input - 1).Append('|')
                : triangle.AppendLine().Append(space1).Append('/')
                          .Append(space2).Append('|');
            }
            return triangle.ToString();
        }
    }
}