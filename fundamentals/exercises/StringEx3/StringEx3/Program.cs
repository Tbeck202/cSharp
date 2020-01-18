using System;

namespace StringEx3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var running = true;
            while (running)
            {
                Console.WriteLine("Enter a time in 24hr format.(eg. 19:00)");
                var input = Console.ReadLine();
                try
                {
                    var time = DateTime.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Invalid input! Did you remeber the colon?");
                    continue;
                }

                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                running = false;
            }
            
            Console.WriteLine("Okay!");
        }
    }
}
