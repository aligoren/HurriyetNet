using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HurriyetNet
{
    class PageParser
    {
        WebClient wc = new WebClient();
        public static JArray AllPage
        {
            get
            {
                return new PageParser().AllPages();
            }
        }

        private JArray AllPages()
        {
            wc.Encoding = Encoding.UTF8;
            string jsonFromUrl = wc.DownloadString(HurriyetConf.BaseUrl + "pages?apikey=" + HurriyetConf.ApiKey);
            JArray outData = JArray.Parse(jsonFromUrl);
            return outData;
        }

        protected internal JObject GetSingle(string id)
        {
            try
            {
                wc.Encoding = Encoding.UTF8;
                string jsonFromUrl = wc.DownloadString(HurriyetConf.BaseUrl + "pages/" + id + "?apikey=" + HurriyetConf.ApiKey);
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
