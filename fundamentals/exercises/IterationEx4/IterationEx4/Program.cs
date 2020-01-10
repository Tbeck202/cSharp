using System;

namespace IterationEx4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between one and ten...");
            Console.WriteLine("Can you guess what it is in four tries?");
            
            var count = 4;
            var random = new Random();
            var match = random.Next(1, 10);

            while (count > 0)
            {
                var guess = int.Parse(Console.ReadLine());
                
                if (guess == match)
                {
                    Console.WriteLine("You win!!");
                    break;
                }
                else if (guess != match)
                {
                    Console.WriteLine("Nope!");
                    count--;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Sorry, you lose!");
            }
        }
    }
}
