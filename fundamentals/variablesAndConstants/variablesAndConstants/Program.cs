﻿using System;

namespace variablesAndConstants
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //byte number = 2;
            var number = 2;
            //int count = 10;
            var count = 10;
            //float totalPrice = 20.95f;
            var totalPrice = 20.95f;
            //char character = 'A';
            var character = 'A';
            //string firstName = "Tyler";
            var firstName = "Tyler";
            //bool isWorking = true;
            var isWorking = true;
            const float Pi = 3.14f;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine(Pi);
            
        }
    }
}


