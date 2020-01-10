using System;

namespace Iterations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //PRINT ALL EVEN NUMBERS TO CONSOLE
            for (var i = 1; i <= 10; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            var j = 0;
            while(j <= 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }

            //PRINT EACH LETTER OF "NAME" TO CONSOLE
            var name = "John Smith";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach(var character in name)
            {
                Console.WriteLine(character);
            }

            //ITERATE THRU NUMBER ARRAY AND PRINT EACH NUMBER TO CONSOLE
            var numbers = new int[] { 1, 2, 3, 4 };
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            //PRINT USER INOUT TO CONSOLE. EXIT PROGRAM ONLY IF USER HITS ENTER WITH NO INPUT
            while (true)
            {
                Console.Write("What's your name? ");
                var userName = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(userName)) //END APP IF NO USER INPUT
                {
                    break;
                }

                Console.WriteLine(userName + "....Is there an echo in here?");
            }
        }
    }
}
