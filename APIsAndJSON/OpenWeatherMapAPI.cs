using Newtonsoft.Json.Linq;

namespace OpenWeatherMap
{
    class WeatherMap
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            //var city = "Raleigh";
            var key = "09dc5001e466168c24e9f252d199152a";

            while (true)
            {
                Console.WriteLine();
                Console.Write("Please enter the city name: ");
                var city_name = Console.ReadLine();
                Console.WriteLine();

                var weatherURL = $"http://api.openweathermap.org/data/2.5/weather?q={city_name}&units=imperial&appid={key}";
                var response = client.GetStringAsync(weatherURL).Result;
                var formattedResponse = JObject.Parse(response).GetValue("main").ToString();
                object temp = null;
                Console.WriteLine($"The current Temperature is {temp} degrees Fahrenheit");
                //AddSpaces(2);
                Console.WriteLine("Would you like to exit?");
                var userInput = Console.ReadLine();
                //AddSpaces(2);

                if (userInput.ToLower().Trim() == "yes")
                {
                    break;
                }
            }
        }
        //static void AddSpaces(int numberOfSpaces)
        //{
        //    while (numberOfSpaces != 0)
        //    {
        //        Console.WriteLine();
        //        numberOfSpaces--;
        //    }
        //}


    }
}
