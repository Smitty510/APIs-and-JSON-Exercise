using Newtonsoft.Json.Linq;



namespace APIsAndJSON
{

    public class RonVSKanyeAPI
    {
        public RonVSKanyeAPI(HttpClient client)
        {
            Client=client;
        }

        public HttpClient Client { get; }

        public static void KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"Kanye West: '{kanyeQuote}'");
        }
        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"Ron Swanson: '{ronQuote}'");
        }
    }
}
