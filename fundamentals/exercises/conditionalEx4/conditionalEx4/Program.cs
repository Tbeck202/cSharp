using System;

namespace conditionalEx4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the speed limit in Km/H?");
            var limit = int.Parse(Console.ReadLine());
            Console.WriteLine("And how fast were you going?");
            var speed = int.Parse(Console.ReadLine());
            var check = speed - limit;
            var demerit = check / 5;

            if (demerit <= 0)
            {
                Console.WriteLine("You're OK!");
            }
            else if (demerit >= 1 && demerit < 12)
            {
                Console.WriteLine("You have accrued {0} demerits!", demerit);
            }
            else
            {
                Console.WriteLine("Your license has been supended!!!");
            }
        }
    }
}
