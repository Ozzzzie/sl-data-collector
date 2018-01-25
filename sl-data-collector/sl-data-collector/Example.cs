using System;
using System.IO;
using System.Net;
using SocketIo;
using SocketIo.SocketTypes;

namespace sl_data_collector
{
    public class Example
    {
        SocketIo.SocketIo Socket = Io.Create("127.0.0.1", 4533, 4533, SocketHandlerType.Tcp);

        public void GetInformation()
        {
            string html = string.Empty;
            string url = @"https://api.stackexchange.com/2.2/answers?order=desc&sort=activity&site=stackoverflow";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            Console.WriteLine(html);
        }
    }
}
