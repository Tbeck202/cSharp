using System;

namespace conditionalEx2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            int inputOne = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number!");
            int inputTwo = Int32.Parse(Console.ReadLine());

            var max = (inputOne > inputTwo) ? inputOne : inputTwo;
            Console.WriteLine(max + " is the maximum");
        }
    }
}
