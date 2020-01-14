using System;
using System.Collections.Generic;

namespace ListEx2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name??");
            var name = Console.ReadLine();
            var nameList = new List<char>();
            for (var i = 0; i < name.Length; i++)
            {
                nameList.Add(name[i]);
            }
            nameList.Reverse();
            string reversed = String.Join("", nameList);
            Console.WriteLine(reversed);
        }
    }
}
