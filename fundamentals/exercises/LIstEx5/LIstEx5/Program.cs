using System;
using System.Collections.Generic;

namespace LIstEx5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var running = true;
            while (running)
            {
                Console.WriteLine("Please enter some numbers, seperated by a comma!");
                var input = Console.ReadLine();
                char[] seperators = { ',', ' ' };

                string[] nums = input.Split(seperators);
                var convertedNums = new List<int>();

                if (String.IsNullOrWhiteSpace(input) || nums.Length < 5)
                {
                    Console.WriteLine("Invalid list! Please try again.");
                    continue;
                }
                for (var i = 0; i < nums.Length; i++)
                {
                    var num = Convert.ToInt32(nums[i]);
                    convertedNums.Add(num);
                }
                convertedNums.Sort();
                Console.WriteLine("The three smallest numbers are: {0}, {1}, {2}", convertedNums[0], convertedNums[1], convertedNums[2]);
                Console.WriteLine("Press any key to quit.");
                Console.ReadLine();
                running = false;
            } 
        }
    }
}
