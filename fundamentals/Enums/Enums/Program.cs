using System;

namespace Enums
{
    public enum ShippingMethod
    {
        //IF NO VALUES ARE DECLARED, ENUM VALUES WILL BE AUTO ASSIGNED BEGINNsING WITH 0
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine(method); //OUTPUT IN THE CONSOLE WILL BE: Express
            // CASTED TO int
            Console.WriteLine((int)method); //OUTPUT IN THE CONSOLE WILL BE: 3

            //IN THIS NEXT EXAMPLE, WE'VE TAKEN A NUMERIC VALUE FROM SOMEWHERE ELSE (methodId)
            // AND THEN WE'VE CAST THAT VALUE, INTO A ShippingMethod VALUE
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); // THE OUTPUT TO THE CONSOLE IS: Express

            Console.WriteLine(method.ToString()); //OUTPUT IS: Express

            //IN THIS NEXT EXAMPLE, WE'VE TAKEN A STRING VALUE FROM SOMEWHERE ELSE (methodName)
            // AND THEN WE'VE CAST THAT VALUE, INTO A ShippingMethod ENUM VALUE
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

        }
    }
}
