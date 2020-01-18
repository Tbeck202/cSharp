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
            var pascal = new List<string>();

            for(var i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    pascal.Add(input[i + 1].ToString().ToUpper());
                    i++;
                    continue;
                }
                pascal.Add(input[i].ToString());
            }
            Console.WriteLine(pascal.ToString());
            //foreach(var character in pascal)
            //{
                //Console.Write(character);
            //}
        }
    }
}
