using System;

namespace StringsInDepth
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var fullName = "Tyler Beck ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First name: " + names[0]);
            Console.WriteLine("Last name: " + names[1]);

            Console.WriteLine(fullName.Replace("Tyler", "Fuzzy"));
            Console.WriteLine(fullName.Replace("l", "g"));
            Console.WriteLine(fullName.Replace("ler", " "));

            if (String.IsNullOrWhiteSpace(" ")) 
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine("Age: " + age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C")); // converts to string with decimal
            Console.WriteLine(price.ToString("C0")); // Rounds up and converts to string with no decimal
        }
    }
}
