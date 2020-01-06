using System;

namespace strings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var firstName = "Tyler";
            var lastName = "Beck";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(" & ", names);
            Console.WriteLine(formattedNames);

            var text = "Hi John,\nplease look into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);

            //verbatim string. prefix string with @ symbol
            var textTwo = @"Hi John 
Please look into the following paths:
c:\folder\subfolder1\subfolder2
c:\desktop\projects\projects2";
            Console.WriteLine(textTwo);
        }
    }
}
