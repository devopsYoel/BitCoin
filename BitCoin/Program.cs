
using System;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Flurl.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BitCoin
{
    class Program
    {    
        static void Main()
        {
            int count = 0;
            float valueOdd = 0;
            Bitcoin m = null;
            string response = "";

            using (var client = new WebClient())
            {
                while(true)
                {
                    try
                    {
                        response = client.DownloadString("https://api.coindesk.com/v1/bpi/currentprice.json");
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Problem!!");
                        continue;
                    }

                    m = JsonConvert.DeserializeObject<Bitcoin>(response);

                    count++;

                    string value = m.bpi.usd.rate_float;

                    Console.WriteLine("Date and time: "+m.time.updated);
                    Console.WriteLine("Current value of Bitcoin: "+ value+" $");

                    float valueNew = float.Parse(value, CultureInfo.InvariantCulture.NumberFormat);
                    float average = (valueNew + valueOdd*(count-1)) / count;
                   

                    Console.WriteLine("Average Accumulative of Bitcoin: " + value + " $\n");
                    
                    
                    valueOdd = valueNew;

                        // sleep 5 sec and call api again
                   
                    System.Threading.Thread.Sleep(5000);

                }

            }


            
        }
    }       
      
}
