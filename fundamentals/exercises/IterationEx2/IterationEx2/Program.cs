using System;

namespace IterationEx2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("enter a number, or write \"ok\" to exit");
            var input = int.Parse(Console.ReadLine());
            var sum = 0;

            while (true)
            {
                var add = sum + input;
                sum += add;
                Console.WriteLine(sum);
            }
        }
    }
}
