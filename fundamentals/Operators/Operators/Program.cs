﻿using System;

namespace Operators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            var c = 3;
            Console.WriteLine((float)a / (float)b); //3.333
            Console.WriteLine(c);

            var aa = 1;
            var bb = 2;
            var cc = 3;
            Console.WriteLine((aa + bb) * cc); //9
            Console.WriteLine(aa > bb); // false
            Console.WriteLine(aa == bb); // false
            Console.WriteLine(!(aa != bb)); // false

            Console.WriteLine(cc > bb && cc > aa); // true
            Console.WriteLine(cc < bb || cc > aa); // true
            Console.WriteLine(!(cc < bb || cc == aa)); // true
        }
    }
}