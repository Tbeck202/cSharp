using System;

namespace TypeConversion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            int i = 1000;
            byte b = (byte)i; //implicitly casted with data loss
            Console.WriteLine(b);

            string number = "1234";
            int ii = Convert.ToInt32(number);
            Console.WriteLine(ii);

            try
            {
                string numberTwo = "1234";
                byte iii = Convert.ToByte(numberTwo);
                Console.WriteLine(iii);
            }
            catch (Exception)
            {
                Console.WriteLine("Number could not be coverted to byte");
            }

            try
            {
                string str = "true";
                bool bb = Convert.ToBoolean(str);
                Console.WriteLine(bb);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
