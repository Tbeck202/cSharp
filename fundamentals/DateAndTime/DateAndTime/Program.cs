using System;

namespace DateAndTime
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var dateTime = new DateTime(2020, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.Hour);
            Console.WriteLine(now);
            Console.WriteLine(now.TimeOfDay);
            Console.WriteLine(now.Minute);
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("MM-dd-yyyy HH:mm"));
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(today);
            Console.WriteLine(tomorrow);
            Console.WriteLine(yesterday);

                //Create timespan

            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine("----------");
            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan1);
            Console.WriteLine(timeSpan2);
            Console.WriteLine("Duration: " + duration);

            // timespan properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total minutes; " + timeSpan.TotalMinutes);

            // add
            Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Add example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // convert ToString
            Console.WriteLine("ToString: "+ timeSpan.ToString());
        }
    }
}
