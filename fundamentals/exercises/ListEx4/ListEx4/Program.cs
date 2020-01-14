using System;
using System.Collections.Generic;

namespace ListEx4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number! (Or type \"Quit\" to exit)");
                var input = Console.ReadLine().ToLower();

                if (input == "quit")
                    break;
                
                var toNum = Convert.ToInt32(input);
                numbers.Add(toNum);
                
            }

            var display = new List<int>();
            foreach (var num in numbers)
            {
                if (!display.Contains(num))
                    display.Add(num);
            }
            foreach (var n in display)
                Console.WriteLine(n);
        }
    }
}
