using System;
using System.Collections.Generic;

namespace StringEx2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var running = true;
            var check = new List<string>();
            while (running)
            {
                Console.WriteLine("Please enter some numbers separated by hyphens");
                var input = Console.ReadLine();
                var nums = input.Split('-');

                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("You must enter something!");
                }  

                foreach (var num in nums)
                {
                    if (check.Contains(num))
                    {
                        Console.WriteLine("{0} is a Duplicate!", num);
                        break;
                    }
                    check.Add(num);
                }

                if(check.Count == nums.Length)
                {
                    Console.WriteLine("No duplicates");
                }
                running = false;
            }
        }
    }
}
