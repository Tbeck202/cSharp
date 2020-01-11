using System;

namespace Arrays2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numbers = new[] { 3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            //Clear() - SETS INT TO 0 - BOOL TO FALSE - STRING AND OTHER TYPES OF OBJECTS TO NULL
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear():");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Copy()
            int[] anotherArray = new int[3];
            Array.Copy(numbers, anotherArray, 3);
            Console.WriteLine("Effect of Copy(): ");

            foreach (var n in anotherArray)
                Console.WriteLine(n);

            // Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort():");
            foreach (var n in numbers)
                Console.WriteLine(n);

            string[] letters = new[] { "beer", "candy", "apples", "dogs", "aaron", "about", "action" };

            Array.Sort(letters);

            Console.WriteLine("Sort() letters:");
            foreach (var n in letters)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse(): ");
            foreach (var n in numbers)
                Console.WriteLine(n);

            
        }
    }
}
