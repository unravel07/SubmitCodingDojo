using System;

namespace Homework07.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input text: ");
            var input = Console.ReadLine();
            var hw07 = new Homework07();
            var showText = hw07.RemoveAndSortTextByAlphabetical(input);
            Console.Write(showText);
        }
    }
}
