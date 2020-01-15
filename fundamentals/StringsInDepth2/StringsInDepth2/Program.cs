using System.Collections.Generic;
using System;

namespace StringsInDepth2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really really really really really long text";
            var summary = StringUtility.SummerizeText(sentence);
            Console.WriteLine(summary);
        }
    }
}
