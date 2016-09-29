using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HurriyetNet
{
    class WriterParser
    {
        WebClient wc = new WebClient();
        public static JArray AllWriter
        {
            get
            {
                return new WriterParser().AllWriters();
            }
        }

        private JArray AllWriters()
        {
            wc.Encoding = Encoding.UTF8;
            string jsonFromUrl = wc.DownloadString(HurriyetConf.BaseUrl + "writers?apikey=" + HurriyetConf.ApiKey);
            JArray outData = JArray.Parse(jsonFromUrl);
            return outData;
        }

        protected internal JObject GetSingle(string id)
        {
            try
            {
                wc.Encoding = Encoding.UTF8;
                string jsonFromUrl = wc.DownloadString(HurriyetConf.BaseUrl + "writers/" + id + "?apikey=" + HurriyetConf.ApiKey);
                JObject outData = JObject.Parse(jsonFromUrl);
                return outData;
            }
            catch
            {
                return JObject.Parse("{ 'Message' : 'Error' }");
            }
        }
    }
}
