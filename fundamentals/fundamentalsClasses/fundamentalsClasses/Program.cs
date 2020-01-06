using System;
using fundamentalsClasses.Math;

namespace fundamentalsClasses
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            var john = new Person();

            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
            var mult = calculator.Multiply(5, 5);
            Console.WriteLine(mult);
        }
    }
}
