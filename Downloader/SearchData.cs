using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_MP3.Downloader
{
    class SearchData
    {
        public static string YTPostData(string searchString)
        {
            var requestRating = (HttpWebRequest)WebRequest.Create("http://bon.x10host.com/BON_API/YoutubeAPI.php");

            var postDataRating = "searchString=" + searchString;
            var banData = Encoding.ASCII.GetBytes(postDataRating);

            requestRating.Method = "POST";
            requestRating.ContentType = "application/x-www-form-urlencoded";
            requestRating.ContentLength = banData.Length;

            using (var stream = requestRating.GetRequestStream())
            {
                stream.Write(banData, 0, banData.Length);
            }

            var responseRating = (HttpWebResponse)requestRating.GetResponse();
            var responseString = new StreamReader(responseRating.GetResponseStream()).ReadToEnd();

            return responseString;
        }
    }
}
