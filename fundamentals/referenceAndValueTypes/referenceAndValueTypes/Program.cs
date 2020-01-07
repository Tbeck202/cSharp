using System;

namespace referenceAndValueTypes
{
    public class Person
    {
        public int Age;
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var a = 10; 
            var b = a; 
            b++;                                                        // a stays ten
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));   // b increments to 11

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;                                                                          // values at 0 index in both arrays are changed
            Console.WriteLine(string.Format("array 1: {0}, array2: {1}", array1[0], array2[0]));    // because arrays are a reference type

            var number = 1;
            Increment(number);
            Console.WriteLine("Number outside of increment method: " + number); // number stays 1 because the number variable inside increment method is stored in a different place in memory

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age); // person.Age increments by ten because the reference in memory is passed to the method
        }

        public static void Increment(int number)
        {
            number += 10;
            Console.WriteLine("Number from the increment method: " + number);
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
