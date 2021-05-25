using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace Ron_and_Kanye_API
{
    class Program
    {
        static void Main(string[] args)
        {
            var kanyeClient = new HttpClient();
            var kanyeUrl = "https://api.kanye.rest";

            var kanyeResponse = kanyeClient.GetStringAsync(kanyeUrl).Result;

            //Console.WriteLine(response);
            //do this before the lower to see if the json is object or array.

            var KanyeQuote = JObject.Parse(kanyeResponse).
                GetValue("quote").ToString();

            Console.WriteLine($"Kanye - {KanyeQuote}");
            Console.WriteLine();

            var ronClient = new HttpClient();
            var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = kanyeClient.GetStringAsync(ronUrl).Result;

            //Console.WriteLine(ronResponse);

            var ronQuote = JArray.Parse(ronResponse).ToString().
                Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"Ron - {ronQuote}");
            Console.WriteLine();
            //Make a for loop for conversation. 

        }
    }
}
