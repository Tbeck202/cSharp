using System;

namespace IterationEx5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers, seperated by commas.");
            var input = Console.ReadLine();
            var numbers = new char[input.Length];
            var max = new int[input.Length];

            for (var i = 0; i < input.Length; i++)
            {
                numbers[i] = input[i];
            }
            Console.WriteLine(numbers);
        }
    }
}
