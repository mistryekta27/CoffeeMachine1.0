using System;

namespace CoffeeMachine.API.Helper
{
    public static class Constant
    {
        public static int DefaultAPICount = 5;

        public static int DefaultTemperature = 30;

        public static string ISODateFormat = "yyyy-MM-ddTHH:mm:ssK";

        public static DateTime DateToCompare = new DateTime(DateTime.Now.Year, 4, 1);

        public static string CoffeeSuccessMessage = "Your piping hot coffee is ready";

    }
}
