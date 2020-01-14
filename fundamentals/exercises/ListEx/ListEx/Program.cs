using System;
using System.Collections.Generic;

namespace ListEx
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var isRunning = true;
            var names = new List<string>();
            while (isRunning)
            {
                Console.WriteLine("Enter a name!");
                var name = Console.ReadLine();
                if (name == "")
                {
                    isRunning = false;
                }
                names.Add(name);
            }

            for (var i = 0; i < names.Count; i++)
                if (names[i] == "")
                    names.Remove(names[i]);
            
            if (names.Count == 1)
            {
                Console.WriteLine(names[0] + " Liked your post!");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine("{0} and {1} liked your post!", names[0], names[1]);
            }
            else if (names.Count > 2)
            {
                var others = names.Count - 2;
                Console.WriteLine("{0}, {1} and {2} others liked your post!", names[0], names[1], others);
            }
            else
            {
                Console.WriteLine("Sorry, your post has no likes yet.");
            }
        }
    }
}
