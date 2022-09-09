
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace RonNkanye
{
     class Program
    {
      

        static void Main(string[] args)
        {
             var client = new HttpClient();

            for (int i = 0;  i< 5; i++)
            {

             var KanyeURL = "https://api.kanye.rest/";
             var kanyeResponse = client.GetStringAsync(KanyeURL).Result;
             var KanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
             Console.WriteLine(KanyeQuote);
             Console.WriteLine();

             string RonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
             string RonResponse = client.GetStringAsync(RonURL).Result;
             var RonObject = JArray.Parse(RonResponse);
             Console.WriteLine(RonObject[0]);

            };

        }
    }
}
