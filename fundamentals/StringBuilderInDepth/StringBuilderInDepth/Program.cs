using System;
using System.Text;

namespace StringBuilderInDepth
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello world!");

            builder
                .AppendLine()
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);
            Console.WriteLine(builder);

            builder.Replace('-', '+');
            Console.WriteLine(builder);

            Console.WriteLine("First char: " + builder[0]);
        }
    }
}
