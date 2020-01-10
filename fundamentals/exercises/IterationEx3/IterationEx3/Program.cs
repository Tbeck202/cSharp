using System;

namespace IterationEx3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and we'll find it's factorial!");
            var input = Console.ReadLine();
            var num = int.Parse(input);
            for (var i = num - 1; i > 0; i--)
            {
                num *= i;
            }
            Console.WriteLine("The factorial of {0} is: {1}!", input, num);
        }
    }
}
