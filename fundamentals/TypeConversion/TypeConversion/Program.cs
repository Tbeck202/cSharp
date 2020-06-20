using System;
using System.Globalization;

namespace TypeConversion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //byte b = 1;
            //int i = b;
            int i = 1000;
                //CAST (meaning force) THE INT TO A BYTE BECAUSE BYTE IS SMALLER THAN INT
            byte b = (byte) i; // THE OUTPUT HERE IS 232 BECAUSE A BYTE CAN ONLY HOLD UP TO 255 AND SOME OF THE DATA WAS LOST WHEN WE CAST THE INT TO A BYTE
            Console.WriteLine(b);

            var number = "1234";
            int ii = Convert.ToInt32(number);
            Console.WriteLine(ii);

            //var numberTwo = "1234";
            //byte bb = Convert.ToByte(numberTwo);
            //Console.WriteLine(bb); //THIS WILL THROW AN ERROR (CALLED EXCEPTIONS IN C#)

            try
            {
                var numberThree = "1234";
                byte bbb = Convert.ToByte(numberThree);
                Console.WriteLine(bbb);
            }
            catch (Exception)
            {
                Console.WriteLine("Number too big, dummy!");
            }

            string str = "true";
            bool bbbb = Convert.ToBoolean(str);
            Console.WriteLine(bbbb);
        }
    }
}
