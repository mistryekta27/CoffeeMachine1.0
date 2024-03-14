using CoffeeMachine.API.Helper;
using CoffeeMachine.API.Interface;
using CoffeeMachine.API.Model;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoffeeMachine.API.Service
{
    public class CoffeeService : ICoffeeService
    {
        //Check for every 5th call to this API.
        public bool CheckAPICount(int apiCount)
        {
            if (apiCount == Constant.DefaultAPICount)
            {
                APICounter.ResetAPICount();
                return true;
            }
            return false;
        }

        //Compare current date with 1st April.
        public bool CompareDate(DateTime today)
        {
            //DateTime today = DateTime.Now;
            DateTime CompareToDate = Constant.DateToCompare;
            return today.Month == CompareToDate.Month && today.Day == CompareToDate.Day;
        }

        //Check for weather temperature is greter than 30`C.
        public async Task<bool> CheckTemperature()
        {
            HttpClient client = new HttpClient();
            string weatherUri = Constant.WeatherUri;
            var weatherResponse = await client.GetAsync(weatherUri);
            if (weatherResponse.IsSuccessStatusCode)
            {
                var stringResponse = await weatherResponse.Content.ReadAsStringAsync();
                var weatherResult = JsonSerializer.Deserialize<WeatherResponse>(stringResponse);
                if (weatherResult != null && weatherResult.main != null && weatherResult.main.temp > Constant.DefaultTemperature)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
