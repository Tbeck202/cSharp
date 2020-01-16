using System;
using System.Collections.Generic;

namespace StrinEx1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter some numbers, seperated by hyphens.");
            var input = Console.ReadLine().Split('-');
            var nums = new List<int>();
            var sorted = new List<int>();
            var match = true;

            foreach(var num in input)
            {
                nums.Add(Convert.ToInt32(num));
                sorted.Add(Convert.ToInt32(num));
            }
            sorted.Sort();

            for(var i = 0; i < nums.Count; i++)
            {
                if (nums[i] != sorted[i])
                {
                    Console.WriteLine("NOT CONSECUTIVE!");
                    match = false;
                    break;
                }
            }

            if (match)
                Console.WriteLine("CONSECUTIVE!!");
            
        }
    }
}
