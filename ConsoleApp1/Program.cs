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
            //myCar.OpenDoor();

            //await MyHttpClientAsync();

            //FileService File = new FileService();
            Console.WriteLine("請設定最小數字：");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請設定最大數字：");
            int max = Convert.ToInt32(Console.ReadLine());
            Game(min, max);

        }
        static private void Game(int min,int max)
        {
            int guess = 0, count = 1;
            int Ans = MyRandom(min, max);
            while (Ans != guess)
            {
                Console.WriteLine();
                Console.WriteLine("第" + count + "次");
                Console.WriteLine("請輸入一個數字(" + min + "~" + max + ")：");
                guess = Convert.ToInt32(Console.ReadLine());
                while (guess > max || guess < min)
                {
                    Console.WriteLine("請重新輸入一個數字(" + min + "~" + max + ")：");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                if (guess == Ans)
                {
                    Console.WriteLine("正確,共猜了" + count + "次");
                }
                else if (guess > Ans)
                {
                    max = guess;
                    Console.WriteLine("答案介於" + min + "~" + max + "之間");
                }
                else if (guess < Ans)
                {
                    min = guess;
                    Console.WriteLine("答案介於" + min + "~" + max + "之間");
                }
                count++;
            }
        }
        static private int MyRandom(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);

        }
        static private async Task MyHttpClientAsync()
        {
            HttpClient client = new HttpClient();
            //string url = "https://www.google.com/";
            string url = "https://ws.kinmen.gov.tw/001/Upload/0/relfile/0/0/07053f4e-31bc-41b9-913d-fc2c25480991.json";
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
