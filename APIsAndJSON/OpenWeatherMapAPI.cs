using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace OpenWeatherMap
{
    internal class WeatherMap
    {
        public static void Weather()
        {
            IConfiguration config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .Build();
            var key = "09dc5001e466168c24e9f252d199152a";

            var client = new HttpClient();

            Console.Write("Please enter the city name: ");
            var cityName = Console.ReadLine();





            var weatherURL = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&units=imperial&appid={key}";
            string response = client.GetStringAsync(weatherURL).Result;
            JObject weatherObject = JObject.Parse(response);
            Console.WriteLine($"It is {weatherObject["main"]["temp"]} degrees Fahrenheit in {cityName}");
        }


    }
}

