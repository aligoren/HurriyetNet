using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;

namespace HurriyetNet
{
    public class Hurriyet
    {

        public static JArray AllArticles
        {
            get
            {
                return ArticleParser.AllArticle;
            }
            
        }

        
        public static JObject SingleArticle(string SingleID)
        {
            return new ArticleParser().GetSingle(SingleID);
        }


        public static JArray AllColumns
        {
            get
            {
                return ColumnParser.AllColumn;
            }

        }


        public static JObject SingleColumn(string SingleID)
        {
            return new ColumnParser().GetSingle(SingleID);
        }


        public static JObject GetDate
        {
            get
            {
                return DateParser.GetDate;
            }

        }

        public static JArray AllPhotoGalleries
        {
            get
            {
                return NewsPhotoGalleriesParser.AllPhotoGallery;
            }

        }


        public static JObject SinglePhotoGallery(string SingleID)
        {
            return new NewsPhotoGalleriesParser().GetSingle(SingleID);
        }


        public static JArray AllPages
        {
            get
            {
                return PageParser.AllPage;
            }

        }


        public static JObject SinglePage(string SingleID)
        {
            return new PageParser().GetSingle(SingleID);
        }


        public static JArray AllPaths
        {
            get
            {
                return PathParser.AllPath;
            }

        }


        public static JObject SinglePath(string SingleID)
        {
            return new PathParser().GetSingle(SingleID);
        }




        public static JArray AllWriters
        {
            get
            {
                return WriterParser.AllWriter;
            }

        }


        public static JObject SingleWriter(string SingleID)
        {
            return new WriterParser().GetSingle(SingleID);
        }
    }
}
