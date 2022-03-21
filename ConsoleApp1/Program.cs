using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Car myCar = new Car();
            //myCar.ShowInfo();
            //myCar.ChangeColor("black");
            ////myCar.OpenDoor();
            await MyHttpClientAsync();
        }
        static private async Task MyHttpClientAsync()
        {
            HttpClient client = new HttpClient();
            //string url = "https://www.google.com/";
            string url = "	https://ws.kinmen.gov.tw/001/Upload/0/relfile/0/0/07053f4e-31bc-41b9-913d-fc2c25480991.json";
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
