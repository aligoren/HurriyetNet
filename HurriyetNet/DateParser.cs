using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HurriyetNet
{
    class DateParser
    {
        WebClient wc = new WebClient();
        public static JObject GetDate
        {
            get
            {
                return new DateParser().GetDates();
            }
        }

        private JObject GetDates()
        {
            wc.Encoding = Encoding.UTF8;
            string jsonFromUrl = wc.DownloadString(HurriyetConf.BaseUrl + "date?apikey=" + HurriyetConf.ApiKey);
            JObject outData = JObject.Parse(jsonFromUrl);
            return outData;
        }
    }
}
