using System;

namespace Operators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            Console.WriteLine((float)a / (float)b);

            var aa = 1;
            var bb = 2;
            var cc = 3;
            Console.WriteLine((aa + bb) * cc);
            Console.WriteLine(aa > bb);
        }
    }
}
