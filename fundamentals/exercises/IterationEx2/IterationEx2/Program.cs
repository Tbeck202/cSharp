using System;

namespace IterationEx2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var sum = 0;
            
            while (true)
            {
                Console.WriteLine("enter a number, or write \"ok\" to exit");
                var input = Console.ReadLine();

                if (input == "ok")
                {
                    Console.WriteLine("All your numbers add up to: " + sum);
                    break;
                }
                else if (input != "ok")
                {
                    var inputToNum = int.Parse(input);
                    sum += inputToNum;
                }
            }
        }
    }
}
