using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace ffApiTest
{
    class Program
    {

        static void Main(string[] args)
        {
            var url = "https://www.fantasyfootballnerd.com/service/players/xml/yftn2uw58qsv/QB/";
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var rawResponse = String.Empty;

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                rawResponse = reader.ReadToEnd();
            }

            var player = JsonConvert.DeserializeObject<Player>(rawResponse);
            Console.WriteLine($"Player Name: {player.name}");
            Console.WriteLine($"Position: {player.position}");
            Console.WriteLine($"Team Abbr: {player.teamAbbr}");
        }
    }
}
