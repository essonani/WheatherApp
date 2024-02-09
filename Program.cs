using Newtonsoft.Json.Linq;

namespace WheatherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIkey=JObject.Parse(key).GetValue("APIKey").ToString();
            Console.WriteLine("enter your zip code");
            var zipCode=Console.ReadLine();
            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIkey}";
            Console.WriteLine("temperature: " + WheatherMap.GetTemp(apiCall));
        }
    }
}