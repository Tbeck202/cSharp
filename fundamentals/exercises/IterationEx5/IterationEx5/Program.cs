using System;

namespace IterationEx5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers, seperated by commas.");
            var input = Console.ReadLine();

            int max = 0;

            for (var i = 0; i < input.Length; i++)
            {
                var toString = input[i].ToString();
                int num;
                
                if (int.TryParse(toString, out num))
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
