using System;
using System.Collections.Generic;

namespace StringEx5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write a word!");
            var input = Console.ReadLine().ToLower();
            var characters = new List<char>();
            var count = 0;

            foreach(var letter in input)
            {
                characters.Add(letter);
            }

            foreach(var item in characters)
            {
                if (item == 'a' ||
                    item == 'e' ||
                    item == 'i' ||
                    item == 'o' ||
                    item == 'u')
                {
                    count++;
                } 
            }
            Console.WriteLine("There were {0} vowels in your word!", count);
        }
    }
}
