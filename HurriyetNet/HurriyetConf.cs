using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurriyetNet
{
    public class HurriyetConf
    {
        private static string HurApi;

        public static string ApiKey
        {
            get
            {
                return HurApi;
            }
            set
            {
                HurApi = value;
            }
        }

        public static string BaseUrl
        { 
            
            get
            {
                return "https://api.hurriyet.com.tr/v1/";
            }
        }
    }
}
