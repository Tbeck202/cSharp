using System;
using System.Collections.Generic;

namespace StringEx4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a few words, separated by spaces.");
            var input = Console.ReadLine().ToLower();
            var print = "";

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("You gotta write something...");
            }
            
            foreach(var word in input.Split(' '))
            {
                var pascal = char.ToUpper(word[0]) + word.Substring(1);
                print += pascal;
            }

            Console.WriteLine(print);
        }
    }
}
