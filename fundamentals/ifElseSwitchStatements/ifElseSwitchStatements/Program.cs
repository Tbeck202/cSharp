using System;

namespace ifElseSwitchStatements
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            // IF/ELSE STATEMENTS-----------------------------------------------------
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning!");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Good afternoon.");
            } 
            else
            {
                Console.WriteLine("It's night time!!");
            }

            // CONDITIONAL STATEMENT-----------------------------------------------------
            bool isGoldCustomer = true;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine("$" + price);

            var season = Season.Autumn;

            //SWITCH CASE-----------------------------------------------------
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn! Yay!");
                    break;

                case Season.Summer:
                    Console.WriteLine("Summer time is beach time!");
                    break;

                default:
                    Console.WriteLine("I only like summer and autumn.");
                        break;
            }

            switch (season)
            {
                case Season.Autumn:    // AUTMUN AND SUMMER WILL DISPLAY THE SAME MESSAGE
                case Season.Summer:
                    Console.WriteLine("We've got a promotion! Yay for savings.");
                    break;

                default:
                    Console.WriteLine("I only like summer and autumn.");
                    break;
            }
        }
    }
}
