using System;

namespace RandomClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            for(var i = 0; i < 3; i++)
            {
                //Console.WriteLine(random.Next());
                //Console.WriteLine(random.Next(100));
                //Console.WriteLine(random.Next(1, 10));
                Console.Write((char)random.Next(97, 122)); //RANDOM INT BETWEEN 97 & 122, CASTED TO THE EQUIVALENT ASCII CHAR
            }
            Console.WriteLine();

            var passwordLength = 10;
            var buffer = new char[passwordLength];
            for(var j = 0; j < passwordLength; j++)
            {
                buffer[j] = (char)('a' + random.Next(0, 26));
            }
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
