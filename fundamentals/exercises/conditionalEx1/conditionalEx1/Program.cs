using System;

namespace conditionalEx1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int input = Int32.Parse(Console.ReadLine());

            if (input < 0 || input > 10)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid!");
            }
        }
    }
}
