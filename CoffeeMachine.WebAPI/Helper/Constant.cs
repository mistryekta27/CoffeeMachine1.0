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

        public static string WeatherMessage = "Your refreshing iced coffee is ready";

        public static string WeatherUri = "https://api.openweathermap.org/data/2.5/weather?lat=35&lon=139&appid=55934a5f84461b93182d6df298b27527&units=metric";

    }
}
