namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //RonVSKanyeAPI.KanyeQuote();
            //RonVSKanyeAPI.RonQuote();
            //RonVSKanyeAPI.KanyeQuote();
            //RonVSKanyeAPI.RonQuote();
            //RonVSKanyeAPI.KanyeQuote();
            //RonVSKanyeAPI.RonQuote();
            //RonVSKanyeAPI.KanyeQuote();
            //RonVSKanyeAPI.RonQuote();
            //RonVSKanyeAPI.KanyeQuote();
            //RonVSKanyeAPI.RonQuote();

            var client = new HttpClient();
            var quote = new RonVSKanyeAPI(client);

            for (int i = 0; i <= 5; i++)
            {
                RonVSKanyeAPI.KanyeQuote();
                RonVSKanyeAPI.RonQuote();
                Console.WriteLine("-------------------");
                Console.WriteLine("-------------------");
            }
        }
    }
}
