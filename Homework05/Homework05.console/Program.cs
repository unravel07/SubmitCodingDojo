using System;
using System.Collections.Generic;
using Homework05.lib;

namespace Homework05.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw05 = new Homework05Lib();
            hw05.listLED = new List<string>(new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" });
            hw05.listNoLED = new List<string>(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" });
            var noLed = "";

            while (true)
            {
                var disPlayLED = hw05.DisplayLEDOnScreen(noLed);
                Console.WriteLine(disPlayLED);
                Console.Write("Please choose LED to turn On/Off: ");
                noLed = Console.ReadLine();
            }

        }
    }
}
