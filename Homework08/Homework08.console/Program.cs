using System;

namespace Homework08.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number : ");
            var number = int.Parse(Console.ReadLine());
            var inputNumber = new Homework08();
            var newText = inputNumber.GetTriangleShapeAsText(number);
            Console.WriteLine(newText);
        }
    }
}
