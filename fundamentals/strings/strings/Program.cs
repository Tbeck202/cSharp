using System;

namespace strings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var firstName = "Tyler"; // SAME AS string firstName = "Tyler";
            var lastName = "Beck"; 

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName); //{0{ MAPS TO firstName AND {1} MAPS TO {lastName}
            Console.WriteLine(fullName);
            Console.WriteLine(myFullName);

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

            Console.WriteLine("==============================================");

            var places = new string[3] { "Salt Lake City", "Austin", "Portland" };
            var allPlaces = string.Join(", ", places);

            var teams = new string[3] { "Jazz", "Utes", "Real Salt Lake" };
            var allTeams = string.Join(", ", teams);

            var myInfo = string.Format(@"Hi, my name is {0}. I have lived in the following places: {1}.
My favorite sports teams are: {2}.", fullName, allPlaces, allTeams);
            Console.WriteLine(myInfo);

        }
    }
}
