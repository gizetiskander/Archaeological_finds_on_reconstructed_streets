using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Archaeological_finds_on_reconstructed_streets
{
    class Program
    {
        static void Main(string[] args)
        {
            var ApiKey = "7ab05438c2866a22db1483c273a267ef";
            var City = "Moscow";
            var url = $"https://apidata.mos.ru/v1/datasets/2541/features?appid={ApiKey}&q={City}&units=metric";

            var request = WebRequest.Create(url);

            var response = request.GetResponse();
            var httpStatusCode = (response as HttpWebResponse).StatusCode;

            if (httpStatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine(httpStatusCode);
                return;
            }

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();
                Console.WriteLine(result);
                var Geodatas = JsonConvert.DeserializeObject<Root>(result);
                Console.WriteLine(Geodatas.geoData.coordinates);
            }

        }
    }
}
