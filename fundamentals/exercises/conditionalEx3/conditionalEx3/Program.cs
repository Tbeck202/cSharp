using System;

namespace conditionalEx3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for width!");
            var width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number for height!");
            var height = int.Parse(Console.ReadLine());

            var orientation = (width > height) ? "Landscape" : "Portrait";
            Console.WriteLine("The orientation of your photo is: " + orientation);
        }
    }
}
