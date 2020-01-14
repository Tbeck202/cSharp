using System;
using System.Collections.Generic;

namespace ListEx3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.WriteLine("Please enter a number");
                var input = int.Parse(Console.ReadLine());

                if (numbers.IndexOf(input) == -1)
                {
                    numbers.Add(input);
                }
                else if (numbers.IndexOf(input) != -1)
                {
                    Console.WriteLine("You cannot repeat numbers");
                }
            }
            numbers.Sort();
            Console.WriteLine("--------");
            foreach (var num in numbers)
                Console.WriteLine(num);
        }
    }
}
