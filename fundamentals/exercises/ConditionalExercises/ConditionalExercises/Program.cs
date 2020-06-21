using System;

namespace ConditionalExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var invalid = "I SAID BETWEEN ONE AND TEN YA' DINGUS";
            var valid = "Way to follow instructions :)";
            Console.WriteLine("Please enter a number between 1 & 10");
            var input = Convert.ToInt32(Console.ReadLine());
            if (input < 1 || input > 10)
            {
                Console.WriteLine(invalid);
            }
            else
            {
                Console.WriteLine(valid);
            }

            Console.WriteLine("=====================================");

            Console.WriteLine("Please enter a number.");
            var inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("One more number, please.");
            var inputTwo = Convert.ToInt32(Console.ReadLine());

            var result = (inputOne > inputTwo) ? "Your first number was bigger than your second number" : "The second number was bigger";
            Console.WriteLine(result);

            Console.WriteLine("=====================================");

            Console.WriteLine("Please enter the width of your picture");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the height of your picture");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = (width > height) ? "landscape" : "portrait";
            Console.WriteLine("Your photo has a width of {0} and a height of {1}. This means your photo is in {2} orientation.", width, height, orientation);

            Console.WriteLine("=====================================");

            Console.WriteLine("What is the speed limit?");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And how fast were you driving?");
            var speed = Convert.ToInt32(Console.ReadLine());
            var check = speed - speedLimit;

            if (check <= 0)
            {
                Console.WriteLine("Ok");
            }
            else if (check >= 5 && check < 12)
            {
                var demerit = check / 5;
                Console.WriteLine(@"You were driving {0} km/h above the speed limit of {1} km/h.
You have therefore been given {2} demerit point(s)", check, speedLimit, demerit);
            }
            else if (check >= 12)
            {
                var demerit = check / 5;
                Console.WriteLine(@"You were driving {0} km/h above the speed limit of {1} km/h.
You have therefore been given {2} demerit point(s) and your license is suspended!", check, speedLimit, demerit);
            }
            else 
            {
                Console.WriteLine(@"You were only driving {0} km/h above the speed limit of {1} km/h.
You have therefore been given no demerit point(s)", check, speedLimit);
            }

        }
    }
}
