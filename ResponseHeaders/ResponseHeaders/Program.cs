using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ResponseHeaders
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient())
            {
                Console.WriteLine("-------------");
                client.Proxy = null;
                client.DownloadString("https://myfirstschool.azurewebsites.net/");
                foreach (string item in client.ResponseHeaders)
                {
                    Console.WriteLine(item + "=" + client.ResponseHeaders[item]);
                }
                Console.ReadLine();
            }
        }
    }
}
