using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace GeekQuoteApi
{
    class Program
    {
        static HttpClient client = new HttpClient();
        public async static Task Main(string[] args)
        {
            while (true) { //forever process

                string response = await client.GetStringAsync("https://geek-quote-api.herokuapp.com/v1/quote");
                if (response != null)
                {
                    JObject obj =  JObject.Parse(response);
                    Console.WriteLine(String.Format("{0} says : {1} " , obj["author"] , obj["quote"]));
                    Console.WriteLine("                           ");
                    Thread.Sleep(500000);
                }
            }
        }
    }
}
